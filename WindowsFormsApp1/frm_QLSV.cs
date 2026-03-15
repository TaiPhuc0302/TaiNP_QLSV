using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_QLSV : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();

        public frm_QLSV()
        {
            InitializeComponent();

            // Gắn sự kiện Load cho form
            this.Load += Frm_QLSV_Load;
        }

        private void Frm_QLSV_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadData();
        }

        // 1. Hàm load dữ liệu lên DataGridView
        private void LoadData()
        {
            // Kết nối bảng SinhViens và bảng LopHocs
            var students = from s in db.SinhViens
                           join l in db.LopHocs on s.Lop equals l.MaLop
                           select new
                           {
                               s.MaSV,
                               s.TenSV,           // (Hoặc s.HoTen tùy theo database của bạn)
                               s.NgaySinh,
                               s.GioiTinh,
                               TenLop = l.TenLop, // Lấy Tên Lớp để hiển thị cho người dùng xem
                               MaLop = s.Lop      // Lấy Mã Lớp (để ẩn đi, dùng cho code)
                           };

            dgv_DSSV.DataSource = students.ToList();

            // Đổi tên cột cho đẹp
            dgv_DSSV.Columns["MaSV"].HeaderText = "Mã SV";
            dgv_DSSV.Columns["TenSV"].HeaderText = "Họ và Tên";
            dgv_DSSV.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgv_DSSV.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgv_DSSV.Columns["TenLop"].HeaderText = "Lớp"; // Hiển thị cột Tên Lớp

            // QUAN TRỌNG: Ẩn cột Mã Lớp đi để giao diện gọn gàng
            dgv_DSSV.Columns["MaLop"].Visible = false;
        }

        // 2. Hàm đổ dữ liệu vào ComboBox Giới tính và Lớp
        private void LoadComboBoxData()
        {
            // Cài đặt ComboBox Giới tính (Thêm lựa chọn rỗng cho phép NULL)
            cmb_gioitinh.Items.Clear();
            cmb_gioitinh.Items.Add("Nam");
            cmb_gioitinh.Items.Add("Nữ");
            cmb_gioitinh.Items.Add(""); // Thêm một dòng trống đại diện cho giá trị NULL

            cmb_gioitinh.SelectedIndex = 0; // Chọn mặc định là Nam (hoặc bạn có thể để là 2 để mặc định là Trống)

            // Đổ dữ liệu từ bảng LopHoc vào ComboBox Lớp
            var lopHocs = db.LopHocs.ToList();
            cmb_Lop.DataSource = lopHocs;
            cmb_Lop.DisplayMember = "TenLop";

            // CHÚ Ý: Phải là MaLop (khóa chính của bảng Lớp Học), không phải Lop
            cmb_Lop.ValueMember = "MaLop";
        }

        // 3. Sự kiện Click vào DataGridView để hiển thị dữ liệu lên form
        private void dgv_DSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DSSV.Rows[e.RowIndex];

                txb_masv.Text = row.Cells["MaSV"].Value?.ToString();
                txb_hoten.Text = row.Cells["TenSV"].Value?.ToString();

                if (row.Cells["NgaySinh"].Value != null && DateTime.TryParse(row.Cells["NgaySinh"].Value.ToString(), out DateTime ns))
                {
                    dt_ngaysinh.Value = ns;
                }

                cmb_gioitinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                cmb_Lop.SelectedValue = row.Cells["MaLop"].Value?.ToString(); // Chọn đúng lớp theo mã

                txb_masv.Enabled = false; // Khóa Mã SV khi đang xem/sửa
            }
        }

        // 4. Chức năng Làm mới
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txb_masv.Clear();
            txb_hoten.Clear();
            dt_ngaysinh.Value = DateTime.Now;
            cmb_gioitinh.SelectedIndex = 0;
            if (cmb_Lop.Items.Count > 0) cmb_Lop.SelectedIndex = 0;

            txb_SearchSV.Clear();
            txb_masv.Enabled = true; // Mở lại để nhập mới
            txb_masv.Focus();
            LoadData(); // Load lại toàn bộ data phòng khi đang bị filter bởi tìm kiếm
        }

        // 5. Chức năng Thêm
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txb_masv.Text) || string.IsNullOrWhiteSpace(txb_hoten.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Mã Sinh Viên và Họ Tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra trùng mã
                var kt = db.SinhViens.FirstOrDefault(s => s.MaSV == txb_masv.Text.Trim());
                if (kt != null)
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SinhVien sv = new SinhVien();
                sv.MaSV = txb_masv.Text.Trim();
                sv.TenSV = txb_hoten.Text.Trim();
                sv.NgaySinh = dt_ngaysinh.Value.Date;

                // Xử lý an toàn nếu giới tính bị để trống
                sv.GioiTinh = string.IsNullOrWhiteSpace(cmb_gioitinh.Text) ? null : cmb_gioitinh.Text;

                // Xử lý an toàn nếu chưa có lớp nào được chọn
                if (cmb_Lop.SelectedValue != null)
                {
                    sv.Lop = cmb_Lop.SelectedValue.ToString();
                }

                db.SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // QUAN TRỌNG: Gọi LoadData để cập nhật sinh viên mới lên DataGridView
                LoadData();

                btn_LamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                // Bắt mọi lỗi từ SQL Server hoặc Code và báo lên màn hình thay vì làm văng App
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Chi tiết lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 6. Chức năng Sửa
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var svSua = db.SinhViens.FirstOrDefault(s => s.MaSV == txb_masv.Text.Trim());
            if (svSua != null)
            {
                svSua.TenSV = txb_hoten.Text.Trim();
                svSua.NgaySinh = dt_ngaysinh.Value.Date;
                svSua.GioiTinh = cmb_gioitinh.Text;
                svSua.Lop = cmb_Lop.SelectedValue.ToString();

                db.SubmitChanges();
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 7. Chức năng Xóa
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var svXoa = db.SinhViens.FirstOrDefault(s => s.MaSV == txb_masv.Text.Trim());
            if (svXoa != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.SinhViens.DeleteOnSubmit(svXoa);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_LamMoi_Click(sender, e);
                }
            }
        }

        // 8. Chức năng Tìm kiếm (Khi click vào PictureBox)
        private void ptb_Search_Click(object sender, EventArgs e)
        {
            string keyword = txb_SearchSV.Text.Trim().ToLower();

            var result = from s in db.SinhViens
                         where s.MaSV.ToLower().Contains(keyword) || s.TenSV.ToLower().Contains(keyword)
                         select new
                         {
                             s.MaSV,
                             s.TenSV,
                             s.NgaySinh,
                             s.GioiTinh,
                             s.Lop
                         };

            dgv_DSSV.DataSource = result.ToList();
        }

        // 9. Điều hướng: Chuyển sang form Quản lý Lớp Học
        private void btn_QLLH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLLH frm = new frm_QLLH();
            frm.FormClosed += (s, args) => this.Show(); // Sửa lỗi Memory Leak
            frm.Show();
        }

        private void txb_masv_TextChanged(object sender, EventArgs e)
        {
            // Cứ để trống như thế này, hệ thống thấy có hàm là sẽ hết báo lỗi
        }
    }
}
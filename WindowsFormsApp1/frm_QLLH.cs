using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_QLLH : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();

        public frm_QLLH()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            var lopHoc = from c in db.LopHocs
                         select new
                         {
                             c.MaLop,
                             c.TenLop,
                             c.SiSo,
                         };
            dgv_DSLH.DataSource = lopHoc.ToList();
        }

        private void dgv_DSLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào một dòng hợp lệ không (tránh click vào tiêu đề)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DSLH.Rows[e.RowIndex];

                txb_maLophoc.Text = row.Cells["MaLop"].Value?.ToString();
                txb_tenLop.Text = row.Cells["TenLop"].Value?.ToString();
                txb_siSo.Text = row.Cells["SiSo"].Value?.ToString();

                // Khóa mã lớp lại không cho sửa (vì Mã lớp thường là Khóa chính)
                txb_maLophoc.Enabled = false;
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txb_maLophoc.Text = "";
            txb_tenLop.Text = "";
            txb_siSo.Text = "";
            txb_maLophoc.Enabled = true; // Mở lại ô Mã lớp để nhập mới
            txb_maLophoc.Focus();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra nhập liệu cơ bản
                if (string.IsNullOrWhiteSpace(txb_maLophoc.Text) || string.IsNullOrWhiteSpace(txb_tenLop.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Mã Lớp và Tên Lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Kiểm tra xem Mã Lớp đã tồn tại chưa
                var kiemTra = db.LopHocs.FirstOrDefault(l => l.MaLop == txb_maLophoc.Text.Trim());
                if (kiemTra != null)
                {
                    MessageBox.Show("Mã lớp này đã tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Tạo đối tượng mới và lưu vào DB
                LopHoc lopMoi = new LopHoc();
                lopMoi.MaLop = txb_maLophoc.Text.Trim();
                lopMoi.TenLop = txb_tenLop.Text.Trim();

                // Bắt lỗi nếu Sĩ số không phải là số
                int siSo;
                if (int.TryParse(txb_siSo.Text, out siSo))
                    lopMoi.SiSo = siSo;
                else
                    lopMoi.SiSo = 0;

                db.LopHocs.InsertOnSubmit(lopMoi);
                db.SubmitChanges(); // Cập nhật xuống Database

                MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Tải lại dữ liệu lên Grid
                loadData();
                btn_LamMoi_Click(sender, e); // Xóa rỗng các form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                // Tìm lớp học cần sửa dựa vào mã lớp
                var lopCầnSua = db.LopHocs.FirstOrDefault(l => l.MaLop == txb_maLophoc.Text.Trim());

                if (lopCầnSua != null)
                {
                    // Cập nhật thông tin
                    lopCầnSua.TenLop = txb_tenLop.Text.Trim();

                    int siSo;
                    if (int.TryParse(txb_siSo.Text, out siSo))
                        lopCầnSua.SiSo = siSo;

                    db.SubmitChanges(); // Lưu thay đổi xuống Database

                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp học để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var lopCanXoa = db.LopHocs.FirstOrDefault(l => l.MaLop == txb_maLophoc.Text.Trim());

                if (lopCanXoa != null)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        db.LopHocs.DeleteOnSubmit(lopCanXoa);
                        db.SubmitChanges(); // Thực thi lệnh xóa

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                        btn_LamMoi_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một lớp học để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Lỗi thường gặp: Xóa lớp đang có sinh viên tham chiếu (Lỗi Foreign Key)
                MessageBox.Show("Không thể xóa. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void link_QLSV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_QLSV frm = new frm_QLSV();

            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void link_QLLH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_QLLH frm = new frm_QLLH();
            frm.Show();
        }

        private void link_Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_Login frm = new frm_Login();
            frm.Show();
        }

        private void lbl_thongtinLop_Click(object sender, EventArgs e)
        {

        }
    }
}
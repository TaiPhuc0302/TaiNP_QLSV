using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_QLSV : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public frm_QLSV()
        {
            InitializeComponent();
        }

        private void frm_QLSV_Load(object sender, EventArgs e)
        {
            // Cài đặt ComboBox Giới tính
            cmb_gioitinh.Items.Clear();
            cmb_gioitinh.Items.Add("Nam");
            cmb_gioitinh.Items.Add("Nữ");

            LoadComboBoxLop();
            LoadData();
            btn_LamMoi_Click(sender, e);
        }

        private void dt_ngaysinh_ValueChanged(object sender, EventArgs e)
        {
            dt_ngaysinh.CustomFormat = "dd/MM/yyyy";
        }

        private void LoadComboBoxLop()
        {
            var listLop = db.LopHocs.ToList();

            cmb_Lop.DataSource = listLop;
            cmb_Lop.DisplayMember = "TenLop";
            cmb_Lop.ValueMember = "MaLop";
        }

        private void LoadData()
        {
            var query = from sv in db.SinhViens
                        join lh in db.LopHocs on sv.Lop equals lh.MaLop
                        select new
                        {
                            sv.MaSV,
                            sv.TenSV,
                            sv.GioiTinh,
                            sv.NgaySinh,
                            lh.TenLop,
                            sv.Lop
                        };

            dgv_DSSV.DataSource = query.ToList();

            if (dgv_DSSV.Columns.Contains("Lop"))
            {
                dgv_DSSV.Columns["Lop"].Visible = false;
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txb_masv.Clear();
            txb_hoten.Clear();
            cmb_gioitinh.SelectedIndex = -1;
            cmb_Lop.SelectedIndex = -1;

            dt_ngaysinh.Format = DateTimePickerFormat.Custom;
            dt_ngaysinh.CustomFormat = " ";

            txb_masv.Enabled = true;
            txb_masv.Focus();

            LoadData();
        }

        private void dgv_DSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DSSV.Rows[e.RowIndex];

                txb_masv.Text = row.Cells["MaSV"].Value.ToString();
                txb_hoten.Text = row.Cells["TenSV"].Value.ToString();
                cmb_gioitinh.Text = row.Cells["GioiTinh"].Value?.ToString();

                if (row.Cells["NgaySinh"].Value != null)
                {
                    dt_ngaysinh.CustomFormat = "dd/MM/yyyy";
                    dt_ngaysinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                }

                cmb_Lop.SelectedValue = row.Cells["Lop"].Value.ToString();
                txb_masv.Enabled = false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_masv.Text) || cmb_Lop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đủ Mã SV và chọn Lớp!", "Thông báo");
                return;
            }

            try
            {
                SinhVien svNew = new SinhVien();
                svNew.MaSV = txb_masv.Text;
                svNew.TenSV = txb_hoten.Text;
                svNew.GioiTinh = cmb_gioitinh.Text;
                svNew.Lop = cmb_Lop.SelectedValue.ToString();

                if (dt_ngaysinh.CustomFormat != " ")
                    svNew.NgaySinh = dt_ngaysinh.Value.Date;

                db.SinhViens.InsertOnSubmit(svNew);
                db.SubmitChanges();

                MessageBox.Show("Thêm thành công!", "Thông báo");
                LoadData();
                btn_LamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txb_masv.Enabled) return;

            try
            {
                var svEdit = db.SinhViens.SingleOrDefault(s => s.MaSV == txb_masv.Text);

                if (svEdit != null)
                {
                    svEdit.TenSV = txb_hoten.Text;
                    svEdit.GioiTinh = cmb_gioitinh.Text;
                    svEdit.Lop = cmb_Lop.SelectedValue.ToString();

                    if (dt_ngaysinh.CustomFormat != " ")
                        svEdit.NgaySinh = dt_ngaysinh.Value.Date;

                    db.SubmitChanges();

                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txb_masv.Enabled) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var svDelete = db.SinhViens.SingleOrDefault(s => s.MaSV == txb_masv.Text);

                    if (svDelete != null)
                    {
                        db.SinhViens.DeleteOnSubmit(svDelete);
                        db.SubmitChanges();

                        MessageBox.Show("Đã xóa thành công!", "Thông báo");
                        LoadData();
                        btn_LamMoi_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void ptb_Search_Click(object sender, EventArgs e)
        {
            string keyword = txb_SearchSV.Text.Trim();

            var query = from sv in db.SinhViens
                        join lh in db.LopHocs on sv.Lop equals lh.MaLop
                        where sv.TenSV.Contains(keyword) || sv.MaSV.Contains(keyword)
                        select new
                        {
                            sv.MaSV,
                            sv.TenSV,
                            sv.GioiTinh,
                            sv.NgaySinh,
                            lh.TenLop,
                            sv.Lop
                        };

            dgv_DSSV.DataSource = query.ToList();
        }

        private void btn_QLLH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLLH frm = new frm_QLLH();
            frm.ShowDialog();
            this.Close();
        }
    }
}
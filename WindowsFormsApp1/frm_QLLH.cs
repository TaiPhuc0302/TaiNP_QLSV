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
        }

        private void frm_QLLH_Load(object sender, EventArgs e)
        {
            loadData();
            btn_LamMoi_Click(sender, e);
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

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txb_maLophoc.Clear();
            txb_tenLop.Clear();
            txb_siSo.Clear();

            txb_maLophoc.Enabled = true;
            txb_maLophoc.Focus();
            loadData();
        }

        private void dgv_DSLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DSLH.Rows[e.RowIndex];
                txb_maLophoc.Text = row.Cells["MaLop"].Value.ToString();
                txb_tenLop.Text = row.Cells["TenLop"].Value.ToString();
                txb_siSo.Text = row.Cells["SiSo"].Value.ToString();
                txb_maLophoc.Enabled = false; // Không cho phép sửa Mã Lớp
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_maLophoc.Text) || string.IsNullOrWhiteSpace(txb_tenLop.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                LopHoc newLop = new LopHoc();
                newLop.MaLop = txb_maLophoc.Text;
                newLop.TenLop = txb_tenLop.Text;
                if (int.TryParse(txb_siSo.Text, out int siSo))
                {
                    newLop.SiSo = siSo;
                }
                else
                {
                    MessageBox.Show("Sĩ số phải là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                db.LopHocs.InsertOnSubmit(newLop);
                db.SubmitChanges();
                MessageBox.Show("Thêm lớp học thành công!", "Thông báo");
                loadData();
                btn_LamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txb_maLophoc.Enabled) return;

            try
            {
                var EditLop = db.LopHocs.SingleOrDefault(l => l.MaLop == txb_maLophoc.Text);

                if (EditLop != null)
                {
                    EditLop.TenLop = txb_tenLop.Text;
                    if (int.TryParse(txb_siSo.Text, out int siSo))
                    {
                        EditLop.SiSo = siSo;
                    }
                    else
                    {
                        MessageBox.Show("Sĩ số phải là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    db.SubmitChanges();
                    MessageBox.Show("Sửa lớp học thành công!", "Thông báo");
                    loadData();
                    btn_LamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp học để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txb_maLophoc.Enabled) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa lớp học này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var DeleteLop = db.LopHocs.SingleOrDefault(l => l.MaLop == txb_maLophoc.Text);
                    if (DeleteLop != null)
                    {
                        db.LopHocs.DeleteOnSubmit(DeleteLop);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa lớp học thành công!", "Thông báo");
                        loadData();
                        btn_LamMoi_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ptb_Search_Click(object sender, EventArgs e)
        {
            string keyword = txb_SearchLH.Text.Trim();
            var searchResult = from c in db.LopHocs
                               where c.MaLop.Contains(keyword) || c.TenLop.Contains(keyword)
                               select new
                               {
                                   c.MaLop,
                                   c.TenLop,
                                   c.SiSo,
                               };
            dgv_DSLH.DataSource = searchResult.ToList();
        }

        private void btn_QLSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLSV frmQLSV = new frm_QLSV();
            frmQLSV.ShowDialog();
            this.Close();
        }
    }
}
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

        private void link_QLSV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_QLSV frm = new frm_QLSV();
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
    }
}

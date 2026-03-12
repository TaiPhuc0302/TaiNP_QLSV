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
    public partial class frm_Login : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text.Trim();
            string password = txt_Password.Text.Trim();
            var user = db.TaiKhoans.SingleOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                frm_QLSV frm = new frm_QLSV();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}

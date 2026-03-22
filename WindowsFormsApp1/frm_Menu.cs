using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class frm_Menu : Form
    {
        private MenuStrip menuStrip;
        private ToolStripMenuItem mnSinhVien;
        private ToolStripMenuItem mnLopHoc;
        private ToolStripMenuItem mnDangXuat;
        private Panel pnlMain;
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Menu";
            this.Width = 800;
            this.Height = 600;

            // ===== MENU =====
            menuStrip = new MenuStrip();
            menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            mnSinhVien = new ToolStripMenuItem("Quản lý sinh viên");
            mnLopHoc = new ToolStripMenuItem("Quản lý lớp học");
            mnDangXuat = new ToolStripMenuItem("Đăng xuất");

            menuStrip.Items.Add(mnSinhVien);
            menuStrip.Items.Add(mnLopHoc);
            menuStrip.Items.Add(mnDangXuat);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
            this.Load += new System.EventHandler(this.frm_Menu_Load);

            pnlMain = new Panel();
            pnlMain.Dock = DockStyle.Fill;

            // Đặt dưới menu
            pnlMain.Top = menuStrip.Height;

            this.Controls.Add(pnlMain);

            // ===== EVENT =====
            mnSinhVien.Click += MnSinhVien_Click;
            mnLopHoc.Click += MnLopHoc_Click;
            mnDangXuat.Click += MnDangXuat_Click;
        }

        // ===== EVENT =====
        private void MnSinhVien_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_QLSV());
        }

        private void MnLopHoc_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_QLLH());
        }

        private void OpenForm(Form f)
        {
            pnlMain.Controls.Clear(); 

            f.TopLevel = false;       
            f.Dock = DockStyle.Fill;  

            pnlMain.Controls.Add(f);
            f.Show();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            OpenForm(new frm_QLSV()); 
        }

        private void MnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất?",
                "Xác nhận",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
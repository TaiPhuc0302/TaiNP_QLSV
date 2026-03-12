namespace WindowsFormsApp1
{
    partial class frm_QLSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLSV));
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.link_Home = new System.Windows.Forms.LinkLabel();
            this.ptb_avatar = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.link_QLLH = new System.Windows.Forms.LinkLabel();
            this.link_QLSV = new System.Windows.Forms.LinkLabel();
            this.dgv_DSSV = new System.Windows.Forms.DataGridView();
            this.pnl_function = new System.Windows.Forms.Panel();
            this.txt_SearchSV = new System.Windows.Forms.TextBox();
            this.ptb_Search = new System.Windows.Forms.PictureBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.pnl_topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).BeginInit();
            this.pnl_function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnl_topBar.Controls.Add(this.link_Home);
            this.pnl_topBar.Controls.Add(this.ptb_avatar);
            this.pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(800, 50);
            this.pnl_topBar.TabIndex = 0;
            // 
            // link_Home
            // 
            this.link_Home.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.link_Home.AutoSize = true;
            this.link_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Home.LinkArea = new System.Windows.Forms.LinkArea(0, 9);
            this.link_Home.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_Home.LinkColor = System.Drawing.Color.Black;
            this.link_Home.Location = new System.Drawing.Point(3, 9);
            this.link_Home.Name = "link_Home";
            this.link_Home.Size = new System.Drawing.Size(163, 37);
            this.link_Home.TabIndex = 1;
            this.link_Home.TabStop = true;
            this.link_Home.Text = "Trang chủ";
            this.link_Home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Home_LinkClicked);
            // 
            // ptb_avatar
            // 
            this.ptb_avatar.Image = ((System.Drawing.Image)(resources.GetObject("ptb_avatar.Image")));
            this.ptb_avatar.Location = new System.Drawing.Point(675, 0);
            this.ptb_avatar.Name = "ptb_avatar";
            this.ptb_avatar.Size = new System.Drawing.Size(100, 50);
            this.ptb_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_avatar.TabIndex = 0;
            this.ptb_avatar.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SeaShell;
            this.splitContainer1.Panel1.Controls.Add(this.link_QLLH);
            this.splitContainer1.Panel1.Controls.Add(this.link_QLSV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_DSSV);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_function);
            this.splitContainer1.Size = new System.Drawing.Size(800, 400);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 1;
            // 
            // link_QLLH
            // 
            this.link_QLLH.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.link_QLLH.LinkArea = new System.Windows.Forms.LinkArea(0, 15);
            this.link_QLLH.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_QLLH.LinkColor = System.Drawing.Color.Black;
            this.link_QLLH.Location = new System.Drawing.Point(0, 28);
            this.link_QLLH.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.link_QLLH.Name = "link_QLLH";
            this.link_QLLH.Size = new System.Drawing.Size(203, 24);
            this.link_QLLH.TabIndex = 1;
            this.link_QLLH.TabStop = true;
            this.link_QLLH.Text = "Quản lý Lớp học";
            this.link_QLLH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_QLLH_LinkClicked);
            // 
            // link_QLSV
            // 
            this.link_QLSV.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.link_QLSV.LinkArea = new System.Windows.Forms.LinkArea(0, 17);
            this.link_QLSV.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_QLSV.LinkColor = System.Drawing.Color.Black;
            this.link_QLSV.Location = new System.Drawing.Point(0, 6);
            this.link_QLSV.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.link_QLSV.Name = "link_QLSV";
            this.link_QLSV.Size = new System.Drawing.Size(203, 21);
            this.link_QLSV.TabIndex = 0;
            this.link_QLSV.TabStop = true;
            this.link_QLSV.Text = "Quản lý Sinh viên";
            this.link_QLSV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_QLSV_LinkClicked);
            // 
            // dgv_DSSV
            // 
            this.dgv_DSSV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_DSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSSV.Location = new System.Drawing.Point(0, 52);
            this.dgv_DSSV.Name = "dgv_DSSV";
            this.dgv_DSSV.RowHeadersWidth = 62;
            this.dgv_DSSV.RowTemplate.Height = 28;
            this.dgv_DSSV.Size = new System.Drawing.Size(593, 348);
            this.dgv_DSSV.TabIndex = 1;
            // 
            // pnl_function
            // 
            this.pnl_function.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnl_function.Controls.Add(this.txt_SearchSV);
            this.pnl_function.Controls.Add(this.ptb_Search);
            this.pnl_function.Controls.Add(this.btn_Xoa);
            this.pnl_function.Controls.Add(this.btn_Sua);
            this.pnl_function.Controls.Add(this.btn_them);
            this.pnl_function.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_function.Location = new System.Drawing.Point(0, 0);
            this.pnl_function.Name = "pnl_function";
            this.pnl_function.Size = new System.Drawing.Size(593, 52);
            this.pnl_function.TabIndex = 0;
            // 
            // txt_SearchSV
            // 
            this.txt_SearchSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchSV.Location = new System.Drawing.Point(17, 12);
            this.txt_SearchSV.Margin = new System.Windows.Forms.Padding(0);
            this.txt_SearchSV.Name = "txt_SearchSV";
            this.txt_SearchSV.Size = new System.Drawing.Size(267, 26);
            this.txt_SearchSV.TabIndex = 0;
            // 
            // ptb_Search
            // 
            this.ptb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ptb_Search.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Search.Image = global::WindowsFormsApp1.Properties.Resources.loupe;
            this.ptb_Search.Location = new System.Drawing.Point(284, 12);
            this.ptb_Search.Margin = new System.Windows.Forms.Padding(0);
            this.ptb_Search.Name = "ptb_Search";
            this.ptb_Search.Size = new System.Drawing.Size(51, 30);
            this.ptb_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Search.TabIndex = 0;
            this.ptb_Search.TabStop = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.Location = new System.Drawing.Point(522, 10);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(59, 30);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.Location = new System.Drawing.Point(457, 10);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(59, 30);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_them.Location = new System.Drawing.Point(383, 10);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(68, 30);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // frm_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnl_topBar);
            this.Name = "frm_QLSV";
            this.Text = "frm_QLSV";
            this.pnl_topBar.ResumeLayout(false);
            this.pnl_topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avatar)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).EndInit();
            this.pnl_function.ResumeLayout(false);
            this.pnl_function.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox ptb_avatar;
        private System.Windows.Forms.LinkLabel link_Home;
        private System.Windows.Forms.LinkLabel link_QLSV;
        private System.Windows.Forms.LinkLabel link_QLLH;
        private System.Windows.Forms.Panel pnl_function;
        private System.Windows.Forms.TextBox txt_SearchSV;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_DSSV;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.PictureBox ptb_Search;
    }
}
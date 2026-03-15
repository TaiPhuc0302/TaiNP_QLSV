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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.cmb_Lop = new System.Windows.Forms.ComboBox();
            this.btn_QLLH = new System.Windows.Forms.Button();
            this.cmb_gioitinh = new System.Windows.Forms.ComboBox();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txb_hoten = new System.Windows.Forms.TextBox();
            this.txb_masv = new System.Windows.Forms.TextBox();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.lbl_masv = new System.Windows.Forms.Label();
            this.lbl_thongtinsv = new System.Windows.Forms.Label();
            this.dgv_DSSV = new System.Windows.Forms.DataGridView();
            this.pnl_function = new System.Windows.Forms.Panel();
            this.txb_SearchSV = new System.Windows.Forms.TextBox();
            this.ptb_Search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).BeginInit();
            this.pnl_function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Snow;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_Lop);
            this.splitContainer1.Panel1.Controls.Add(this.btn_QLLH);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_gioitinh);
            this.splitContainer1.Panel1.Controls.Add(this.dt_ngaysinh);
            this.splitContainer1.Panel1.Controls.Add(this.txb_hoten);
            this.splitContainer1.Panel1.Controls.Add(this.txb_masv);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_lop);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_gioitinh);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_ngaysinh);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_hoten);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_masv);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_thongtinsv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_DSSV);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_function);
            this.splitContainer1.Size = new System.Drawing.Size(899, 648);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_LamMoi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Xoa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Sua, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 455);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 100);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Lime;
            this.btn_them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_them.Location = new System.Drawing.Point(3, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(135, 44);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.LightGray;
            this.btn_LamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_LamMoi.Location = new System.Drawing.Point(144, 53);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(135, 44);
            this.btn_LamMoi.TabIndex = 15;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Xoa.Location = new System.Drawing.Point(3, 53);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(135, 44);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Yellow;
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sua.Location = new System.Drawing.Point(144, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(135, 44);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // cmb_Lop
            // 
            this.cmb_Lop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Lop.FormattingEnabled = true;
            this.cmb_Lop.Location = new System.Drawing.Point(9, 389);
            this.cmb_Lop.Name = "cmb_Lop";
            this.cmb_Lop.Size = new System.Drawing.Size(282, 28);
            this.cmb_Lop.TabIndex = 17;
            // 
            // btn_QLLH
            // 
            this.btn_QLLH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QLLH.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_QLLH.Location = new System.Drawing.Point(9, 561);
            this.btn_QLLH.Name = "btn_QLLH";
            this.btn_QLLH.Size = new System.Drawing.Size(282, 50);
            this.btn_QLLH.TabIndex = 16;
            this.btn_QLLH.Text = "Quản lý Lớp học";
            this.btn_QLLH.UseVisualStyleBackColor = false;
            this.btn_QLLH.Click += new System.EventHandler(this.btn_QLLH_Click);
            // 
            // cmb_gioitinh
            // 
            this.cmb_gioitinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_gioitinh.FormattingEnabled = true;
            this.cmb_gioitinh.Location = new System.Drawing.Point(9, 308);
            this.cmb_gioitinh.Name = "cmb_gioitinh";
            this.cmb_gioitinh.Size = new System.Drawing.Size(282, 28);
            this.cmb_gioitinh.TabIndex = 14;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_ngaysinh.Location = new System.Drawing.Point(9, 231);
            this.dt_ngaysinh.MaxDate = new System.DateTime(2026, 3, 14, 0, 0, 0, 0);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(283, 26);
            this.dt_ngaysinh.TabIndex = 13;
            this.dt_ngaysinh.Value = new System.DateTime(2026, 3, 14, 0, 0, 0, 0);
            this.dt_ngaysinh.ValueChanged += new System.EventHandler(this.dt_ngaysinh_ValueChanged);
            // 
            // txb_hoten
            // 
            this.txb_hoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_hoten.Location = new System.Drawing.Point(9, 157);
            this.txb_hoten.Name = "txb_hoten";
            this.txb_hoten.Size = new System.Drawing.Size(283, 26);
            this.txb_hoten.TabIndex = 10;
            // 
            // txb_masv
            // 
            this.txb_masv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_masv.Location = new System.Drawing.Point(9, 83);
            this.txb_masv.Name = "txb_masv";
            this.txb_masv.Size = new System.Drawing.Size(283, 26);
            this.txb_masv.TabIndex = 12;
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lop.Location = new System.Drawing.Point(7, 361);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(47, 25);
            this.lbl_lop.TabIndex = 4;
            this.lbl_lop.Text = "Lớp";
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioitinh.Location = new System.Drawing.Point(7, 280);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(90, 25);
            this.lbl_gioitinh.TabIndex = 5;
            this.lbl_gioitinh.Text = "Giới tính";
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaysinh.Location = new System.Drawing.Point(7, 203);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(100, 25);
            this.lbl_ngaysinh.TabIndex = 6;
            this.lbl_ngaysinh.Text = "Ngày sinh";
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoten.Location = new System.Drawing.Point(7, 129);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(97, 25);
            this.lbl_hoten.TabIndex = 7;
            this.lbl_hoten.Text = "Họ và tên";
            // 
            // lbl_masv
            // 
            this.lbl_masv.AutoSize = true;
            this.lbl_masv.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masv.Location = new System.Drawing.Point(7, 55);
            this.lbl_masv.Name = "lbl_masv";
            this.lbl_masv.Size = new System.Drawing.Size(125, 25);
            this.lbl_masv.TabIndex = 8;
            this.lbl_masv.Text = "Mã sinh viên";
            // 
            // lbl_thongtinsv
            // 
            this.lbl_thongtinsv.AutoSize = true;
            this.lbl_thongtinsv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongtinsv.Location = new System.Drawing.Point(12, 9);
            this.lbl_thongtinsv.Name = "lbl_thongtinsv";
            this.lbl_thongtinsv.Size = new System.Drawing.Size(234, 32);
            this.lbl_thongtinsv.TabIndex = 9;
            this.lbl_thongtinsv.Text = "Thông tin sinh viên";
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
            this.dgv_DSSV.Size = new System.Drawing.Size(588, 596);
            this.dgv_DSSV.TabIndex = 1;
            this.dgv_DSSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSSV_CellClick);
            // 
            // pnl_function
            // 
            this.pnl_function.BackColor = System.Drawing.Color.Snow;
            this.pnl_function.Controls.Add(this.txb_SearchSV);
            this.pnl_function.Controls.Add(this.ptb_Search);
            this.pnl_function.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_function.Location = new System.Drawing.Point(0, 0);
            this.pnl_function.Name = "pnl_function";
            this.pnl_function.Size = new System.Drawing.Size(588, 52);
            this.pnl_function.TabIndex = 0;
            // 
            // txb_SearchSV
            // 
            this.txb_SearchSV.Location = new System.Drawing.Point(17, 12);
            this.txb_SearchSV.Margin = new System.Windows.Forms.Padding(0);
            this.txb_SearchSV.Name = "txb_SearchSV";
            this.txb_SearchSV.Size = new System.Drawing.Size(341, 26);
            this.txb_SearchSV.TabIndex = 0;
            // 
            // ptb_Search
            // 
            this.ptb_Search.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Search.Image = global::WindowsFormsApp1.Properties.Resources.loupe;
            this.ptb_Search.Location = new System.Drawing.Point(358, 12);
            this.ptb_Search.Margin = new System.Windows.Forms.Padding(0);
            this.ptb_Search.Name = "ptb_Search";
            this.ptb_Search.Size = new System.Drawing.Size(51, 30);
            this.ptb_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Search.TabIndex = 0;
            this.ptb_Search.TabStop = false;
            this.ptb_Search.Click += new System.EventHandler(this.ptb_Search_Click);
            // 
            // frm_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 648);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_QLSV";
            this.Text = "frm_QLSV";
            this.Load += new System.EventHandler(this.frm_QLSV_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).EndInit();
            this.pnl_function.ResumeLayout(false);
            this.pnl_function.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.ComboBox cmb_Lop;
        private System.Windows.Forms.Button btn_QLLH;
        private System.Windows.Forms.ComboBox cmb_gioitinh;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.TextBox txb_hoten;
        private System.Windows.Forms.TextBox txb_masv;
        private System.Windows.Forms.Label lbl_lop;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.Label lbl_masv;
        private System.Windows.Forms.Label lbl_thongtinsv;
        private System.Windows.Forms.DataGridView dgv_DSSV;
        private System.Windows.Forms.Panel pnl_function;
        private System.Windows.Forms.TextBox txb_SearchSV;
        private System.Windows.Forms.PictureBox ptb_Search;
    }
}
namespace WindowsFormsApp1
{
    partial class frm_QLLH
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
            this.txb_siSo = new System.Windows.Forms.TextBox();
            this.lbl_siSo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_QLSV = new System.Windows.Forms.Button();
            this.btn_XemSV = new System.Windows.Forms.Button();
            this.txb_tenLop = new System.Windows.Forms.TextBox();
            this.txb_maLophoc = new System.Windows.Forms.TextBox();
            this.lbl_tenLop = new System.Windows.Forms.Label();
            this.lbl_maLophoc = new System.Windows.Forms.Label();
            this.lbl_thongtinLop = new System.Windows.Forms.Label();
            this.dgv_DSLH = new System.Windows.Forms.DataGridView();
            this.pnl_function = new System.Windows.Forms.Panel();
            this.txb_SearchLH = new System.Windows.Forms.TextBox();
            this.ptb_Search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSLH)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txb_siSo);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_siSo);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_QLSV);
            this.splitContainer1.Panel1.Controls.Add(this.txb_tenLop);
            this.splitContainer1.Panel1.Controls.Add(this.txb_maLophoc);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_tenLop);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_maLophoc);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_thongtinLop);
            this.splitContainer1.Panel1.Controls.Add(this.btn_XemSV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_DSLH);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_function);
            this.splitContainer1.Size = new System.Drawing.Size(928, 667);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 2;
            // 
            // txb_siSo
            // 
            this.txb_siSo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_siSo.Location = new System.Drawing.Point(9, 229);
            this.txb_siSo.Name = "txb_siSo";
            this.txb_siSo.Size = new System.Drawing.Size(283, 26);
            this.txb_siSo.TabIndex = 20;
            // 
            // lbl_siSo
            // 
            this.lbl_siSo.AutoSize = true;
            this.lbl_siSo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_siSo.Location = new System.Drawing.Point(7, 201);
            this.lbl_siSo.Name = "lbl_siSo";
            this.lbl_siSo.Size = new System.Drawing.Size(59, 25);
            this.lbl_siSo.TabIndex = 19;
            this.lbl_siSo.Text = "Sĩ Số";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 474);
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
            // btn_QLSV
            // 
            this.btn_QLSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QLSV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_QLSV.Location = new System.Drawing.Point(9, 580);
            this.btn_QLSV.Name = "btn_QLSV";
            this.btn_QLSV.Size = new System.Drawing.Size(282, 50);
            this.btn_QLSV.TabIndex = 16;
            this.btn_QLSV.Text = "Quản lý Sinh viên";
            this.btn_QLSV.UseVisualStyleBackColor = false;
            this.btn_QLSV.Click += new System.EventHandler(this.btn_QLSV_Click);
            //
            // btn_XemSV
            //
            this.btn_XemSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XemSV.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_XemSV.Location = new System.Drawing.Point(9, 640);
            this.btn_XemSV.Name = "btn_XemSV";
            this.btn_XemSV.Size = new System.Drawing.Size(282, 40);
            this.btn_XemSV.TabIndex = 21;
            this.btn_XemSV.Text = "Xem DS Sinh viên theo lớp";
            this.btn_XemSV.UseVisualStyleBackColor = false;
            this.btn_XemSV.Click += new System.EventHandler(this.btn_XemSV_Click);
            // 
            // txb_tenLop
            // 
            this.txb_tenLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_tenLop.Location = new System.Drawing.Point(9, 157);
            this.txb_tenLop.Name = "txb_tenLop";
            this.txb_tenLop.Size = new System.Drawing.Size(283, 26);
            this.txb_tenLop.TabIndex = 10;
            // 
            // txb_maLophoc
            // 
            this.txb_maLophoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_maLophoc.Location = new System.Drawing.Point(9, 83);
            this.txb_maLophoc.Name = "txb_maLophoc";
            this.txb_maLophoc.Size = new System.Drawing.Size(283, 26);
            this.txb_maLophoc.TabIndex = 12;
            // 
            // lbl_tenLop
            // 
            this.lbl_tenLop.AutoSize = true;
            this.lbl_tenLop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenLop.Location = new System.Drawing.Point(7, 129);
            this.lbl_tenLop.Name = "lbl_tenLop";
            this.lbl_tenLop.Size = new System.Drawing.Size(87, 25);
            this.lbl_tenLop.TabIndex = 7;
            this.lbl_tenLop.Text = "Tên Lớp";
            // 
            // lbl_maLophoc
            // 
            this.lbl_maLophoc.AutoSize = true;
            this.lbl_maLophoc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maLophoc.Location = new System.Drawing.Point(7, 55);
            this.lbl_maLophoc.Name = "lbl_maLophoc";
            this.lbl_maLophoc.Size = new System.Drawing.Size(119, 25);
            this.lbl_maLophoc.TabIndex = 8;
            this.lbl_maLophoc.Text = "Mã Lớp học";
            // 
            // lbl_thongtinLop
            // 
            this.lbl_thongtinLop.AutoSize = true;
            this.lbl_thongtinLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongtinLop.Location = new System.Drawing.Point(12, 9);
            this.lbl_thongtinLop.Name = "lbl_thongtinLop";
            this.lbl_thongtinLop.Size = new System.Drawing.Size(174, 32);
            this.lbl_thongtinLop.TabIndex = 9;
            this.lbl_thongtinLop.Text = "Thông tin Lớp";
            // 
            // dgv_DSLH
            // 
            this.dgv_DSLH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_DSLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSLH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSLH.Location = new System.Drawing.Point(0, 52);
            this.dgv_DSLH.Name = "dgv_DSLH";
            this.dgv_DSLH.RowHeadersWidth = 62;
            this.dgv_DSLH.RowTemplate.Height = 28;
            this.dgv_DSLH.Size = new System.Drawing.Size(617, 615);
            this.dgv_DSLH.TabIndex = 1;
            this.dgv_DSLH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSLH_CellClick);
            // 
            // pnl_function
            // 
            this.pnl_function.BackColor = System.Drawing.Color.Snow;
            this.pnl_function.Controls.Add(this.txb_SearchLH);
            this.pnl_function.Controls.Add(this.ptb_Search);
            this.pnl_function.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_function.Location = new System.Drawing.Point(0, 0);
            this.pnl_function.Name = "pnl_function";
            this.pnl_function.Size = new System.Drawing.Size(617, 52);
            this.pnl_function.TabIndex = 0;
            // 
            // txb_SearchLH
            // 
            this.txb_SearchLH.Location = new System.Drawing.Point(17, 12);
            this.txb_SearchLH.Margin = new System.Windows.Forms.Padding(0);
            this.txb_SearchLH.Name = "txb_SearchLH";
            this.txb_SearchLH.Size = new System.Drawing.Size(341, 26);
            this.txb_SearchLH.TabIndex = 0;
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
            // frm_QLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 667);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_QLLH";
            this.Text = "frm_QLLH";
            this.Load += new System.EventHandler(this.frm_QLLH_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSLH)).EndInit();
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
        private System.Windows.Forms.Button btn_QLSV;
        private System.Windows.Forms.TextBox txb_tenLop;
        private System.Windows.Forms.TextBox txb_maLophoc;
        private System.Windows.Forms.Label lbl_tenLop;
        private System.Windows.Forms.Label lbl_maLophoc;
        private System.Windows.Forms.Label lbl_thongtinLop;
        private System.Windows.Forms.DataGridView dgv_DSLH;
        private System.Windows.Forms.Panel pnl_function;
        private System.Windows.Forms.TextBox txb_SearchLH;
        private System.Windows.Forms.PictureBox ptb_Search;
        private System.Windows.Forms.TextBox txb_siSo;
        private System.Windows.Forms.Label lbl_siSo;
        private System.Windows.Forms.Button btn_XemSV;
    }
}
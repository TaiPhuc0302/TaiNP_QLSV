namespace WindowsFormsApp1
{
    partial class frm_Login
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
            this.card_Login = new System.Windows.Forms.Panel();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.ckb_Remember = new System.Windows.Forms.CheckBox();
            this.card_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // card_Login
            // 
            this.card_Login.BackColor = System.Drawing.SystemColors.Control;
            this.card_Login.Controls.Add(this.ckb_Remember);
            this.card_Login.Controls.Add(this.lbl_Password);
            this.card_Login.Controls.Add(this.lbl_Username);
            this.card_Login.Controls.Add(this.btn_Login);
            this.card_Login.Controls.Add(this.lbl_Login);
            this.card_Login.Controls.Add(this.txt_Password);
            this.card_Login.Controls.Add(this.txt_Username);
            this.card_Login.Location = new System.Drawing.Point(237, 42);
            this.card_Login.Name = "card_Login";
            this.card_Login.Padding = new System.Windows.Forms.Padding(20);
            this.card_Login.Size = new System.Drawing.Size(320, 390);
            this.card_Login.TabIndex = 0;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(23, 141);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 20);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(23, 76);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(83, 20);
            this.lbl_Username.TabIndex = 4;
            this.lbl_Username.Text = "Username";
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.AutoSize = true;
            this.btn_Login.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Login.Location = new System.Drawing.Point(107, 280);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btn_Login.Size = new System.Drawing.Size(107, 51);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Login
            // 
            this.lbl_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(20, 20);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(280, 37);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Đăng nhập";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Password.Location = new System.Drawing.Point(23, 161);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(274, 37);
            this.txt_Password.TabIndex = 2;
            // 
            // txt_Username
            // 
            this.txt_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Username.Location = new System.Drawing.Point(23, 96);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(274, 37);
            this.txt_Username.TabIndex = 1;
            // 
            // ckb_Remember
            // 
            this.ckb_Remember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb_Remember.AutoSize = true;
            this.ckb_Remember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Remember.Location = new System.Drawing.Point(23, 220);
            this.ckb_Remember.Name = "ckb_Remember";
            this.ckb_Remember.Size = new System.Drawing.Size(211, 33);
            this.ckb_Remember.TabIndex = 6;
            this.ckb_Remember.Text = "Remember Me";
            this.ckb_Remember.UseVisualStyleBackColor = true;
            // 
            // frm_Login
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(781, 514);
            this.Controls.Add(this.card_Login);
            this.Name = "frm_Login";
            this.card_Login.ResumeLayout(false);
            this.card_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel card_Login;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.CheckBox ckb_Remember;
    }
}


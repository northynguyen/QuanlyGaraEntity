namespace QLGara
{
    partial class FDangNhap
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
            this.tlp_dangNhap = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_dangNhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_nguoiDung = new System.Windows.Forms.RadioButton();
            this.rb_admin = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_messenger2 = new System.Windows.Forms.Label();
            this.lbl_messenger1 = new System.Windows.Forms.Label();
            this.lbl_dangKy = new System.Windows.Forms.LinkLabel();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.lbl_quenMatKhau = new System.Windows.Forms.LinkLabel();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.txt_tenDangNhap = new System.Windows.Forms.TextBox();
            this.lbl_matKhau = new System.Windows.Forms.Label();
            this.lbl_tenDangNhap = new System.Windows.Forms.Label();
            this.tlp_dangNhap.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_dangNhap
            // 
            this.tlp_dangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tlp_dangNhap.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlp_dangNhap.ColumnCount = 1;
            this.tlp_dangNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_dangNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_dangNhap.Controls.Add(this.lbl_dangNhap, 0, 0);
            this.tlp_dangNhap.Controls.Add(this.panel1, 0, 1);
            this.tlp_dangNhap.Controls.Add(this.panel2, 0, 2);
            this.tlp_dangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlp_dangNhap.Location = new System.Drawing.Point(13, 12);
            this.tlp_dangNhap.Name = "tlp_dangNhap";
            this.tlp_dangNhap.RowCount = 3;
            this.tlp_dangNhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tlp_dangNhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tlp_dangNhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 336F));
            this.tlp_dangNhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_dangNhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_dangNhap.Size = new System.Drawing.Size(629, 427);
            this.tlp_dangNhap.TabIndex = 0;
            // 
            // lbl_dangNhap
            // 
            this.lbl_dangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_dangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dangNhap.Location = new System.Drawing.Point(5, 2);
            this.lbl_dangNhap.Name = "lbl_dangNhap";
            this.lbl_dangNhap.Size = new System.Drawing.Size(619, 36);
            this.lbl_dangNhap.TabIndex = 0;
            this.lbl_dangNhap.Text = "Đăng nhập";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rb_nguoiDung);
            this.panel1.Controls.Add(this.rb_admin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 40);
            this.panel1.TabIndex = 3;
            // 
            // rb_nguoiDung
            // 
            this.rb_nguoiDung.AutoSize = true;
            this.rb_nguoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_nguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_nguoiDung.Location = new System.Drawing.Point(109, 3);
            this.rb_nguoiDung.Name = "rb_nguoiDung";
            this.rb_nguoiDung.Size = new System.Drawing.Size(133, 29);
            this.rb_nguoiDung.TabIndex = 2;
            this.rb_nguoiDung.TabStop = true;
            this.rb_nguoiDung.Text = "Người dùng";
            this.rb_nguoiDung.UseVisualStyleBackColor = true;
            // 
            // rb_admin
            // 
            this.rb_admin.AutoSize = true;
            this.rb_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_admin.Location = new System.Drawing.Point(1, 3);
            this.rb_admin.Name = "rb_admin";
            this.rb_admin.Size = new System.Drawing.Size(89, 29);
            this.rb_admin.TabIndex = 0;
            this.rb_admin.TabStop = true;
            this.rb_admin.Text = "Admin";
            this.rb_admin.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.lbl_messenger2);
            this.panel2.Controls.Add(this.lbl_messenger1);
            this.panel2.Controls.Add(this.lbl_dangKy);
            this.panel2.Controls.Add(this.btn_dangNhap);
            this.panel2.Controls.Add(this.lbl_quenMatKhau);
            this.panel2.Controls.Add(this.txt_matKhau);
            this.panel2.Controls.Add(this.txt_tenDangNhap);
            this.panel2.Controls.Add(this.lbl_matKhau);
            this.panel2.Controls.Add(this.lbl_tenDangNhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 331);
            this.panel2.TabIndex = 4;
            // 
            // lbl_messenger2
            // 
            this.lbl_messenger2.AutoSize = true;
            this.lbl_messenger2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_messenger2.ForeColor = System.Drawing.Color.Red;
            this.lbl_messenger2.Location = new System.Drawing.Point(225, 157);
            this.lbl_messenger2.Name = "lbl_messenger2";
            this.lbl_messenger2.Size = new System.Drawing.Size(0, 16);
            this.lbl_messenger2.TabIndex = 9;
            // 
            // lbl_messenger1
            // 
            this.lbl_messenger1.AutoSize = true;
            this.lbl_messenger1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_messenger1.Location = new System.Drawing.Point(164, 276);
            this.lbl_messenger1.Name = "lbl_messenger1";
            this.lbl_messenger1.Size = new System.Drawing.Size(181, 25);
            this.lbl_messenger1.TabIndex = 8;
            this.lbl_messenger1.Text = "Chưa có tài khoản?";
            // 
            // lbl_dangKy
            // 
            this.lbl_dangKy.AutoSize = true;
            this.lbl_dangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dangKy.Location = new System.Drawing.Point(351, 276);
            this.lbl_dangKy.Name = "lbl_dangKy";
            this.lbl_dangKy.Size = new System.Drawing.Size(132, 25);
            this.lbl_dangKy.TabIndex = 7;
            this.lbl_dangKy.TabStop = true;
            this.lbl_dangKy.Text = "Đăng ký ngay";
            this.lbl_dangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_dangKy_LinkClicked);
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.btn_dangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangNhap.FlatAppearance.BorderSize = 0;
            this.btn_dangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.Location = new System.Drawing.Point(411, 202);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(149, 49);
            this.btn_dangNhap.TabIndex = 5;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = false;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // lbl_quenMatKhau
            // 
            this.lbl_quenMatKhau.AutoSize = true;
            this.lbl_quenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_quenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quenMatKhau.Location = new System.Drawing.Point(223, 123);
            this.lbl_quenMatKhau.Name = "lbl_quenMatKhau";
            this.lbl_quenMatKhau.Size = new System.Drawing.Size(146, 25);
            this.lbl_quenMatKhau.TabIndex = 4;
            this.lbl_quenMatKhau.TabStop = true;
            this.lbl_quenMatKhau.Text = "Quên mật khẩu";
            this.lbl_quenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_quenMatKhau_LinkClicked);
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matKhau.Location = new System.Drawing.Point(226, 88);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.PasswordChar = '*';
            this.txt_matKhau.Size = new System.Drawing.Size(277, 30);
            this.txt_matKhau.TabIndex = 3;
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenDangNhap.Location = new System.Drawing.Point(226, 50);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(277, 30);
            this.txt_tenDangNhap.TabIndex = 0;
            this.txt_tenDangNhap.TextChanged += new System.EventHandler(this.txt_tenDangNhap_TextChanged);
            // 
            // lbl_matKhau
            // 
            this.lbl_matKhau.AutoSize = true;
            this.lbl_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matKhau.Location = new System.Drawing.Point(97, 88);
            this.lbl_matKhau.Name = "lbl_matKhau";
            this.lbl_matKhau.Size = new System.Drawing.Size(99, 25);
            this.lbl_matKhau.TabIndex = 1;
            this.lbl_matKhau.Text = "Mật khẩu:";
            // 
            // lbl_tenDangNhap
            // 
            this.lbl_tenDangNhap.AutoSize = true;
            this.lbl_tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenDangNhap.Location = new System.Drawing.Point(45, 53);
            this.lbl_tenDangNhap.Name = "lbl_tenDangNhap";
            this.lbl_tenDangNhap.Size = new System.Drawing.Size(151, 25);
            this.lbl_tenDangNhap.TabIndex = 0;
            this.lbl_tenDangNhap.Text = "Tên đăng nhập:";
            // 
            // FDangNhap
            // 
            this.AcceptButton = this.btn_dangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(654, 451);
            this.Controls.Add(this.tlp_dangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FDangNhap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FDangNhap_Load);
            this.tlp_dangNhap.ResumeLayout(false);
            this.tlp_dangNhap.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_dangNhap;
        private System.Windows.Forms.Label lbl_dangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_nguoiDung;
        private System.Windows.Forms.RadioButton rb_admin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.LinkLabel lbl_quenMatKhau;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.TextBox txt_tenDangNhap;
        private System.Windows.Forms.Label lbl_matKhau;
        private System.Windows.Forms.Label lbl_tenDangNhap;
        private System.Windows.Forms.Label lbl_messenger2;
        private System.Windows.Forms.Label lbl_messenger1;
        private System.Windows.Forms.LinkLabel lbl_dangKy;
    }
}


namespace QLGara
{
    partial class FPhieuThuEntity
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_Loc = new System.Windows.Forms.ComboBox();
            this.txt_loc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_loc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoPT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgvPhieuThu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt_LapPhieu = new System.Windows.Forms.DateTimePicker();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.txt_Tien = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.txt_MaPT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_reload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.cb_Loc);
            this.panel3.Controls.Add(this.txt_loc);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btn_loc);
            this.panel3.Location = new System.Drawing.Point(1140, 553);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 169);
            this.panel3.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 76);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(286, 29);
            this.label13.TabIndex = 25;
            this.label13.Text = "Nhập giá trị bạn muốn lọc";
            // 
            // cb_Loc
            // 
            this.cb_Loc.FormattingEnabled = true;
            this.cb_Loc.Items.AddRange(new object[] {
            "Số hợp đồng",
            "Mã khách hàng",
            "Xem toàn bộ phiếu thu"});
            this.cb_Loc.Location = new System.Drawing.Point(346, 17);
            this.cb_Loc.Name = "cb_Loc";
            this.cb_Loc.Size = new System.Drawing.Size(324, 37);
            this.cb_Loc.TabIndex = 24;
            // 
            // txt_loc
            // 
            this.txt_loc.Location = new System.Drawing.Point(346, 80);
            this.txt_loc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_loc.Name = "txt_loc";
            this.txt_loc.Size = new System.Drawing.Size(323, 35);
            this.txt_loc.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(328, 29);
            this.label12.TabIndex = 22;
            this.label12.Text = "Chọn thuộc tính bạn muốn lọc";
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(542, 127);
            this.btn_loc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(128, 36);
            this.btn_loc.TabIndex = 17;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtMaHD);
            this.panel2.Controls.Add(this.btn_tim);
            this.panel2.Controls.Add(this.txtTien);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_tim);
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.txtMaKH);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtDate);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtSoPT);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(1140, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 523);
            this.panel2.TabIndex = 42;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(269, 186);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(392, 35);
            this.txtMaHD.TabIndex = 26;
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tim.Location = new System.Drawing.Point(518, 64);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(143, 36);
            this.btn_tim.TabIndex = 25;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseMnemonic = false;
            this.btn_tim.UseVisualStyleBackColor = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txtTien
            // 
            this.txtTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTien.Location = new System.Drawing.Point(269, 461);
            this.txtTien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(392, 35);
            this.txtTien.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 463);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 29);
            this.label15.TabIndex = 24;
            this.label15.Text = "Số tiền thu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 29);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tìm kiếm mã số phiếu thu";
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(329, 16);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(332, 35);
            this.txt_tim.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(269, 392);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(392, 35);
            this.txtHoTen.TabIndex = 18;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(269, 318);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(392, 35);
            this.txtMaKH.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mã số phiếu thu";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(269, 252);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(392, 35);
            this.txtDate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Mã số hợp đồng";
            // 
            // txtSoPT
            // 
            this.txtSoPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPT.Location = new System.Drawing.Point(269, 122);
            this.txtSoPT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSoPT.Name = "txtSoPT";
            this.txtSoPT.Size = new System.Drawing.Size(392, 35);
            this.txtSoPT.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 257);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày lập phiếu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Họ tên khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 324);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã khách hàng";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(331, 757);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(128, 36);
            this.btn_xoa.TabIndex = 40;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(479, 757);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(128, 36);
            this.btn_huy.TabIndex = 39;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(172, 757);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(128, 36);
            this.btn_sua.TabIndex = 38;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(14, 757);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(128, 36);
            this.btn_them.TabIndex = 37;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgvPhieuThu
            // 
            this.dgvPhieuThu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPhieuThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThu.Location = new System.Drawing.Point(14, 214);
            this.dgvPhieuThu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvPhieuThu.Name = "dgvPhieuThu";
            this.dgvPhieuThu.RowHeadersWidth = 62;
            this.dgvPhieuThu.RowTemplate.Height = 28;
            this.dgvPhieuThu.Size = new System.Drawing.Size(1118, 508);
            this.dgvPhieuThu.TabIndex = 36;
            this.dgvPhieuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuThu_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dt_LapPhieu);
            this.panel1.Controls.Add(this.txt_TenKH);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_MaKH);
            this.panel1.Controls.Add(this.txt_Tien);
            this.panel1.Controls.Add(this.btn_luu);
            this.panel1.Controls.Add(this.txt_MaHD);
            this.panel1.Controls.Add(this.txt_MaPT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_reload);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 179);
            this.panel1.TabIndex = 35;
            // 
            // dt_LapPhieu
            // 
            this.dt_LapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_LapPhieu.Location = new System.Drawing.Point(680, 17);
            this.dt_LapPhieu.Margin = new System.Windows.Forms.Padding(5);
            this.dt_LapPhieu.Name = "dt_LapPhieu";
            this.dt_LapPhieu.Size = new System.Drawing.Size(256, 35);
            this.dt_LapPhieu.TabIndex = 12;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(680, 137);
            this.txt_TenKH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(257, 35);
            this.txt_TenKH.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(445, 134);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 29);
            this.label14.TabIndex = 10;
            this.label14.Text = "Họ tên khách hàng";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(193, 137);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(182, 35);
            this.txt_MaKH.TabIndex = 8;
            // 
            // txt_Tien
            // 
            this.txt_Tien.Location = new System.Drawing.Point(680, 74);
            this.txt_Tien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_Tien.Name = "txt_Tien";
            this.txt_Tien.Size = new System.Drawing.Size(256, 35);
            this.txt_Tien.TabIndex = 7;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(977, 124);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(128, 36);
            this.btn_luu.TabIndex = 5;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(193, 79);
            this.txt_MaHD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(280, 35);
            this.txt_MaHD.TabIndex = 6;
            // 
            // txt_MaPT
            // 
            this.txt_MaPT.Location = new System.Drawing.Point(193, 17);
            this.txt_MaPT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_MaPT.Name = "txt_MaPT";
            this.txt_MaPT.Size = new System.Drawing.Size(280, 35);
            this.txt_MaPT.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã khách hàng";
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(977, 13);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(128, 36);
            this.btn_reload.TabIndex = 2;
            this.btn_reload.Text = "Reload";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiền thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã số hợp đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số phếu thu";
            // 
            // FPhieuThuEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1822, 816);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgvPhieuThu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FPhieuThuEntity";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FPhieuThuEntity_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_LapPhieu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.TextBox txt_Tien;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoPT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_MaPT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgvPhieuThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_Loc;
        private System.Windows.Forms.TextBox txt_loc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_loc;
    }
}
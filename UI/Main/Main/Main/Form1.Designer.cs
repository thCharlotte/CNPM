namespace Main
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            icon_dang_xuat = new PictureBox();
            logo_PM = new PictureBox();
            btn_dang_xuat = new Button();
            btn_sao_luu_phuc_hoi = new Button();
            btn_quan_ly_nhan_vien = new Button();
            btn_quan_ly_phieu_tra_hang = new Button();
            btn_quan_ly_khach_hang = new Button();
            btn_quan_ly_mau_kiem_dinh = new Button();
            btn_quan_ly_hop_dong = new Button();
            btn_trang_chu = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            icon_tim_kiem = new PictureBox();
            textBox = new TextBox();
            ho_va_ten = new Label();
            avatar = new PictureBox();
            panel3 = new Panel();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_dang_xuat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_PM).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon_tim_kiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(197, 219, 204);
            panel1.Controls.Add(icon_dang_xuat);
            panel1.Controls.Add(logo_PM);
            panel1.Controls.Add(btn_dang_xuat);
            panel1.Controls.Add(btn_sao_luu_phuc_hoi);
            panel1.Controls.Add(btn_quan_ly_nhan_vien);
            panel1.Controls.Add(btn_quan_ly_phieu_tra_hang);
            panel1.Controls.Add(btn_quan_ly_khach_hang);
            panel1.Controls.Add(btn_quan_ly_mau_kiem_dinh);
            panel1.Controls.Add(btn_quan_ly_hop_dong);
            panel1.Controls.Add(btn_trang_chu);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 853);
            panel1.TabIndex = 3;
            // 
            // icon_dang_xuat
            // 
            icon_dang_xuat.Image = Properties.Resources.logout;
            icon_dang_xuat.Location = new Point(55, 811);
            icon_dang_xuat.Name = "icon_dang_xuat";
            icon_dang_xuat.Size = new Size(31, 27);
            icon_dang_xuat.SizeMode = PictureBoxSizeMode.Zoom;
            icon_dang_xuat.TabIndex = 9;
            icon_dang_xuat.TabStop = false;
            // 
            // logo_PM
            // 
            logo_PM.Image = Properties.Resources.logo1;
            logo_PM.Location = new Point(4, 3);
            logo_PM.Name = "logo_PM";
            logo_PM.Size = new Size(250, 213);
            logo_PM.SizeMode = PictureBoxSizeMode.Zoom;
            logo_PM.TabIndex = 8;
            logo_PM.TabStop = false;
            logo_PM.Click += pictureBox3_Click;
            // 
            // btn_dang_xuat
            // 
            btn_dang_xuat.BackColor = Color.FromArgb(197, 219, 204);
            btn_dang_xuat.FlatStyle = FlatStyle.Flat;
            btn_dang_xuat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dang_xuat.ForeColor = SystemColors.ActiveCaptionText;
            btn_dang_xuat.Location = new Point(26, 806);
            btn_dang_xuat.Name = "btn_dang_xuat";
            btn_dang_xuat.Size = new Size(209, 47);
            btn_dang_xuat.TabIndex = 6;
            btn_dang_xuat.Text = "Đăng xuất";
            btn_dang_xuat.UseVisualStyleBackColor = false;
            btn_dang_xuat.Click += button8_Click;
            // 
            // btn_sao_luu_phuc_hoi
            // 
            btn_sao_luu_phuc_hoi.BackColor = Color.FromArgb(89, 142, 108);
            btn_sao_luu_phuc_hoi.FlatStyle = FlatStyle.Flat;
            btn_sao_luu_phuc_hoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_sao_luu_phuc_hoi.ForeColor = SystemColors.ButtonHighlight;
            btn_sao_luu_phuc_hoi.Location = new Point(24, 588);
            btn_sao_luu_phuc_hoi.Name = "btn_sao_luu_phuc_hoi";
            btn_sao_luu_phuc_hoi.Size = new Size(209, 47);
            btn_sao_luu_phuc_hoi.TabIndex = 2;
            btn_sao_luu_phuc_hoi.Text = "Sao lưu và phục hồi dữ liệu";
            btn_sao_luu_phuc_hoi.UseVisualStyleBackColor = false;
            // 
            // btn_quan_ly_nhan_vien
            // 
            btn_quan_ly_nhan_vien.BackColor = Color.FromArgb(89, 142, 108);
            btn_quan_ly_nhan_vien.FlatStyle = FlatStyle.Flat;
            btn_quan_ly_nhan_vien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_quan_ly_nhan_vien.ForeColor = SystemColors.ButtonHighlight;
            btn_quan_ly_nhan_vien.Location = new Point(24, 527);
            btn_quan_ly_nhan_vien.Name = "btn_quan_ly_nhan_vien";
            btn_quan_ly_nhan_vien.Size = new Size(209, 47);
            btn_quan_ly_nhan_vien.TabIndex = 5;
            btn_quan_ly_nhan_vien.Text = "Quản lý nhân viên";
            btn_quan_ly_nhan_vien.UseVisualStyleBackColor = false;
            // 
            // btn_quan_ly_phieu_tra_hang
            // 
            btn_quan_ly_phieu_tra_hang.BackColor = Color.FromArgb(89, 142, 108);
            btn_quan_ly_phieu_tra_hang.FlatStyle = FlatStyle.Flat;
            btn_quan_ly_phieu_tra_hang.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_quan_ly_phieu_tra_hang.ForeColor = SystemColors.ButtonHighlight;
            btn_quan_ly_phieu_tra_hang.Location = new Point(24, 466);
            btn_quan_ly_phieu_tra_hang.Name = "btn_quan_ly_phieu_tra_hang";
            btn_quan_ly_phieu_tra_hang.Size = new Size(209, 47);
            btn_quan_ly_phieu_tra_hang.TabIndex = 4;
            btn_quan_ly_phieu_tra_hang.Text = "Quản lý phiếu trả hàng";
            btn_quan_ly_phieu_tra_hang.UseVisualStyleBackColor = false;
            // 
            // btn_quan_ly_khach_hang
            // 
            btn_quan_ly_khach_hang.BackColor = Color.FromArgb(89, 142, 108);
            btn_quan_ly_khach_hang.FlatStyle = FlatStyle.Flat;
            btn_quan_ly_khach_hang.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_quan_ly_khach_hang.ForeColor = SystemColors.ButtonHighlight;
            btn_quan_ly_khach_hang.Location = new Point(24, 405);
            btn_quan_ly_khach_hang.Name = "btn_quan_ly_khach_hang";
            btn_quan_ly_khach_hang.Size = new Size(209, 47);
            btn_quan_ly_khach_hang.TabIndex = 3;
            btn_quan_ly_khach_hang.Text = "Quản lý khách hàng";
            btn_quan_ly_khach_hang.UseVisualStyleBackColor = false;
            // 
            // btn_quan_ly_mau_kiem_dinh
            // 
            btn_quan_ly_mau_kiem_dinh.BackColor = Color.FromArgb(89, 142, 108);
            btn_quan_ly_mau_kiem_dinh.FlatStyle = FlatStyle.Flat;
            btn_quan_ly_mau_kiem_dinh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_quan_ly_mau_kiem_dinh.ForeColor = SystemColors.ButtonHighlight;
            btn_quan_ly_mau_kiem_dinh.Location = new Point(24, 344);
            btn_quan_ly_mau_kiem_dinh.Name = "btn_quan_ly_mau_kiem_dinh";
            btn_quan_ly_mau_kiem_dinh.Size = new Size(209, 47);
            btn_quan_ly_mau_kiem_dinh.TabIndex = 2;
            btn_quan_ly_mau_kiem_dinh.Text = "Quản lý mẫu kiểm định";
            btn_quan_ly_mau_kiem_dinh.UseVisualStyleBackColor = false;
            btn_quan_ly_mau_kiem_dinh.Click += button3_Click;
            // 
            // btn_quan_ly_hop_dong
            // 
            btn_quan_ly_hop_dong.BackColor = Color.FromArgb(89, 142, 108);
            btn_quan_ly_hop_dong.FlatStyle = FlatStyle.Flat;
            btn_quan_ly_hop_dong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_quan_ly_hop_dong.ForeColor = SystemColors.ButtonHighlight;
            btn_quan_ly_hop_dong.Location = new Point(24, 283);
            btn_quan_ly_hop_dong.Name = "btn_quan_ly_hop_dong";
            btn_quan_ly_hop_dong.Size = new Size(209, 47);
            btn_quan_ly_hop_dong.TabIndex = 1;
            btn_quan_ly_hop_dong.Text = "Quản lý hợp đồng";
            btn_quan_ly_hop_dong.UseVisualStyleBackColor = false;
            // 
            // btn_trang_chu
            // 
            btn_trang_chu.BackColor = Color.FromArgb(89, 142, 108);
            btn_trang_chu.FlatStyle = FlatStyle.Flat;
            btn_trang_chu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_trang_chu.ForeColor = SystemColors.ButtonHighlight;
            btn_trang_chu.Location = new Point(24, 222);
            btn_trang_chu.Name = "btn_trang_chu";
            btn_trang_chu.Size = new Size(209, 47);
            btn_trang_chu.TabIndex = 0;
            btn_trang_chu.Text = "Trang chủ";
            btn_trang_chu.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(icon_tim_kiem);
            panel2.Controls.Add(textBox);
            panel2.Controls.Add(ho_va_ten);
            panel2.Controls.Add(avatar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(257, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1325, 63);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.notification;
            pictureBox1.Location = new Point(1048, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // icon_tim_kiem
            // 
            icon_tim_kiem.BackColor = Color.White;
            icon_tim_kiem.Image = Properties.Resources.search_interface_symbol;
            icon_tim_kiem.Location = new Point(982, 21);
            icon_tim_kiem.Name = "icon_tim_kiem";
            icon_tim_kiem.Size = new Size(24, 23);
            icon_tim_kiem.SizeMode = PictureBoxSizeMode.Zoom;
            icon_tim_kiem.TabIndex = 1;
            icon_tim_kiem.TabStop = false;
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox.ForeColor = Color.FromArgb(89, 142, 108);
            textBox.Location = new Point(705, 18);
            textBox.Name = "textBox";
            textBox.Size = new Size(301, 30);
            textBox.TabIndex = 3;
            // 
            // ho_va_ten
            // 
            ho_va_ten.AutoSize = true;
            ho_va_ten.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ho_va_ten.ForeColor = Color.FromArgb(89, 142, 108);
            ho_va_ten.Location = new Point(1091, 21);
            ho_va_ten.Name = "ho_va_ten";
            ho_va_ten.Size = new Size(131, 25);
            ho_va_ten.TabIndex = 2;
            ho_va_ten.Text = "Nguyễn Văn A";
            // 
            // avatar
            // 
            avatar.Image = Properties.Resources._3;
            avatar.Location = new Point(1243, 3);
            avatar.Name = "avatar";
            avatar.Size = new Size(82, 50);
            avatar.SizeMode = PictureBoxSizeMode.Zoom;
            avatar.TabIndex = 0;
            avatar.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(257, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(1361, 794);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(6, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(1203, 772);
            panel5.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.weather;
            pictureBox4.Location = new Point(784, 569);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(366, 165);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(663, 549);
            label5.Name = "label5";
            label5.Size = new Size(99, 31);
            label5.TabIndex = 13;
            label5.Text = "Thời tiết";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.chart_example2;
            pictureBox3.Location = new Point(177, 549);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(290, 185);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(45, 549);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 11;
            label4.Text = "Doanh số";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(45, 92);
            label3.Name = "label3";
            label3.Size = new Size(179, 31);
            label3.TabIndex = 10;
            label3.Text = "Chất lượng mẫu";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.chart_example;
            pictureBox2.Location = new Point(45, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1105, 357);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(89, 142, 108);
            label2.Location = new Point(177, 16);
            label2.Name = "label2";
            label2.Size = new Size(213, 41);
            label2.TabIndex = 8;
            label2.Text = "Nguyễn Văn A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(45, 16);
            label1.Name = "label1";
            label1.Size = new Size(150, 41);
            label1.TabIndex = 7;
            label1.Text = "Xin chào, ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon_dang_xuat).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_PM).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon_tim_kiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btn_quan_ly_hop_dong;
        private Button btn_trang_chu;
        private Button btn_quan_ly_khach_hang;
        private Button btn_quan_ly_mau_kiem_dinh;
        private Button btn_sao_luu_phuc_hoi;
        private Button btn_quan_ly_nhan_vien;
        private Button btn_quan_ly_phieu_tra_hang;
        private Button btn_dang_xuat;
        private PictureBox avatar;
        private PictureBox logo_PM;
        private PictureBox icon_dang_xuat;
        private Label ho_va_ten;
        private TextBox textBox;
        private PictureBox icon_tim_kiem;
        private PictureBox pictureBox1;
        private Panel panel5;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox4;
    }
}

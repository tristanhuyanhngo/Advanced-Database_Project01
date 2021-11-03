
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button_ThemMoiHoaDon = new System.Windows.Forms.Button();
            this.Box_DanhSachHoaDon = new System.Windows.Forms.GroupBox();
            this.DGV_DanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.ThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.Input_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.Input_TongTien = new System.Windows.Forms.TextBox();
            this.Input_MaKhachHang = new System.Windows.Forms.TextBox();
            this.Input_MaHoaDon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Box_DoanhThuTheoThang = new System.Windows.Forms.GroupBox();
            this.DGV_DoanhThuTheoThang = new System.Windows.Forms.DataGridView();
            this.Box_DanhSachHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DanhSachHoaDon)).BeginInit();
            this.ThongTinHoaDon.SuspendLayout();
            this.Box_DoanhThuTheoThang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DoanhThuTheoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ThemMoiHoaDon
            // 
            this.button_ThemMoiHoaDon.Location = new System.Drawing.Point(332, 71);
            this.button_ThemMoiHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.button_ThemMoiHoaDon.Name = "button_ThemMoiHoaDon";
            this.button_ThemMoiHoaDon.Size = new System.Drawing.Size(122, 37);
            this.button_ThemMoiHoaDon.TabIndex = 0;
            this.button_ThemMoiHoaDon.Text = "Thêm mới hóa đơn";
            this.button_ThemMoiHoaDon.UseVisualStyleBackColor = true;
            this.button_ThemMoiHoaDon.Click += new System.EventHandler(this.button1_Click);
            this.button_ThemMoiHoaDon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_ThemMoiHoaDon_MouseClick);
            // 
            // Box_DanhSachHoaDon
            // 
            this.Box_DanhSachHoaDon.Controls.Add(this.DGV_DanhSachHoaDon);
            this.Box_DanhSachHoaDon.Location = new System.Drawing.Point(191, 10);
            this.Box_DanhSachHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.Box_DanhSachHoaDon.Name = "Box_DanhSachHoaDon";
            this.Box_DanhSachHoaDon.Padding = new System.Windows.Forms.Padding(2);
            this.Box_DanhSachHoaDon.Size = new System.Drawing.Size(520, 236);
            this.Box_DanhSachHoaDon.TabIndex = 1;
            this.Box_DanhSachHoaDon.TabStop = false;
            this.Box_DanhSachHoaDon.Text = "Danh sách hóa đơn";
            // 
            // DGV_DanhSachHoaDon
            // 
            this.DGV_DanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DanhSachHoaDon.Location = new System.Drawing.Point(11, 24);
            this.DGV_DanhSachHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_DanhSachHoaDon.Name = "DGV_DanhSachHoaDon";
            this.DGV_DanhSachHoaDon.RowHeadersWidth = 51;
            this.DGV_DanhSachHoaDon.RowTemplate.Height = 24;
            this.DGV_DanhSachHoaDon.Size = new System.Drawing.Size(501, 207);
            this.DGV_DanhSachHoaDon.TabIndex = 0;
            this.DGV_DanhSachHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DanhSachHoaDon_CellContentClick);
            // 
            // ThongTinHoaDon
            // 
            this.ThongTinHoaDon.Controls.Add(this.Input_NgayLap);
            this.ThongTinHoaDon.Controls.Add(this.Input_TongTien);
            this.ThongTinHoaDon.Controls.Add(this.Input_MaKhachHang);
            this.ThongTinHoaDon.Controls.Add(this.Input_MaHoaDon);
            this.ThongTinHoaDon.Controls.Add(this.label4);
            this.ThongTinHoaDon.Controls.Add(this.label3);
            this.ThongTinHoaDon.Controls.Add(this.button_ThemMoiHoaDon);
            this.ThongTinHoaDon.Controls.Add(this.label2);
            this.ThongTinHoaDon.Controls.Add(this.label1);
            this.ThongTinHoaDon.Location = new System.Drawing.Point(191, 266);
            this.ThongTinHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.ThongTinHoaDon.Name = "ThongTinHoaDon";
            this.ThongTinHoaDon.Padding = new System.Windows.Forms.Padding(2);
            this.ThongTinHoaDon.Size = new System.Drawing.Size(520, 166);
            this.ThongTinHoaDon.TabIndex = 2;
            this.ThongTinHoaDon.TabStop = false;
            this.ThongTinHoaDon.Text = "Thông tin hóa đơn";
            // 
            // Input_NgayLap
            // 
            this.Input_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Input_NgayLap.Location = new System.Drawing.Point(124, 102);
            this.Input_NgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.Input_NgayLap.Name = "Input_NgayLap";
            this.Input_NgayLap.Size = new System.Drawing.Size(97, 20);
            this.Input_NgayLap.TabIndex = 8;
            // 
            // Input_TongTien
            // 
            this.Input_TongTien.Location = new System.Drawing.Point(124, 129);
            this.Input_TongTien.Margin = new System.Windows.Forms.Padding(2);
            this.Input_TongTien.Name = "Input_TongTien";
            this.Input_TongTien.Size = new System.Drawing.Size(97, 20);
            this.Input_TongTien.TabIndex = 7;
            // 
            // Input_MaKhachHang
            // 
            this.Input_MaKhachHang.Location = new System.Drawing.Point(124, 71);
            this.Input_MaKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.Input_MaKhachHang.Name = "Input_MaKhachHang";
            this.Input_MaKhachHang.Size = new System.Drawing.Size(97, 20);
            this.Input_MaKhachHang.TabIndex = 5;
            // 
            // Input_MaHoaDon
            // 
            this.Input_MaHoaDon.Location = new System.Drawing.Point(124, 39);
            this.Input_MaHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.Input_MaHoaDon.Name = "Input_MaHoaDon";
            this.Input_MaHoaDon.Size = new System.Drawing.Size(97, 20);
            this.Input_MaHoaDon.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày lập";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Box_DoanhThuTheoThang
            // 
            this.Box_DoanhThuTheoThang.Controls.Add(this.DGV_DoanhThuTheoThang);
            this.Box_DoanhThuTheoThang.Location = new System.Drawing.Point(191, 459);
            this.Box_DoanhThuTheoThang.Margin = new System.Windows.Forms.Padding(2);
            this.Box_DoanhThuTheoThang.Name = "Box_DoanhThuTheoThang";
            this.Box_DoanhThuTheoThang.Padding = new System.Windows.Forms.Padding(2);
            this.Box_DoanhThuTheoThang.Size = new System.Drawing.Size(520, 181);
            this.Box_DoanhThuTheoThang.TabIndex = 3;
            this.Box_DoanhThuTheoThang.TabStop = false;
            this.Box_DoanhThuTheoThang.Text = "Doanh thu theo tháng";
            // 
            // DGV_DoanhThuTheoThang
            // 
            this.DGV_DoanhThuTheoThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DoanhThuTheoThang.Location = new System.Drawing.Point(14, 23);
            this.DGV_DoanhThuTheoThang.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_DoanhThuTheoThang.Name = "DGV_DoanhThuTheoThang";
            this.DGV_DoanhThuTheoThang.RowHeadersWidth = 51;
            this.DGV_DoanhThuTheoThang.RowTemplate.Height = 24;
            this.DGV_DoanhThuTheoThang.Size = new System.Drawing.Size(498, 158);
            this.DGV_DoanhThuTheoThang.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 680);
            this.Controls.Add(this.Box_DoanhThuTheoThang);
            this.Controls.Add(this.ThongTinHoaDon);
            this.Controls.Add(this.Box_DanhSachHoaDon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ADB1_6 Project 01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Box_DanhSachHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DanhSachHoaDon)).EndInit();
            this.ThongTinHoaDon.ResumeLayout(false);
            this.ThongTinHoaDon.PerformLayout();
            this.Box_DoanhThuTheoThang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DoanhThuTheoThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ThemMoiHoaDon;
        private System.Windows.Forms.GroupBox Box_DanhSachHoaDon;
        private System.Windows.Forms.DataGridView DGV_DanhSachHoaDon;
        private System.Windows.Forms.GroupBox ThongTinHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Input_TongTien;
        private System.Windows.Forms.TextBox Input_MaKhachHang;
        private System.Windows.Forms.TextBox Input_MaHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Box_DoanhThuTheoThang;
        private System.Windows.Forms.DataGridView DGV_DoanhThuTheoThang;
        private System.Windows.Forms.DateTimePicker Input_NgayLap;
    }
}


﻿namespace Dang_Don_Len_GHTK
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRun = new System.Windows.Forms.Button();
            this.txbMaDonInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxTenKhachHang = new System.Windows.Forms.TextBox();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.tbxKhoiLuong = new System.Windows.Forms.TextBox();
            this.tbxGiaTien = new System.Windows.Forms.TextBox();
            this.tbxPhiVanChuyen = new System.Windows.Forms.TextBox();
            this.tbxTongTien = new System.Windows.Forms.TextBox();
            this.lbDonViVanChuyen = new System.Windows.Forms.Label();
            this.dataGridViewTatCa = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxSDTInput = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbxSoTien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewKetQua = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSuaSanPham = new System.Windows.Forms.Button();
            this.MaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonHangKQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTKQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachhangKQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiKQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanPhamKQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoiLuongThucTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienKQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxKhoiLuongThucTe = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTatCa)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKetQua)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(565, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(111, 37);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Nút Thần Thánh";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txbMaDonInput
            // 
            this.txbMaDonInput.Location = new System.Drawing.Point(76, 12);
            this.txbMaDonInput.Name = "txbMaDonInput";
            this.txbMaDonInput.Size = new System.Drawing.Size(132, 20);
            this.txbMaDonInput.TabIndex = 1;
            this.txbMaDonInput.TextChanged += new System.EventHandler(this.txbMaDonInput_TextChanged);
            this.txbMaDonInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaDonInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đơn Vị Vận Chuyển:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cân Nặng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tiền Hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Phí Vận Chuyển:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(513, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tổng Tiền:";
            // 
            // tbxTenKhachHang
            // 
            this.tbxTenKhachHang.Location = new System.Drawing.Point(76, 86);
            this.tbxTenKhachHang.Name = "tbxTenKhachHang";
            this.tbxTenKhachHang.Size = new System.Drawing.Size(317, 20);
            this.tbxTenKhachHang.TabIndex = 12;
            // 
            // tbxSDT
            // 
            this.tbxSDT.Location = new System.Drawing.Point(76, 119);
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(317, 20);
            this.tbxSDT.TabIndex = 13;
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Location = new System.Drawing.Point(76, 158);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(317, 20);
            this.tbxDiaChi.TabIndex = 14;
            // 
            // tbxKhoiLuong
            // 
            this.tbxKhoiLuong.Location = new System.Drawing.Point(76, 193);
            this.tbxKhoiLuong.Name = "tbxKhoiLuong";
            this.tbxKhoiLuong.Size = new System.Drawing.Size(317, 20);
            this.tbxKhoiLuong.TabIndex = 15;
            // 
            // tbxGiaTien
            // 
            this.tbxGiaTien.Location = new System.Drawing.Point(578, 115);
            this.tbxGiaTien.Name = "tbxGiaTien";
            this.tbxGiaTien.Size = new System.Drawing.Size(228, 20);
            this.tbxGiaTien.TabIndex = 16;
            // 
            // tbxPhiVanChuyen
            // 
            this.tbxPhiVanChuyen.Location = new System.Drawing.Point(578, 158);
            this.tbxPhiVanChuyen.Name = "tbxPhiVanChuyen";
            this.tbxPhiVanChuyen.Size = new System.Drawing.Size(228, 20);
            this.tbxPhiVanChuyen.TabIndex = 17;
            // 
            // tbxTongTien
            // 
            this.tbxTongTien.Location = new System.Drawing.Point(578, 193);
            this.tbxTongTien.Name = "tbxTongTien";
            this.tbxTongTien.Size = new System.Drawing.Size(228, 20);
            this.tbxTongTien.TabIndex = 18;
            // 
            // lbDonViVanChuyen
            // 
            this.lbDonViVanChuyen.AutoSize = true;
            this.lbDonViVanChuyen.Location = new System.Drawing.Point(578, 85);
            this.lbDonViVanChuyen.Name = "lbDonViVanChuyen";
            this.lbDonViVanChuyen.Size = new System.Drawing.Size(10, 13);
            this.lbDonViVanChuyen.TabIndex = 19;
            this.lbDonViVanChuyen.Text = ".";
            // 
            // dataGridViewTatCa
            // 
            this.dataGridViewTatCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTatCa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonHang,
            this.SDT,
            this.TenKhachHang,
            this.DiaChi,
            this.SanPham,
            this.TongTien});
            this.dataGridViewTatCa.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridViewTatCa.Location = new System.Drawing.Point(824, 12);
            this.dataGridViewTatCa.Name = "dataGridViewTatCa";
            this.dataGridViewTatCa.Size = new System.Drawing.Size(589, 511);
            this.dataGridViewTatCa.TabIndex = 20;
            this.dataGridViewTatCa.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTatCa_CellMouseUp);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmĐơnHàngToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(159, 26);
            // 
            // thêmĐơnHàngToolStripMenuItem
            // 
            this.thêmĐơnHàngToolStripMenuItem.Name = "thêmĐơnHàngToolStripMenuItem";
            this.thêmĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.thêmĐơnHàngToolStripMenuItem.Text = "Thêm đơn hàng";
            this.thêmĐơnHàngToolStripMenuItem.Click += new System.EventHandler(this.thêmĐơnHàngToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "SĐT:";
            // 
            // tbxSDTInput
            // 
            this.tbxSDTInput.Location = new System.Drawing.Point(296, 12);
            this.tbxSDTInput.Name = "tbxSDTInput";
            this.tbxSDTInput.Size = new System.Drawing.Size(230, 20);
            this.tbxSDTInput.TabIndex = 22;
            this.tbxSDTInput.TextChanged += new System.EventHandler(this.tbxSDTInput_TextChanged);
            this.tbxSDTInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSDTInput_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(508, 237);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(213, 23);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm Đơn Hàng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbxSoTien
            // 
            this.tbxSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSoTien.Location = new System.Drawing.Point(370, 235);
            this.tbxSoTien.Name = "tbxSoTien";
            this.tbxSoTien.Size = new System.Drawing.Size(117, 29);
            this.tbxSoTien.TabIndex = 24;
            this.tbxSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSoTien_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tổng thu cuối cùng:";
            // 
            // dataGridViewKetQua
            // 
            this.dataGridViewKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonHangKQ,
            this.SDTKQ,
            this.TenKhachhangKQ,
            this.DiaChiKQ,
            this.SanPhamKQ,
            this.SoLuong,
            this.KhoiLuongThucTe,
            this.SoTienKQ});
            this.dataGridViewKetQua.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewKetQua.Location = new System.Drawing.Point(12, 272);
            this.dataGridViewKetQua.Name = "dataGridViewKetQua";
            this.dataGridViewKetQua.Size = new System.Drawing.Size(806, 251);
            this.dataGridViewKetQua.TabIndex = 26;
            this.dataGridViewKetQua.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewKetQua_CellMouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(667, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // btnSuaSanPham
            // 
            this.btnSuaSanPham.Location = new System.Drawing.Point(508, 237);
            this.btnSuaSanPham.Name = "btnSuaSanPham";
            this.btnSuaSanPham.Size = new System.Drawing.Size(213, 23);
            this.btnSuaSanPham.TabIndex = 30;
            this.btnSuaSanPham.Text = "Lưu Thay Đổi";
            this.btnSuaSanPham.UseVisualStyleBackColor = true;
            this.btnSuaSanPham.Click += new System.EventHandler(this.btnSuaSanPham_Click);
            // 
            // MaDonHang
            // 
            this.MaDonHang.HeaderText = "Mã Đơn Hàng";
            this.MaDonHang.Name = "MaDonHang";
            this.MaDonHang.Width = 50;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SanPham
            // 
            this.SanPham.HeaderText = "Tên Sản Phẩm";
            this.SanPham.Name = "SanPham";
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tiền Thu Hộ";
            this.TongTien.Name = "TongTien";
            // 
            // MaDonHangKQ
            // 
            this.MaDonHangKQ.HeaderText = "Mã Đơn Hàng";
            this.MaDonHangKQ.Name = "MaDonHangKQ";
            this.MaDonHangKQ.Width = 50;
            // 
            // SDTKQ
            // 
            this.SDTKQ.HeaderText = "Số Điện Thoại";
            this.SDTKQ.Name = "SDTKQ";
            // 
            // TenKhachhangKQ
            // 
            this.TenKhachhangKQ.HeaderText = "Tên Khách Hàng";
            this.TenKhachhangKQ.Name = "TenKhachhangKQ";
            // 
            // DiaChiKQ
            // 
            this.DiaChiKQ.HeaderText = "Địa Chỉ";
            this.DiaChiKQ.Name = "DiaChiKQ";
            this.DiaChiKQ.Width = 200;
            // 
            // SanPhamKQ
            // 
            this.SanPhamKQ.HeaderText = "Tên Sản Phẩm";
            this.SanPhamKQ.Name = "SanPhamKQ";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 30;
            // 
            // KhoiLuongThucTe
            // 
            this.KhoiLuongThucTe.HeaderText = "Khối Lượng(kg)";
            this.KhoiLuongThucTe.Name = "KhoiLuongThucTe";
            // 
            // SoTienKQ
            // 
            this.SoTienKQ.HeaderText = "Tiền Thu Hộ";
            this.SoTienKQ.Name = "SoTienKQ";
            this.SoTienKQ.Width = 80;
            // 
            // tbxKhoiLuongThucTe
            // 
            this.tbxKhoiLuongThucTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKhoiLuongThucTe.Location = new System.Drawing.Point(120, 235);
            this.tbxKhoiLuongThucTe.Name = "tbxKhoiLuongThucTe";
            this.tbxKhoiLuongThucTe.Size = new System.Drawing.Size(117, 29);
            this.tbxKhoiLuongThucTe.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Khối Lượng(kg):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 535);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxKhoiLuongThucTe);
            this.Controls.Add(this.btnSuaSanPham);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridViewKetQua);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxSoTien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbxSDTInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewTatCa);
            this.Controls.Add(this.lbDonViVanChuyen);
            this.Controls.Add(this.tbxTongTien);
            this.Controls.Add(this.tbxPhiVanChuyen);
            this.Controls.Add(this.tbxGiaTien);
            this.Controls.Add(this.tbxKhoiLuong);
            this.Controls.Add(this.tbxDiaChi);
            this.Controls.Add(this.tbxSDT);
            this.Controls.Add(this.tbxTenKhachHang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMaDonInput);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Uyên Đẹp Zai";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTatCa)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKetQua)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txbMaDonInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxTenKhachHang;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.TextBox tbxKhoiLuong;
        private System.Windows.Forms.TextBox tbxGiaTien;
        private System.Windows.Forms.TextBox tbxPhiVanChuyen;
        private System.Windows.Forms.TextBox tbxTongTien;
        private System.Windows.Forms.Label lbDonViVanChuyen;
        private System.Windows.Forms.DataGridView dataGridViewTatCa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxSDTInput;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbxSoTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewKetQua;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thêmĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSuaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonHangKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachhangKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanPhamKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoiLuongThucTe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienKQ;
        private System.Windows.Forms.TextBox tbxKhoiLuongThucTe;
        private System.Windows.Forms.Label label13;
    }
}


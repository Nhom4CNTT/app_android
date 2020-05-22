namespace BAOCAOTN
{
    partial class frm_trakhach
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbnvdn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_nv = new System.Windows.Forms.ComboBox();
            this.txt_map = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kh = new System.Windows.Forms.TextBox();
            this.txtTongTienHang = new System.Windows.Forms.TextBox();
            this.cbbThanhToan = new System.Windows.Forms.Button();
            this.txtNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.ColTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.bttThemSP = new System.Windows.Forms.Button();
            this.cbbThemSP = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_khsst = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltra = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khsst)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbnvdn);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1505, 493);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tạo hóa đơn";
            // 
            // lbnvdn
            // 
            this.lbnvdn.AutoSize = true;
            this.lbnvdn.Location = new System.Drawing.Point(11, 374);
            this.lbnvdn.Name = "lbnvdn";
            this.lbnvdn.Size = new System.Drawing.Size(68, 23);
            this.lbnvdn.TabIndex = 2;
            this.lbnvdn.Text = "NV002";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_nv);
            this.groupBox1.Controls.Add(this.txt_map);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_kh);
            this.groupBox1.Controls.Add(this.txtTongTienHang);
            this.groupBox1.Controls.Add(this.cbbThanhToan);
            this.groupBox1.Controls.Add(this.txtNgayLapHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(941, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(482, 329);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn bán hàng";
            // 
            // cbb_nv
            // 
            this.cbb_nv.Enabled = false;
            this.cbb_nv.Location = new System.Drawing.Point(199, 34);
            this.cbb_nv.Name = "cbb_nv";
            this.cbb_nv.Size = new System.Drawing.Size(248, 31);
            this.cbb_nv.TabIndex = 13;
            // 
            // txt_map
            // 
            this.txt_map.Enabled = false;
            this.txt_map.Location = new System.Drawing.Point(199, 172);
            this.txt_map.Name = "txt_map";
            this.txt_map.Size = new System.Drawing.Size(248, 30);
            this.txt_map.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã phiếu nhận:";
            // 
            // txt_kh
            // 
            this.txt_kh.Enabled = false;
            this.txt_kh.Location = new System.Drawing.Point(199, 131);
            this.txt_kh.Name = "txt_kh";
            this.txt_kh.Size = new System.Drawing.Size(248, 30);
            this.txt_kh.TabIndex = 10;
            // 
            // txtTongTienHang
            // 
            this.txtTongTienHang.ForeColor = System.Drawing.Color.Red;
            this.txtTongTienHang.Location = new System.Drawing.Point(199, 213);
            this.txtTongTienHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTienHang.Name = "txtTongTienHang";
            this.txtTongTienHang.ReadOnly = true;
            this.txtTongTienHang.Size = new System.Drawing.Size(247, 30);
            this.txtTongTienHang.TabIndex = 8;
            this.txtTongTienHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbThanhToan
            // 
            this.cbbThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbbThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThanhToan.Location = new System.Drawing.Point(199, 260);
            this.cbbThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.cbbThanhToan.Name = "cbbThanhToan";
            this.cbbThanhToan.Size = new System.Drawing.Size(167, 49);
            this.cbbThanhToan.TabIndex = 3;
            this.cbbThanhToan.Text = "Thanh toán";
            this.cbbThanhToan.UseVisualStyleBackColor = false;
            this.cbbThanhToan.Click += new System.EventHandler(this.cbbThanhToan_Click);
            // 
            // txtNgayLapHD
            // 
            this.txtNgayLapHD.Enabled = false;
            this.txtNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayLapHD.Location = new System.Drawing.Point(199, 85);
            this.txtNgayLapHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayLapHD.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.txtNgayLapHD.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.txtNgayLapHD.Name = "txtNgayLapHD";
            this.txtNgayLapHD.Size = new System.Drawing.Size(248, 30);
            this.txtNgayLapHD.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập HĐ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người lập HĐ:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSanPham);
            this.groupBox4.Controls.Add(this.bttThemSP);
            this.groupBox4.Controls.Add(this.cbbThemSP);
            this.groupBox4.Location = new System.Drawing.Point(7, 30);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(862, 329);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết hóa đơn";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTenSP,
            this.colma,
            this.ColSoLuong,
            this.ColDonGia,
            this.ColThanhTien,
            this.ColXoa});
            this.dgvSanPham.Location = new System.Drawing.Point(8, 62);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSanPham.Size = new System.Drawing.Size(826, 247);
            this.dgvSanPham.TabIndex = 2;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellEndEdit);
            // 
            // ColTenSP
            // 
            this.ColTenSP.HeaderText = "Mã SPDV";
            this.ColTenSP.Name = "ColTenSP";
            this.ColTenSP.Width = 180;
            // 
            // colma
            // 
            this.colma.HeaderText = "Tên SPDV";
            this.colma.Name = "colma";
            this.colma.Width = 180;
            // 
            // ColSoLuong
            // 
            this.ColSoLuong.HeaderText = "SL";
            this.ColSoLuong.Name = "ColSoLuong";
            this.ColSoLuong.Width = 60;
            // 
            // ColDonGia
            // 
            this.ColDonGia.HeaderText = "Đơn giá";
            this.ColDonGia.Name = "ColDonGia";
            this.ColDonGia.Width = 150;
            // 
            // ColThanhTien
            // 
            this.ColThanhTien.HeaderText = "Thành tiền";
            this.ColThanhTien.Name = "ColThanhTien";
            this.ColThanhTien.Width = 150;
            // 
            // ColXoa
            // 
            this.ColXoa.HeaderText = "Xóa";
            this.ColXoa.Image = global::BAOCAOTN.Properties.Resources.t_rac;
            this.ColXoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColXoa.Name = "ColXoa";
            this.ColXoa.Width = 60;
            // 
            // bttThemSP
            // 
            this.bttThemSP.Location = new System.Drawing.Point(655, 22);
            this.bttThemSP.Margin = new System.Windows.Forms.Padding(4);
            this.bttThemSP.Name = "bttThemSP";
            this.bttThemSP.Size = new System.Drawing.Size(100, 28);
            this.bttThemSP.TabIndex = 1;
            this.bttThemSP.Text = "Thêm";
            this.bttThemSP.UseVisualStyleBackColor = true;
            this.bttThemSP.Click += new System.EventHandler(this.bttThemSP_Click);
            // 
            // cbbThemSP
            // 
            this.cbbThemSP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbThemSP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbThemSP.FormattingEnabled = true;
            this.cbbThemSP.Location = new System.Drawing.Point(8, 23);
            this.cbbThemSP.Margin = new System.Windows.Forms.Padding(4);
            this.cbbThemSP.Name = "cbbThemSP";
            this.cbbThemSP.Size = new System.Drawing.Size(648, 31);
            this.cbbThemSP.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_khsst);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1505, 234);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hồ sơ sẵn sàng trả khách";
            // 
            // dgv_khsst
            // 
            this.dgv_khsst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khsst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.coltra});
            this.dgv_khsst.Location = new System.Drawing.Point(6, 29);
            this.dgv_khsst.Name = "dgv_khsst";
            this.dgv_khsst.RowHeadersVisible = false;
            this.dgv_khsst.RowTemplate.Height = 24;
            this.dgv_khsst.Size = new System.Drawing.Size(1489, 188);
            this.dgv_khsst.TabIndex = 1;
            this.dgv_khsst.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khsst_CellClick);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "tenkh";
            this.dataGridViewTextBoxColumn11.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 200;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "maphieu";
            this.dataGridViewTextBoxColumn12.HeaderText = "Mã phiếu";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "serisp";
            this.dataGridViewTextBoxColumn13.HeaderText = "Seri SP";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 120;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "tensp";
            this.dataGridViewTextBoxColumn14.HeaderText = "Tên SP";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 120;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "tennv";
            this.dataGridViewTextBoxColumn15.HeaderText = "Tên NV TN";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 200;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "yeucauKH";
            this.dataGridViewTextBoxColumn16.HeaderText = "Yêu cầu KH";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 160;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ngaynhanhs";
            this.dataGridViewTextBoxColumn17.HeaderText = "Ngày NHS";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 140;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ngayhentra";
            this.dataGridViewTextBoxColumn18.HeaderText = "Ngày HT";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 140;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ghichu";
            this.dataGridViewTextBoxColumn19.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 160;
            // 
            // coltra
            // 
            this.coltra.HeaderText = "Trả khách";
            this.coltra.Image = global::BAOCAOTN.Properties.Resources.t_rac;
            this.coltra.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.coltra.Name = "coltra";
            this.coltra.Width = 120;
            // 
            // frm_trakhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1519, 776);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_trakhach";
            this.Text = "Trả khách";
            this.Load += new System.EventHandler(this.frm_trakhach_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khsst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_map;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kh;
        private System.Windows.Forms.TextBox txtTongTienHang;
        private System.Windows.Forms.Button cbbThanhToan;
        private System.Windows.Forms.DateTimePicker txtNgayLapHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button bttThemSP;
        private System.Windows.Forms.ComboBox cbbThemSP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_khsst;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewImageColumn coltra;
        private System.Windows.Forms.Label lbnvdn;
        private System.Windows.Forms.ComboBox cbb_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThanhTien;
        private System.Windows.Forms.DataGridViewImageColumn ColXoa;
    }
}
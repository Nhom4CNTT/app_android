namespace BAOCAOTN
{
    partial class frm_phieunhan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btt_refresh = new System.Windows.Forms.Button();
            this.btt_themkh = new System.Windows.Forms.Button();
            this.btt_thoat = new System.Windows.Forms.Button();
            this.btt_luu = new System.Windows.Forms.Button();
            this.dtp_hentra = new System.Windows.Forms.DateTimePicker();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_yeucau = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_seri = new System.Windows.Forms.TextBox();
            this.txt_maphieu = new System.Windows.Forms.TextBox();
            this.cbb_makh = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_manv = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_phieunhan = new System.Windows.Forms.DataGridView();
            this.colmakh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmaphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colserisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmanv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colyeucau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsua = new System.Windows.Forms.DataGridViewImageColumn();
            this.colxoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieunhan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btt_refresh);
            this.groupBox1.Controls.Add(this.btt_themkh);
            this.groupBox1.Controls.Add(this.btt_thoat);
            this.groupBox1.Controls.Add(this.btt_luu);
            this.groupBox1.Controls.Add(this.dtp_hentra);
            this.groupBox1.Controls.Add(this.txt_ghichu);
            this.groupBox1.Controls.Add(this.txt_yeucau);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.txt_seri);
            this.groupBox1.Controls.Add(this.txt_maphieu);
            this.groupBox1.Controls.Add(this.cbb_makh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1434, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // btt_refresh
            // 
            this.btt_refresh.Location = new System.Drawing.Point(859, 199);
            this.btt_refresh.Name = "btt_refresh";
            this.btt_refresh.Size = new System.Drawing.Size(112, 36);
            this.btt_refresh.TabIndex = 19;
            this.btt_refresh.Text = "refresh";
            this.btt_refresh.UseVisualStyleBackColor = true;
            this.btt_refresh.Click += new System.EventHandler(this.btt_refresh_Click);
            // 
            // btt_themkh
            // 
            this.btt_themkh.Location = new System.Drawing.Point(1163, 199);
            this.btt_themkh.Name = "btt_themkh";
            this.btt_themkh.Size = new System.Drawing.Size(175, 36);
            this.btt_themkh.TabIndex = 9;
            this.btt_themkh.Text = "Thêm khách hàng";
            this.btt_themkh.UseVisualStyleBackColor = true;
            this.btt_themkh.Click += new System.EventHandler(this.btt_themkh_Click);
            // 
            // btt_thoat
            // 
            this.btt_thoat.Location = new System.Drawing.Point(561, 199);
            this.btt_thoat.Name = "btt_thoat";
            this.btt_thoat.Size = new System.Drawing.Size(103, 36);
            this.btt_thoat.TabIndex = 18;
            this.btt_thoat.Text = "Thoát";
            this.btt_thoat.UseVisualStyleBackColor = true;
            this.btt_thoat.Click += new System.EventHandler(this.btt_thoat_Click);
            // 
            // btt_luu
            // 
            this.btt_luu.Location = new System.Drawing.Point(276, 199);
            this.btt_luu.Name = "btt_luu";
            this.btt_luu.Size = new System.Drawing.Size(111, 36);
            this.btt_luu.TabIndex = 16;
            this.btt_luu.Text = "Lưu và in";
            this.btt_luu.UseVisualStyleBackColor = true;
            this.btt_luu.Click += new System.EventHandler(this.btt_luu_Click);
            // 
            // dtp_hentra
            // 
            this.dtp_hentra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hentra.Location = new System.Drawing.Point(1125, 50);
            this.dtp_hentra.Name = "dtp_hentra";
            this.dtp_hentra.Size = new System.Drawing.Size(213, 30);
            this.dtp_hentra.TabIndex = 15;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(1125, 102);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(213, 71);
            this.txt_ghichu.TabIndex = 13;
            // 
            // txt_yeucau
            // 
            this.txt_yeucau.Location = new System.Drawing.Point(697, 102);
            this.txt_yeucau.Multiline = true;
            this.txt_yeucau.Name = "txt_yeucau";
            this.txt_yeucau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_yeucau.Size = new System.Drawing.Size(243, 71);
            this.txt_yeucau.TabIndex = 12;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(697, 50);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(243, 30);
            this.txt_ten.TabIndex = 11;
            // 
            // txt_seri
            // 
            this.txt_seri.Location = new System.Drawing.Point(166, 143);
            this.txt_seri.Name = "txt_seri";
            this.txt_seri.Size = new System.Drawing.Size(281, 30);
            this.txt_seri.TabIndex = 10;
            // 
            // txt_maphieu
            // 
            this.txt_maphieu.Enabled = false;
            this.txt_maphieu.Location = new System.Drawing.Point(166, 100);
            this.txt_maphieu.Name = "txt_maphieu";
            this.txt_maphieu.Size = new System.Drawing.Size(281, 30);
            this.txt_maphieu.TabIndex = 9;
            // 
            // cbb_makh
            // 
            this.cbb_makh.FormattingEnabled = true;
            this.cbb_makh.Location = new System.Drawing.Point(166, 50);
            this.cbb_makh.Name = "cbb_makh";
            this.cbb_makh.Size = new System.Drawing.Size(281, 31);
            this.cbb_makh.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1043, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1000, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày hẹn trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yêu cầu của khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seri sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Location = new System.Drawing.Point(8, 646);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(68, 23);
            this.lb_manv.TabIndex = 8;
            this.lb_manv.Text = "NV002";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_phieunhan);
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1434, 386);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu nhận có sẵn";
            // 
            // dgv_phieunhan
            // 
            this.dgv_phieunhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieunhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmakh,
            this.colmaphieu,
            this.colserisp,
            this.coltensp,
            this.colmanv,
            this.colyeucau,
            this.colnn,
            this.colnht,
            this.colghichu,
            this.colsua,
            this.colxoa});
            this.dgv_phieunhan.Location = new System.Drawing.Point(3, 29);
            this.dgv_phieunhan.Name = "dgv_phieunhan";
            this.dgv_phieunhan.RowHeadersVisible = false;
            this.dgv_phieunhan.RowTemplate.Height = 24;
            this.dgv_phieunhan.Size = new System.Drawing.Size(1425, 342);
            this.dgv_phieunhan.TabIndex = 0;
            this.dgv_phieunhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phieunhan_CellClick);
            // 
            // colmakh
            // 
            this.colmakh.DataPropertyName = "tenkh";
            this.colmakh.HeaderText = "Tên khách hàng";
            this.colmakh.Name = "colmakh";
            this.colmakh.Width = 190;
            // 
            // colmaphieu
            // 
            this.colmaphieu.DataPropertyName = "maphieu";
            this.colmaphieu.HeaderText = "Mã phiếu";
            this.colmaphieu.Name = "colmaphieu";
            this.colmaphieu.Width = 115;
            // 
            // colserisp
            // 
            this.colserisp.DataPropertyName = "serisp";
            this.colserisp.HeaderText = "Seri SP";
            this.colserisp.Name = "colserisp";
            this.colserisp.Width = 110;
            // 
            // coltensp
            // 
            this.coltensp.DataPropertyName = "tensp";
            this.coltensp.HeaderText = "Tên SP";
            this.coltensp.Name = "coltensp";
            this.coltensp.Width = 110;
            // 
            // colmanv
            // 
            this.colmanv.DataPropertyName = "tennv";
            this.colmanv.HeaderText = "Tên NV TN";
            this.colmanv.Name = "colmanv";
            this.colmanv.Width = 190;
            // 
            // colyeucau
            // 
            this.colyeucau.DataPropertyName = "yeucauKH";
            this.colyeucau.HeaderText = "Yêu cầu KH";
            this.colyeucau.Name = "colyeucau";
            this.colyeucau.Width = 150;
            // 
            // colnn
            // 
            this.colnn.DataPropertyName = "ngaynhanhs";
            this.colnn.HeaderText = "Ngày NHS";
            this.colnn.Name = "colnn";
            this.colnn.Width = 130;
            // 
            // colnht
            // 
            this.colnht.DataPropertyName = "ngayhentra";
            this.colnht.HeaderText = "Ngày HT";
            this.colnht.Name = "colnht";
            this.colnht.Width = 130;
            // 
            // colghichu
            // 
            this.colghichu.DataPropertyName = "ghichu";
            this.colghichu.HeaderText = "Ghi chú";
            this.colghichu.Name = "colghichu";
            this.colghichu.Width = 150;
            // 
            // colsua
            // 
            this.colsua.HeaderText = "Sữa";
            this.colsua.Image = global::BAOCAOTN.Properties.Resources.cay_k;
            this.colsua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colsua.Name = "colsua";
            this.colsua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colsua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colsua.Width = 70;
            // 
            // colxoa
            // 
            this.colxoa.HeaderText = "Xóa";
            this.colxoa.Image = global::BAOCAOTN.Properties.Resources.t_rac;
            this.colxoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colxoa.Name = "colxoa";
            this.colxoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colxoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colxoa.Width = 70;
            // 
            // frm_phieunhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1550, 672);
            this.ControlBox = false;
            this.Controls.Add(this.lb_manv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_phieunhan";
            this.Text = "Phiếu nhận";
            this.Load += new System.EventHandler(this.frm_phieunhan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieunhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_yeucau;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_seri;
        private System.Windows.Forms.TextBox txt_maphieu;
        private System.Windows.Forms.ComboBox cbb_makh;
        private System.Windows.Forms.DateTimePicker dtp_hentra;
        private System.Windows.Forms.DataGridView dgv_phieunhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmaphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colserisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colyeucau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnht;
        private System.Windows.Forms.DataGridViewTextBoxColumn colghichu;
        private System.Windows.Forms.DataGridViewImageColumn colsua;
        private System.Windows.Forms.DataGridViewImageColumn colxoa;
        private System.Windows.Forms.Button btt_thoat;
        private System.Windows.Forms.Button btt_luu;
        private System.Windows.Forms.Button btt_themkh;
        private System.Windows.Forms.Button btt_refresh;
    }
}
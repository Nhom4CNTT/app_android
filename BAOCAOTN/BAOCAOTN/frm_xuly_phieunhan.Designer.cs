namespace BAOCAOTN
{
    partial class frm_xuly_phieunhan
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
            this.dgv_pnchuaxl = new System.Windows.Forms.DataGridView();
            this.colmakh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmaphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colserisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmanv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colyeucau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsua = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_pndangkt = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btt_refresh = new System.Windows.Forms.Button();
            this.btt_thoat = new System.Windows.Forms.Button();
            this.lbmanvdn = new System.Windows.Forms.Label();
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
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pnchuaxl)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pndangkt)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khsst)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_pnchuaxl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1505, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hồ sơ đang chờ xử lý";
            // 
            // dgv_pnchuaxl
            // 
            this.dgv_pnchuaxl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pnchuaxl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmakh,
            this.colmaphieu,
            this.colserisp,
            this.coltensp,
            this.colmanv,
            this.colyeucau,
            this.colnn,
            this.colnht,
            this.colghichu,
            this.coltrangthai,
            this.colsua});
            this.dgv_pnchuaxl.Location = new System.Drawing.Point(6, 29);
            this.dgv_pnchuaxl.Name = "dgv_pnchuaxl";
            this.dgv_pnchuaxl.RowHeadersVisible = false;
            this.dgv_pnchuaxl.RowTemplate.Height = 24;
            this.dgv_pnchuaxl.Size = new System.Drawing.Size(1489, 188);
            this.dgv_pnchuaxl.TabIndex = 1;
            this.dgv_pnchuaxl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pnchuaxl_CellClick);
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
            // coltrangthai
            // 
            this.coltrangthai.DataPropertyName = "tentt";
            this.coltrangthai.HeaderText = "TT HS";
            this.coltrangthai.Name = "coltrangthai";
            this.coltrangthai.Width = 120;
            // 
            // colsua
            // 
            this.colsua.HeaderText = "Xử lý";
            this.colsua.Image = global::BAOCAOTN.Properties.Resources.cay_k;
            this.colsua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colsua.Name = "colsua";
            this.colsua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colsua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colsua.Width = 90;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_pndangkt);
            this.groupBox2.Location = new System.Drawing.Point(12, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1505, 203);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hồ sơ trong trạng thái kiểm tra";
            // 
            // dgv_pndangkt
            // 
            this.dgv_pndangkt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pndangkt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewImageColumn1});
            this.dgv_pndangkt.Location = new System.Drawing.Point(6, 29);
            this.dgv_pndangkt.Name = "dgv_pndangkt";
            this.dgv_pndangkt.RowHeadersVisible = false;
            this.dgv_pndangkt.RowTemplate.Height = 24;
            this.dgv_pndangkt.Size = new System.Drawing.Size(1489, 165);
            this.dgv_pndangkt.TabIndex = 2;
            this.dgv_pndangkt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pndangkt_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tenkh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 190;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "maphieu";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã phiếu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 115;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "serisp";
            this.dataGridViewTextBoxColumn3.HeaderText = "Seri SP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tensp";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên SP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tennv";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên NV TN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 190;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "yeucauKH";
            this.dataGridViewTextBoxColumn6.HeaderText = "Yêu cầu KH";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ngaynhanhs";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ngày NHS";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ngayhentra";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ngày HT";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ghichu";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "tentt";
            this.dataGridViewTextBoxColumn10.HeaderText = "TT HS";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Xử lý";
            this.dataGridViewImageColumn1.Image = global::BAOCAOTN.Properties.Resources.cay_k;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 90;
            // 
            // btt_refresh
            // 
            this.btt_refresh.Location = new System.Drawing.Point(664, 687);
            this.btt_refresh.Name = "btt_refresh";
            this.btt_refresh.Size = new System.Drawing.Size(105, 42);
            this.btt_refresh.TabIndex = 1;
            this.btt_refresh.Text = "Refresh";
            this.btt_refresh.UseVisualStyleBackColor = true;
            this.btt_refresh.Click += new System.EventHandler(this.btt_refresh_Click);
            // 
            // btt_thoat
            // 
            this.btt_thoat.Location = new System.Drawing.Point(880, 687);
            this.btt_thoat.Name = "btt_thoat";
            this.btt_thoat.Size = new System.Drawing.Size(106, 42);
            this.btt_thoat.TabIndex = 2;
            this.btt_thoat.Text = "Thoát";
            this.btt_thoat.UseVisualStyleBackColor = true;
            this.btt_thoat.Click += new System.EventHandler(this.btt_thoat_Click);
            // 
            // lbmanvdn
            // 
            this.lbmanvdn.AutoSize = true;
            this.lbmanvdn.Location = new System.Drawing.Point(8, 706);
            this.lbmanvdn.Name = "lbmanvdn";
            this.lbmanvdn.Size = new System.Drawing.Size(68, 23);
            this.lbmanvdn.TabIndex = 3;
            this.lbmanvdn.Text = "NV002";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_khsst);
            this.groupBox3.Location = new System.Drawing.Point(12, 450);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1505, 234);
            this.groupBox3.TabIndex = 4;
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
            this.dataGridViewTextBoxColumn20});
            this.dgv_khsst.Location = new System.Drawing.Point(6, 29);
            this.dgv_khsst.Name = "dgv_khsst";
            this.dgv_khsst.RowHeadersVisible = false;
            this.dgv_khsst.RowTemplate.Height = 24;
            this.dgv_khsst.Size = new System.Drawing.Size(1489, 188);
            this.dgv_khsst.TabIndex = 1;
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
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "tentt";
            this.dataGridViewTextBoxColumn20.HeaderText = "TT HS";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 120;
            // 
            // frm_xuly_phieunhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1580, 741);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbmanvdn);
            this.Controls.Add(this.btt_thoat);
            this.Controls.Add(this.btt_refresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_xuly_phieunhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xử lý phiêu nhận";
            this.Load += new System.EventHandler(this.frm_xuly_phieunhan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pnchuaxl)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pndangkt)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khsst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_pnchuaxl;
        private System.Windows.Forms.DataGridView dgv_pndangkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btt_refresh;
        private System.Windows.Forms.Button btt_thoat;
        private System.Windows.Forms.Label lbmanvdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmaphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colserisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colyeucau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnht;
        private System.Windows.Forms.DataGridViewTextBoxColumn colghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrangthai;
        private System.Windows.Forms.DataGridViewImageColumn colsua;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    }
}
namespace BAOCAOTN
{
    partial class frm_nhanvien
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
            this.btt_thoat = new System.Windows.Forms.Button();
            this.btt_luu = new System.Windows.Forms.Button();
            this.dtp_namsinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.txt_dcnv = new System.Windows.Forms.TextBox();
            this.txt_sdtnv = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.colma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colchucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsua = new System.Windows.Forms.DataGridViewImageColumn();
            this.colxoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btt_thoat);
            this.groupBox1.Controls.Add(this.btt_luu);
            this.groupBox1.Controls.Add(this.dtp_namsinh);
            this.groupBox1.Controls.Add(this.cbb_chucvu);
            this.groupBox1.Controls.Add(this.txt_dcnv);
            this.groupBox1.Controls.Add(this.txt_sdtnv);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // btt_thoat
            // 
            this.btt_thoat.Location = new System.Drawing.Point(790, 107);
            this.btt_thoat.Name = "btt_thoat";
            this.btt_thoat.Size = new System.Drawing.Size(129, 29);
            this.btt_thoat.TabIndex = 14;
            this.btt_thoat.Text = "THOÁT";
            this.btt_thoat.UseVisualStyleBackColor = true;
            this.btt_thoat.Click += new System.EventHandler(this.btt_thoat_Click);
            // 
            // btt_luu
            // 
            this.btt_luu.Location = new System.Drawing.Point(790, 39);
            this.btt_luu.Name = "btt_luu";
            this.btt_luu.Size = new System.Drawing.Size(129, 37);
            this.btt_luu.TabIndex = 13;
            this.btt_luu.Text = "LƯU";
            this.btt_luu.UseVisualStyleBackColor = true;
            this.btt_luu.Click += new System.EventHandler(this.btt_luu_Click);
            // 
            // dtp_namsinh
            // 
            this.dtp_namsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_namsinh.Location = new System.Drawing.Point(171, 107);
            this.dtp_namsinh.Name = "dtp_namsinh";
            this.dtp_namsinh.Size = new System.Drawing.Size(181, 30);
            this.dtp_namsinh.TabIndex = 12;
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Location = new System.Drawing.Point(171, 70);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(181, 31);
            this.cbb_chucvu.TabIndex = 11;
            // 
            // txt_dcnv
            // 
            this.txt_dcnv.Location = new System.Drawing.Point(490, 110);
            this.txt_dcnv.Name = "txt_dcnv";
            this.txt_dcnv.Size = new System.Drawing.Size(254, 30);
            this.txt_dcnv.TabIndex = 10;
            // 
            // txt_sdtnv
            // 
            this.txt_sdtnv.Location = new System.Drawing.Point(490, 73);
            this.txt_sdtnv.Name = "txt_sdtnv";
            this.txt_sdtnv.Size = new System.Drawing.Size(254, 30);
            this.txt_sdtnv.TabIndex = 8;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(490, 36);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(254, 30);
            this.txt_tennv.TabIndex = 7;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(171, 33);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(181, 30);
            this.txt_ma.TabIndex = 6;
            this.txt_ma.TabIndexChanged += new System.EventHandler(this.btt_thoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Năm sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_nhanvien);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(979, 300);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhân viên sẵn có";
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colma,
            this.colten,
            this.colchucvu,
            this.colsdt,
            this.colns,
            this.coldiachi,
            this.colsua,
            this.colxoa});
            this.dgv_nhanvien.Location = new System.Drawing.Point(3, 26);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.RowHeadersVisible = false;
            this.dgv_nhanvien.RowTemplate.Height = 24;
            this.dgv_nhanvien.Size = new System.Drawing.Size(955, 255);
            this.dgv_nhanvien.TabIndex = 0;
            this.dgv_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_CellClick);
            // 
            // colma
            // 
            this.colma.DataPropertyName = "manv";
            this.colma.HeaderText = "Mã NV";
            this.colma.Name = "colma";
            this.colma.Width = 120;
            // 
            // colten
            // 
            this.colten.DataPropertyName = "tennv";
            this.colten.HeaderText = "Tên nhân viên";
            this.colten.Name = "colten";
            this.colten.Width = 220;
            // 
            // colchucvu
            // 
            this.colchucvu.DataPropertyName = "tencv";
            this.colchucvu.HeaderText = "Chức vụ";
            this.colchucvu.Name = "colchucvu";
            this.colchucvu.Width = 120;
            // 
            // colsdt
            // 
            this.colsdt.DataPropertyName = "sdt";
            this.colsdt.HeaderText = "SĐT";
            this.colsdt.Name = "colsdt";
            // 
            // colns
            // 
            this.colns.DataPropertyName = "namsinh";
            this.colns.HeaderText = "Năm sinh";
            this.colns.Name = "colns";
            this.colns.Width = 120;
            // 
            // coldiachi
            // 
            this.coldiachi.DataPropertyName = "diachi";
            this.coldiachi.HeaderText = "Địa chỉ";
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.Width = 130;
            // 
            // colsua
            // 
            this.colsua.HeaderText = "Sữa";
            this.colsua.Image = global::BAOCAOTN.Properties.Resources.cay_k;
            this.colsua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colsua.Name = "colsua";
            this.colsua.Width = 70;
            // 
            // colxoa
            // 
            this.colxoa.HeaderText = "Xóa";
            this.colxoa.Image = global::BAOCAOTN.Properties.Resources.t_rac;
            this.colxoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colxoa.Name = "colxoa";
            this.colxoa.Width = 70;
            // 
            // frm_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1014, 516);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frm_nhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btt_thoat;
        private System.Windows.Forms.Button btt_luu;
        private System.Windows.Forms.DateTimePicker dtp_namsinh;
        private System.Windows.Forms.ComboBox cbb_chucvu;
        private System.Windows.Forms.TextBox txt_dcnv;
        private System.Windows.Forms.TextBox txt_sdtnv;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colchucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colns;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiachi;
        private System.Windows.Forms.DataGridViewImageColumn colsua;
        private System.Windows.Forms.DataGridViewImageColumn colxoa;
    }
}
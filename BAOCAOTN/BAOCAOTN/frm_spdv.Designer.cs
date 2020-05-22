namespace BAOCAOTN
{
    partial class frm_spdv
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
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.txt_tenspdv = new System.Windows.Forms.TextBox();
            this.txt_maspdv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_spdv = new System.Windows.Forms.DataGridView();
            this.colmaspdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenspdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsua = new System.Windows.Forms.DataGridViewImageColumn();
            this.colxoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spdv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btt_thoat);
            this.groupBox1.Controls.Add(this.btt_luu);
            this.groupBox1.Controls.Add(this.txt_dvt);
            this.groupBox1.Controls.Add(this.txt_tenspdv);
            this.groupBox1.Controls.Add(this.txt_maspdv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // btt_thoat
            // 
            this.btt_thoat.Location = new System.Drawing.Point(458, 110);
            this.btt_thoat.Name = "btt_thoat";
            this.btt_thoat.Size = new System.Drawing.Size(92, 30);
            this.btt_thoat.TabIndex = 7;
            this.btt_thoat.Text = "THOÁT";
            this.btt_thoat.UseVisualStyleBackColor = true;
            this.btt_thoat.Click += new System.EventHandler(this.btt_thoat_Click);
            // 
            // btt_luu
            // 
            this.btt_luu.Location = new System.Drawing.Point(458, 33);
            this.btt_luu.Name = "btt_luu";
            this.btt_luu.Size = new System.Drawing.Size(92, 30);
            this.btt_luu.TabIndex = 6;
            this.btt_luu.Text = "LƯU";
            this.btt_luu.UseVisualStyleBackColor = true;
            this.btt_luu.Click += new System.EventHandler(this.btt_luu_Click);
            // 
            // txt_dvt
            // 
            this.txt_dvt.Location = new System.Drawing.Point(162, 110);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(244, 30);
            this.txt_dvt.TabIndex = 5;
            // 
            // txt_tenspdv
            // 
            this.txt_tenspdv.Location = new System.Drawing.Point(162, 72);
            this.txt_tenspdv.Name = "txt_tenspdv";
            this.txt_tenspdv.Size = new System.Drawing.Size(244, 30);
            this.txt_tenspdv.TabIndex = 4;
            // 
            // txt_maspdv
            // 
            this.txt_maspdv.Location = new System.Drawing.Point(162, 33);
            this.txt_maspdv.Name = "txt_maspdv";
            this.txt_maspdv.Size = new System.Drawing.Size(244, 30);
            this.txt_maspdv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SPDV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SPDV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_spdv);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 272);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm dịch vụ sẵn có";
            // 
            // dgv_spdv
            // 
            this.dgv_spdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_spdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmaspdv,
            this.coltenspdv,
            this.coldvt,
            this.colsua,
            this.colxoa});
            this.dgv_spdv.Location = new System.Drawing.Point(3, 26);
            this.dgv_spdv.Name = "dgv_spdv";
            this.dgv_spdv.RowHeadersVisible = false;
            this.dgv_spdv.RowTemplate.Height = 24;
            this.dgv_spdv.Size = new System.Drawing.Size(584, 240);
            this.dgv_spdv.TabIndex = 0;
            this.dgv_spdv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_spdv_CellClick);
            // 
            // colmaspdv
            // 
            this.colmaspdv.DataPropertyName = "maspdv";
            this.colmaspdv.HeaderText = "Mã SPDV";
            this.colmaspdv.Name = "colmaspdv";
            this.colmaspdv.Width = 150;
            // 
            // coltenspdv
            // 
            this.coltenspdv.DataPropertyName = "tenspdv";
            this.coltenspdv.HeaderText = "Tên SPDV";
            this.coltenspdv.Name = "coltenspdv";
            this.coltenspdv.Width = 190;
            // 
            // coldvt
            // 
            this.coldvt.DataPropertyName = "dvt";
            this.coldvt.HeaderText = "ĐVT";
            this.coldvt.Name = "coldvt";
            this.coldvt.Width = 70;
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
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Sữa";
            this.dataGridViewImageColumn1.Image = global::BAOCAOTN.Properties.Resources.cay_k;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Xóa";
            this.dataGridViewImageColumn2.Image = global::BAOCAOTN.Properties.Resources.t_rac;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // frm_spdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(628, 462);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_spdv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_spdv";
            this.Load += new System.EventHandler(this.frm_spdv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btt_thoat;
        private System.Windows.Forms.Button btt_luu;
        private System.Windows.Forms.TextBox txt_dvt;
        private System.Windows.Forms.TextBox txt_tenspdv;
        private System.Windows.Forms.TextBox txt_maspdv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_spdv;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmaspdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenspdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldvt;
        private System.Windows.Forms.DataGridViewImageColumn colsua;
        private System.Windows.Forms.DataGridViewImageColumn colxoa;
    }
}
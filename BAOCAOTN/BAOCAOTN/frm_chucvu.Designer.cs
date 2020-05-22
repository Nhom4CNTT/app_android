namespace BAOCAOTN
{
    partial class frm_chucvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_chucvu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btt_thoat = new System.Windows.Forms.Button();
            this.btt_luu = new System.Windows.Forms.Button();
            this.txt_tencv = new System.Windows.Forms.TextBox();
            this.txt_macv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_chucvu = new System.Windows.Forms.DataGridView();
            this.colmacv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltencv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsua = new System.Windows.Forms.DataGridViewImageColumn();
            this.colxoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chucvu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btt_thoat);
            this.groupBox1.Controls.Add(this.btt_luu);
            this.groupBox1.Controls.Add(this.txt_tencv);
            this.groupBox1.Controls.Add(this.txt_macv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // btt_thoat
            // 
            this.btt_thoat.Location = new System.Drawing.Point(348, 85);
            this.btt_thoat.Name = "btt_thoat";
            this.btt_thoat.Size = new System.Drawing.Size(106, 31);
            this.btt_thoat.TabIndex = 4;
            this.btt_thoat.Text = "THOÁT";
            this.btt_thoat.UseVisualStyleBackColor = true;
            this.btt_thoat.Click += new System.EventHandler(this.btt_thoat_Click);
            // 
            // btt_luu
            // 
            this.btt_luu.Location = new System.Drawing.Point(348, 36);
            this.btt_luu.Name = "btt_luu";
            this.btt_luu.Size = new System.Drawing.Size(106, 31);
            this.btt_luu.TabIndex = 0;
            this.btt_luu.Text = "LƯU";
            this.btt_luu.UseVisualStyleBackColor = true;
            this.btt_luu.Click += new System.EventHandler(this.btt_luu_Click);
            // 
            // txt_tencv
            // 
            this.txt_tencv.Location = new System.Drawing.Point(128, 86);
            this.txt_tencv.Name = "txt_tencv";
            this.txt_tencv.Size = new System.Drawing.Size(180, 30);
            this.txt_tencv.TabIndex = 3;
            // 
            // txt_macv
            // 
            this.txt_macv.Location = new System.Drawing.Point(128, 36);
            this.txt_macv.Name = "txt_macv";
            this.txt_macv.Size = new System.Drawing.Size(180, 30);
            this.txt_macv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chức vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_chucvu);
            this.groupBox2.Location = new System.Drawing.Point(13, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 248);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức vụ sẵn có";
            // 
            // dgv_chucvu
            // 
            this.dgv_chucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chucvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmacv,
            this.coltencv,
            this.colsua,
            this.colxoa});
            this.dgv_chucvu.Location = new System.Drawing.Point(3, 24);
            this.dgv_chucvu.Name = "dgv_chucvu";
            this.dgv_chucvu.RowHeadersVisible = false;
            this.dgv_chucvu.RowTemplate.Height = 24;
            this.dgv_chucvu.Size = new System.Drawing.Size(486, 218);
            this.dgv_chucvu.TabIndex = 0;
            this.dgv_chucvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chucvu_CellClick);
            // 
            // colmacv
            // 
            this.colmacv.DataPropertyName = "macv";
            this.colmacv.HeaderText = "Mã chức vụ";
            this.colmacv.Name = "colmacv";
            this.colmacv.Width = 150;
            // 
            // coltencv
            // 
            this.coltencv.DataPropertyName = "tencv";
            this.coltencv.HeaderText = "Tên chức vụ";
            this.coltencv.Name = "coltencv";
            this.coltencv.Width = 190;
            // 
            // colsua
            // 
            this.colsua.HeaderText = "Sữa";
            this.colsua.Image = ((System.Drawing.Image)(resources.GetObject("colsua.Image")));
            this.colsua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colsua.Name = "colsua";
            this.colsua.Width = 70;
            // 
            // colxoa
            // 
            this.colxoa.HeaderText = "Xóa";
            this.colxoa.Image = ((System.Drawing.Image)(resources.GetObject("colxoa.Image")));
            this.colxoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colxoa.Name = "colxoa";
            this.colxoa.Width = 70;
            // 
            // frm_chucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(541, 453);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_chucvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chức vụ";
            this.Load += new System.EventHandler(this.frm_chucvu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chucvu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tencv;
        private System.Windows.Forms.TextBox txt_macv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btt_thoat;
        private System.Windows.Forms.Button btt_luu;
        private System.Windows.Forms.DataGridView dgv_chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmacv;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltencv;
        private System.Windows.Forms.DataGridViewImageColumn colsua;
        private System.Windows.Forms.DataGridViewImageColumn colxoa;
    }
}
namespace BAOCAOTN
{
    partial class frm_md5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bandau = new System.Windows.Forms.TextBox();
            this.txt_md5 = new System.Windows.Forms.TextBox();
            this.btn_doi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ban đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "MD5";
            // 
            // txt_bandau
            // 
            this.txt_bandau.Location = new System.Drawing.Point(200, 37);
            this.txt_bandau.Name = "txt_bandau";
            this.txt_bandau.Size = new System.Drawing.Size(332, 30);
            this.txt_bandau.TabIndex = 2;
            // 
            // txt_md5
            // 
            this.txt_md5.Location = new System.Drawing.Point(200, 101);
            this.txt_md5.Name = "txt_md5";
            this.txt_md5.Size = new System.Drawing.Size(332, 30);
            this.txt_md5.TabIndex = 3;
            // 
            // btn_doi
            // 
            this.btn_doi.BackColor = System.Drawing.Color.Red;
            this.btn_doi.Location = new System.Drawing.Point(219, 148);
            this.btn_doi.Name = "btn_doi";
            this.btn_doi.Size = new System.Drawing.Size(139, 46);
            this.btn_doi.TabIndex = 4;
            this.btn_doi.Text = "CHUYỂN";
            this.btn_doi.UseVisualStyleBackColor = false;
            this.btn_doi.Click += new System.EventHandler(this.btn_doi_Click);
            // 
            // frm_md5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(556, 206);
            this.ControlBox = false;
            this.Controls.Add(this.btn_doi);
            this.Controls.Add(this.txt_md5);
            this.Controls.Add(this.txt_bandau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_md5";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bandau;
        private System.Windows.Forms.TextBox txt_md5;
        private System.Windows.Forms.Button btn_doi;
    }
}


namespace BAOCAOTN
{
    partial class frm_inhoadon
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
            this.crv_inhoadon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_inhoadon
            // 
            this.crv_inhoadon.ActiveViewIndex = -1;
            this.crv_inhoadon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_inhoadon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_inhoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_inhoadon.Location = new System.Drawing.Point(0, 0);
            this.crv_inhoadon.Name = "crv_inhoadon";
            this.crv_inhoadon.Size = new System.Drawing.Size(1052, 624);
            this.crv_inhoadon.TabIndex = 0;
            // 
            // frm_inhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1052, 624);
            this.Controls.Add(this.crv_inhoadon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_inhoadon";
            this.Text = "In hóa đơn";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_inhoadon;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAOCAOTN
{
    public partial class frm_main : Form
    {
        public frm_main(String manv)
        {
            InitializeComponent();
            lbnvdn.Text = manv;
        }

        private void thêmChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_md5 MD5 = new frm_md5();
            MD5.Close();
            frm_chucvu chucvu = new frm_chucvu();
            chucvu.MdiParent = this;
            chucvu.Show();
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nhanvien nhanvien = new frm_nhanvien();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_khachhang khachhang = new frm_khachhang();
            khachhang.MdiParent = this;
            khachhang.Show();
        }

        private void thêmSảnPhẩmDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_spdv spdv = new frm_spdv();
            spdv.MdiParent = this;
            spdv.Show();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
        }

        private void thêmPhiếuNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_phieunhan phieunhan = new frm_phieunhan(lbnvdn.Text);
            phieunhan.MdiParent = this;
            phieunhan.Show();
        }

        private void xửLýKháchHàngĐãNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_xuly_phieunhan xl = new frm_xuly_phieunhan(lbnvdn.Text);
            xl.MdiParent = this;
            xl.Show();
        }

        private void thoátỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void xửLýKháchHàngSẵnSàngTrảtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_trakhach tra = new frm_trakhach(lbnvdn.Text);
            tra.MdiParent = this;
            tra.Show();
        }

        private void xemCácPhiếuNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_bc_pn ncpn = new frm_bc_pn();
            ncpn.MdiParent = this;
            ncpn.Show();
        }
    }
}

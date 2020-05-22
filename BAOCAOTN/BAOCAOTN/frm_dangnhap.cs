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
    public partial class frm_dangnhap : Form
    {
        dungchung lib = new dungchung();
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void btt_dn_Click(object sender, EventArgs e)
        {
            String tk = txt_tk.Text;
            String mk = txt_mk.Text.Trim();
            //if (String.IsNullOrEmpty(tk) && String.IsNullOrEmpty(mk))
            if (tk == "" || mk == "")
            {
                MessageBox.Show("Tài khoản & Mật khẩu không được rỗng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tk.Focus();
            }
            else
            {
                String mk_md5 = lib.cryMD5(mk);
                String sql = "Select * from nhanvien Where manv=N'" + tk + "' and matkhau=N'" + mk_md5 + "'";
                if (lib.reDataSet(sql).Tables[0].Rows.Count != 0)
                {
                    //MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frm_main frmchinh = new frm_main(tk);
                    this.Hide();
                    frmchinh.ShowDialog();
                    try { this.Show(); }
                    catch { }
                    
                }
                else
                    MessageBox.Show("Đăng nhập thất bại/n Do tài khoản hoặc mật khẩu sai", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

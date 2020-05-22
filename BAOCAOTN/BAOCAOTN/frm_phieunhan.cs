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
    public partial class frm_phieunhan : Form
    {
        dungchung lib = new dungchung();
        bool flag = true;
        public frm_phieunhan( String manvdn)
        {
            InitializeComponent();
            lb_manv.Text = manvdn;
        }
        private void hienthikhachhang()
        {
            //Tao chuoi sql doc du lieu tu bang NHANVIEN
            String sql = "Select makh,tenkh From khachhang order by tenkh";
            //Lay du lieu tu DataSet do vao DataGridView
            cbb_makh.DataSource = lib.reDataSet(sql).Tables[0].DefaultView;
            cbb_makh.DisplayMember = "tenkh";
            cbb_makh.ValueMember = "makh";
        }
        private void xoadulieutrenform()
        {
            txt_maphieu.Clear();
            txt_ghichu.Clear();
            txt_seri.Clear();
            txt_ten.Clear();
            txt_yeucau.Clear();
            dtp_hentra.Refresh();
            cbb_makh.Enabled = true;
        }
        private void hienthiphieunhan()
        {
            //Tao chuoi sql doc du lieu tu bang NHANVIEN
            String sql = "Select * From phieunhan join khachhang on phieunhan.makh=khachhang.makh join nhanvien on phieunhan.manv=nhanvien.manv join xuly on phieunhan.maphieu=xuly.maphieu where xuly.ghichu=N'' and xuly.matt=N'DN' order by phieunhan.maphieu";

            //Tat che do tu dong tao ra Column cua DataGridView
            dgv_phieunhan.AutoGenerateColumns = false;

            //Lay du lieu tu DataSet do vao DataGridView
            dgv_phieunhan.DataSource = lib.reDataSet(sql).Tables[0].DefaultView;
        }
        private void frm_phieunhan_Load(object sender, EventArgs e)
        {
            hienthikhachhang();
            hienthiphieunhan();
        }
        private void btt_themkh_Click(object sender, EventArgs e)
        {
            frm_khachhang kh = new frm_khachhang();
            kh.Show();
        }

        private void btt_refresh_Click(object sender, EventArgs e)
        {
            hienthikhachhang();
            hienthiphieunhan();
            xoadulieutrenform();
        }

        private void btt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btt_luu_Click(object sender, EventArgs e)
        {
            String mp = txt_maphieu.Text.Trim();
            String makh = cbb_makh.SelectedValue.ToString();
            String seri = txt_seri.Text.Trim();
            String tensp = txt_ten.Text.Trim();
            String yeucau = txt_yeucau.Text.Trim();
            String ghichu = txt_ghichu.Text.Trim();
            DateTime nht = Convert.ToDateTime(dtp_hentra.Text.Trim());
            String ngayht = String.Format("{0:MM/dd/yyyy}", nht);
            DateTime nnhs = DateTime.Today;
            String ngaynhs = String.Format("{0:MM/dd/yyyy}", nnhs);
            String manv = lb_manv.Text;

            String sql = "";
            if (flag == true)
            {
                sql += "insert into phieunhan(makh,serisp,tensp,yeucaukh,ghichu,manv,ngayhentra,ngaynhanhs) output inserted.maphieu ";
                sql += "values('" + makh + "',N'" + seri + "',N'" + tensp + "',N'" + yeucau + "',N'" + ghichu + "',N'" + manv + "','" + ngayht + "','" + ngaynhs + "') ";
                sql += "insert into xuly(maphieu,manv,matt,thoigian,ghichu) output inserted.maxl values((select max(maphieu) from phieunhan), N'" + manv + "',N'DN','" + ngaynhs + "',N'')";
            }
            else
            {
                sql += "update phieunhan set serisp=N'" + seri + "',tensp=N'" + tensp + "',yeucaukh=N'" + yeucau + "',ngayhentra='" + ngayht + "',ghichu=N'" + ghichu + "' where maphieu='" + mp + "'";
            }
            if (lib.execSQL(sql) == true)
            {
                hienthiphieunhan();
                xoadulieutrenform();
                cbb_makh.Enabled = true;
                if (flag == true)
                {
                    frm_in_phieunhan IN = new frm_in_phieunhan();
                    IN.Show();
                }
                else
                {
                    flag = true;
                }
            }
            else
                MessageBox.Show("Lưu không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgv_phieunhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                //Lay du lieu tu DataGridView hien thi len form
                String mkh = dgv_phieunhan.CurrentRow.Cells[0].Value.ToString();
                cbb_makh.SelectedIndex = cbb_makh.FindString(mkh);
                txt_maphieu.Text = dgv_phieunhan.CurrentRow.Cells[1].Value.ToString();
                txt_seri.Text = dgv_phieunhan.CurrentRow.Cells[2].Value.ToString();
                txt_ten.Text = dgv_phieunhan.CurrentRow.Cells[3].Value.ToString();
                txt_yeucau.Text = dgv_phieunhan.CurrentRow.Cells[5].Value.ToString();
                dtp_hentra.Text = dgv_phieunhan.CurrentRow.Cells[7].Value.ToString();
                txt_ghichu.Text = dgv_phieunhan.CurrentRow.Cells[8].Value.ToString();

                //Chuyen trang thai cua flag sang update
                flag = false;
                txt_maphieu.Enabled = false;
            }
            else if (e.ColumnIndex == 10)
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    //Khai bao bien lay MANH tu DataGridView
                    String ma = dgv_phieunhan.CurrentRow.Cells[1].Value.ToString();

                    //Khai bao chuoi sql de xoa du lieu
                    String sql = "update xuly set ghichu=N'del' Where maphieu='" + ma + "' and ghichu=N''";

                    //Kiem tra trang thai xoa
                    if (lib.execSQL(sql) == true)
                        hienthiphieunhan();
                    else
                        MessageBox.Show("Xóa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

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
    public partial class frm_xuly_phieunhan : Form
    {
        dungchung lib = new dungchung();

        public frm_xuly_phieunhan(String manv)
        {
            InitializeComponent();
            lbmanvdn.Text = manv;
        }
        private void hienthipnchoxl()
        {
            //Tao chuoi sql doc du lieu tu bang NHANVIEN
            String sql = "Select * From phieunhan join khachhang on phieunhan.makh=khachhang.makh join nhanvien on phieunhan.manv=nhanvien.manv join xuly on phieunhan.maphieu=xuly.maphieu join trangthai on xuly.matt=trangthai.matt where xuly.ghichu=N'' and xuly.matt=N'DN' order by phieunhan.maphieu";

            //Tat che do tu dong tao ra Column cua DataGridView
            dgv_pnchuaxl.AutoGenerateColumns = false;

            //Lay du lieu tu DataSet do vao DataGridView
            dgv_pnchuaxl.DataSource = lib.reDataSet(sql).Tables[0].DefaultView;
        }
        private void hienthipndangkt()
        {
            //Tao chuoi sql doc du lieu tu bang NHANVIEN
            String sql = "Select * From phieunhan join khachhang on phieunhan.makh=khachhang.makh join nhanvien on phieunhan.manv=nhanvien.manv join xuly on phieunhan.maphieu=xuly.maphieu join trangthai on xuly.matt=trangthai.matt where xuly.ghichu=N'' and xuly.matt=N'KT' order by phieunhan.maphieu";

            //Tat che do tu dong tao ra Column cua DataGridView
            dgv_pndangkt.AutoGenerateColumns = false;

            //Lay du lieu tu DataSet do vao DataGridView
            dgv_pndangkt.DataSource = lib.reDataSet(sql).Tables[0].DefaultView;
        }
        private void hienthisstrak()
        {
            //Tao chuoi sql doc du lieu tu bang NHANVIEN
            String sql = "Select * From phieunhan join khachhang on phieunhan.makh=khachhang.makh join nhanvien on phieunhan.manv=nhanvien.manv join xuly on phieunhan.maphieu=xuly.maphieu join trangthai on xuly.matt=trangthai.matt where xuly.ghichu=N'' and xuly.matt=N'SSTK' order by phieunhan.maphieu";

            //Tat che do tu dong tao ra Column cua DataGridView
            dgv_khsst.AutoGenerateColumns = false;

            //Lay du lieu tu DataSet do vao DataGridView
            dgv_khsst.DataSource = lib.reDataSet(sql).Tables[0].DefaultView;
        }
        private void btt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frm_xuly_phieunhan_Load(object sender, EventArgs e)
        {
            hienthipnchoxl();
            hienthipndangkt();
            hienthisstrak();
        }

        private void btt_refresh_Click(object sender, EventArgs e)
        {
            hienthipnchoxl();
            hienthipndangkt();
            hienthisstrak();
        }

        private void dgv_pnchuaxl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                String sql = "";
                String manv = lbmanvdn.Text;
                String mp = dgv_pnchuaxl.CurrentRow.Cells[1].Value.ToString();
                DateTime nxl = DateTime.Today;
                String ngayxl = String.Format("{0:MM/dd/yyyy}", nxl);
                sql += "update xuly set ghichu=N'X' where maphieu='" + mp + "' and matt=N'DN' and ghichu=N'' insert into xuly(maphieu,manv,matt,thoigian,ghichu) output inserted.maxl values(N'" + mp + "', N'" + manv + "',N'KT','" + ngayxl + "',N'')";
                if (lib.execSQL(sql) == true)
                {
                    hienthipnchoxl();
                    hienthipndangkt();
                    hienthisstrak();
                }
                else
                    MessageBox.Show("Xử lý hồ sơ không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_pndangkt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                String sql = "";
                String manv = lbmanvdn.Text;
                String mp = dgv_pndangkt.CurrentRow.Cells[1].Value.ToString();
                DateTime nxl = DateTime.Today;
                String ngayxl = String.Format("{0:MM/dd/yyyy}", nxl);
                sql += "update xuly set ghichu=N'X' where maphieu='" + mp + "' and matt=N'KT' and ghichu=N'' insert into xuly(maphieu,manv,matt,thoigian,ghichu) output inserted.maxl values(N'" + mp + "', N'" + manv + "',N'SSTK','" + ngayxl + "',N'')";
                if (lib.execSQL(sql) == true)
                {
                    hienthipnchoxl();
                    hienthipndangkt();
                    hienthisstrak();
                }
                else
                    MessageBox.Show("Xử lý hồ sơ không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

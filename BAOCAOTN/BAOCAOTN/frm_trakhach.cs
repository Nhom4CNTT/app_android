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
    public partial class frm_trakhach : Form
    {
        dungchung lib = new dungchung();
        public frm_trakhach(String nvdn)
        {
            InitializeComponent();
            lbnvdn.Text = nvdn;
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
        private void hienthinv()
        {
            //Tao chuoi sql doc du lieu tu bang NHANVIEN
            String sql = "Select manv,tennv From nhanvien where manv=N'" + lbnvdn.Text + "'";
            //Lay du lieu tu DataSet do vao DataGridView
            cbb_nv.DataSource = lib.reDataSet(sql).Tables[0].DefaultView;
            cbb_nv.DisplayMember = "tennv";
            cbb_nv.ValueMember = "manv";
        }
        private void spdv()
        {
            String sql = "Select MASPdv, TENSPdv From spdv Order by TENSPdv";
            cbbThemSP.DataSource = lib.reDataSet(sql).Tables[0].DefaultView;
            cbbThemSP.DisplayMember = "TENSPdv";
            cbbThemSP.ValueMember = "MASPdv";
        }
        private void tongtien()
        {
            int tongTien = 0;

            for (int i = 0; i < dgvSanPham.Rows.Count - 1; i++)
            {
                tongTien += Convert.ToInt32(dgvSanPham.Rows[i].Cells[4].Value.ToString());
            }

            txtTongTienHang.Text = String.Format("{0:0,0}", tongTien);
        }
        private void frm_trakhach_Load(object sender, EventArgs e)
        {
            hienthisstrak();
            hienthinv();
            spdv();
        }

        private void dgv_khsst_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime td = DateTime.Today;
            String ngaylaphd = String.Format("{0:MM/dd/yyyy}", td);
            txt_kh.Text = dgv_khsst.CurrentRow.Cells[0].Value.ToString();
            txt_map.Text = dgv_khsst.CurrentRow.Cells[1].Value.ToString();
        }

        private void bttThemSP_Click(object sender, EventArgs e)
        {

            //Lay du lieu tu Combobox
            String ma = cbbThemSP.SelectedValue.ToString();
            String ten = cbbThemSP.Text;

            //Gan gia tri  mac dinh
            int soLuong = 1;
            int donGia = 0;
            int thanhTien = soLuong * donGia;

            //Dem so dong cua DataGridView
            int count = dgvSanPham.Rows.Count;

            bool flag = false; //Trang thai san pham cua ton tai trong DataGridView

            if (count != 0)
            {
                //Quet toan bo DataGridView kiem tra SP co ton tai chua
                for (int i = 0; i < count - 1; i++)
                {
                    if (dgvSanPham.Rows[i].Cells[0].Value.ToString() == ma)
                        flag = true;
                }
                //Neu da ton tai thi tang so luong len 1
                if (flag == true)
                {
                    dgvSanPham.CurrentRow.Cells[2].Value = Convert.ToInt32(dgvSanPham.CurrentRow.Cells[2].Value.ToString()) + 1;
                }
                else
                {
                    DataGridViewRow row = (DataGridViewRow)dgvSanPham.Rows[0].Clone();
                    row.Cells[0].Value = ma;
                    row.Cells[1].Value = ten;
                    row.Cells[2].Value = soLuong;
                    row.Cells[3].Value = donGia;
                    row.Cells[4].Value = thanhTien;
                    dgvSanPham.Rows.Add(row);
                }
            }
            else
            {
                DataGridViewRow row = (DataGridViewRow)dgvSanPham.Rows[0].Clone();
                row.Cells[0].Value = ma;
                row.Cells[1].Value = ten;
                row.Cells[2].Value = soLuong;
                row.Cells[3].Value = donGia;
                row.Cells[4].Value = thanhTien;
                dgvSanPham.Rows.Add(row);
            }
        }

        private void dgvSanPham_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int soLuong = Convert.ToInt32(dgvSanPham.CurrentRow.Cells[2].Value.ToString());
            int donGia = Convert.ToInt32(dgvSanPham.CurrentRow.Cells[3].Value.ToString());
            int thanhTien = soLuong * donGia;
            dgvSanPham.CurrentRow.Cells[4].Value = thanhTien;
            tongtien();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                dgvSanPham.Rows.RemoveAt(dgvSanPham.CurrentRow.Index);
                tongtien();
            }
        }

        private void cbbThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.Rows.Count - 1 > 0)
            {
                bool flag = true;
                String khachHang = txt_kh.Text.ToString();
                String nhanVien = cbb_nv.SelectedValue.ToString();
                DateTime nlhd = Convert.ToDateTime(txtNgayLapHD.Text.Trim());
                String ngaylhd = String.Format("{0:MM/dd/yyyy}", nlhd);
                String sqlHD = "Insert into HOADON(maphieu, MANV, NGaylapHD) Values('" + txt_map.Text + "','" + nhanVien + "','" + ngaylhd + "') ";
                sqlHD+= "update xuly set ghichu=N'X' where maphieu='" + txt_map.Text + "' and matt=N'SSTK' and ghichu=N'' insert into xuly(maphieu,manv,matt,thoigian,ghichu) output inserted.maxl values(N'" + txt_map.Text + "', N'" + lbnvdn.Text + "',N'HT','" + ngaylhd + "',N'')";

                if (lib.execSQL(sqlHD) == false)
                {
                    MessageBox.Show("Lập hóa đơn không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
                else
                {
                    flag = true;
                    String sqlLayMaHD = "SELECT MAX(maHD) as sohd FROM HOADON";
                    String maHD = lib.reDataSet(sqlLayMaHD).Tables[0].Rows[0]["soHD"].ToString();
                    for (int i = 0; i < dgvSanPham.Rows.Count - 1; i++)
                    {
                        String maSP = dgvSanPham.Rows[i].Cells[0].Value.ToString();
                        int sl = Convert.ToInt32(dgvSanPham.Rows[i].Cells[2].Value.ToString());
                        int dg = Convert.ToInt32(dgvSanPham.Rows[i].Cells[3].Value.ToString());

                        String sqlCTHD = "Insert into chitiethd Values('" + maHD + "',N'" + maSP + "','" + sl + "','" + dg + "')";

                        lib.execSQL(sqlCTHD);

                    }
                }

                if (flag == true)
                {
                    String sqlLayMaHD = "SELECT MAX(maHD) AS SOHD FROM HOADON";
                    String ma_HD = lib.reDataSet(sqlLayMaHD).Tables[0].Rows[0]["SOHD"].ToString();
                    frm_inhoadon fInHoaDon = new frm_inhoadon(ma_HD);
                    fInHoaDon.Show();
                    hienthisstrak();
                }
                else
                {
                    MessageBox.Show("Lap hoa don khong thanh cong.", "QLBH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Chua co san pham.", "QLBH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbThemSP.Focus();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BAOCAOTN
{
    public partial class frm_khachhang : Form
    {
        dungchung lib = new dungchung();
        bool flag = true;
        public frm_khachhang()
        {
            InitializeComponent();
        }
        private void XoaDuLieuTrenForm()
        {
            txt_makh.Clear();
            txt_tenkh.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
        }
        private void HienThiKhachHang()
        {
            //Tao chuoi sql doc du lieu tu bang NHANVIEN
            String sql = "Select * From khachhang order by makh";

            //Tat che do tu dong tao ra Column cua DataGridView
            dgv_khachhang.AutoGenerateColumns = false;

            //Lay du lieu tu DataSet do vao DataGridView
            dgv_khachhang.DataSource = lib.reDataSet(sql).Tables[0].DefaultView;
        }

        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            HienThiKhachHang();
            txt_makh.Enabled = false;
        }

        private void btt_luu_Click(object sender, EventArgs e)
        {
            //Khai bao cac bien lay du lieu nhap tu form
            String ma = txt_makh.Text.Trim();
            String ten = txt_tenkh.Text.Trim();
            String dienthoai = txt_sdt.Text.Trim();
            String dc = txt_diachi.Text.Trim();

            //Khai bao chuoi sql
            String sql = "";

            if (flag == true)
            {
                sql += "Insert into khachhang(tenkh, sdt, diachi) output inserted.makh Values(N'" + ten + "',";
                sql += "N'" + dienthoai + "',N'" + dc + "')";
            }
            else
            {
                sql += "Update khachhang Set tenkh=N'" + ten + "', SDT=N'" + dienthoai + "', diachi=N'" + dc + "' ";
                sql += "Where MAKH='" + ma + "'";
            }

            //Kiem tra trang lai button Luu
            if (lib.execSQL(sql) == true)
            {
                HienThiKhachHang();
                XoaDuLieuTrenForm();
                txt_makh.Enabled = true;
                flag = true;
            }
            else
                MessageBox.Show("Lưu không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                //Lay du lieu tu DataGridView hien thi len form
                txt_makh.Text = dgv_khachhang.CurrentRow.Cells[0].Value.ToString();
                txt_tenkh.Text = dgv_khachhang.CurrentRow.Cells[1].Value.ToString();
                txt_diachi.Text = dgv_khachhang.CurrentRow.Cells[3].Value.ToString();
                txt_sdt.Text = dgv_khachhang.CurrentRow.Cells[2].Value.ToString();

                txt_makh.Enabled = false;
                //Chuyen trang thai cua flag sang update
                flag = false;
            }
            else if (e.ColumnIndex == 5)
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    //Khai bao bien lay MANH tu DataGridView
                    String ma = dgv_khachhang.CurrentRow.Cells[0].Value.ToString();

                    //Khai bao chuoi sql de xoa du lieu
                    String sql = "Delete From khachhang Where MAkh='" + ma + "'";

                    //Kiem tra trang thai xoa
                    if (lib.execSQL(sql) == true)
                        HienThiKhachHang();
                    else
                        MessageBox.Show("Xóa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

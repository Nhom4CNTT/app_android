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
    public partial class frm_chucvu : Form
    {
        dungchung lib = new dungchung();
        bool flag = true;
        public frm_chucvu()
        {
            InitializeComponent();
        }
        private void HienThiChucVu()
        {
            //Tao chuoi sql doc du lieu tu bang NHANVIEN
            String sql = "Select * From chucvu order by tencv";

            //Tat che do tu dong tao ra Column cua DataGridView
            dgv_chucvu.AutoGenerateColumns = false;

            //Lay du lieu tu DataSet do vao DataGridView
            dgv_chucvu.DataSource = lib.reDataSet(sql).Tables[0].DefaultView;
        }
        private void XoaDuLieuTrenForm()
        {
            txt_macv.Clear();
            txt_tencv.Clear();
        }
        private void frm_chucvu_Load(object sender, EventArgs e)
        {
            HienThiChucVu();
        }

        private void btt_luu_Click(object sender, EventArgs e)
        {
            //Khai bao cac bien lay du lieu nhap tu form
            String ma = txt_macv.Text.Trim();
            String ten = txt_tencv.Text.Trim();

            //Khai bao chuoi sql
            String sql = "";

            if (flag == true)
            {
                sql += "Insert into chucvu Values(N'" + ma + "',N'" + ten + "')";
            }
            else
            {
                sql += "Update chucvu Set tencv=N'" + ten + "' Where macv=N'" + ma + "'";
            }

            //Kiem tra trang lai button Luu
            if (lib.execSQL(sql) == true)
            {
                HienThiChucVu();
                txt_macv.Enabled = true;
                XoaDuLieuTrenForm();
                flag = true;
            }
            else
                MessageBox.Show("Lưu không thành công.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgv_chucvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                //Lay du lieu tu DataGridView hien thi len form
                txt_macv.Text = dgv_chucvu.CurrentRow.Cells[0].Value.ToString();
                txt_tencv.Text = dgv_chucvu.CurrentRow.Cells[1].Value.ToString();

                //Chuyen trang thai cua flag sang update
                flag = false;
                txt_macv.Enabled = false;
            }
            else if (e.ColumnIndex == 3)
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    //Khai bao bien lay MANH tu DataGridView
                    String ma = dgv_chucvu.CurrentRow.Cells[0].Value.ToString();

                    //Khai bao chuoi sql de xoa du lieu
                    String sql = "Delete From chucvu Where macv=N'" + ma + "'";

                    //Kiem tra trang thai xoa
                    if (lib.execSQL(sql) == true)
                        HienThiChucVu();
                    else
                        MessageBox.Show("Xóa không thành công, Có thể do lỗi về các khóa ngoại, khóa chính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

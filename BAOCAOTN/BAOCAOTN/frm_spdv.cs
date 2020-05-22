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
    public partial class frm_spdv : Form
    {
        dungchung lib = new dungchung();
        bool flag = true;
        public frm_spdv()
        {
            InitializeComponent();
        }
        private void HienThiSPDV()
        {
            //Tao chuoi sql doc du lieu tu bang NHANVIEN
            String sql = "Select * From spdv";

            //Tat che do tu dong tao ra Column cua DataGridView
            dgv_spdv.AutoGenerateColumns = false;

            //Lay du lieu tu DataSet do vao DataGridView
            dgv_spdv.DataSource = lib.reDataSet(sql).Tables[0].DefaultView;
        }
        private void XoaDuLieuTrenForm()
        {
            txt_maspdv.Clear();
            txt_tenspdv.Clear();
            txt_dvt.Clear();
        }

        private void frm_spdv_Load(object sender, EventArgs e)
        {
            HienThiSPDV();
        }

        private void btt_luu_Click(object sender, EventArgs e)
        {
            //Khai bao cac bien lay du lieu nhap tu form
            String ma = txt_maspdv.Text.Trim();
            String ten = txt_tenspdv.Text.Trim();
            String dvt = txt_dvt.Text.Trim();

            //Khai bao chuoi sql
            String sql = "";

            if (flag == true)
            {
                sql += "Insert into spdv Values(N'" + ma + "',N'" + ten + "',N'" + dvt + "')";
            }
            else
            {
                sql += "Update spdv Set tenspdv=N'" + ten + "', dvt=N'" + dvt + "' where maspdv=N'" + ma + "'";
                flag = true;
            }

            //Kiem tra trang lai button Luu
            if (lib.execSQL(sql) == true)
            {
                HienThiSPDV();
                txt_maspdv.Enabled = true;
                XoaDuLieuTrenForm();
                flag = true;
            }
            else
                MessageBox.Show("Lưu không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgv_spdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                //Lay du lieu tu DataGridView hien thi len form
                txt_maspdv.Text = dgv_spdv.CurrentRow.Cells[0].Value.ToString();
                txt_tenspdv.Text = dgv_spdv.CurrentRow.Cells[1].Value.ToString();
                txt_dvt.Text = dgv_spdv.CurrentRow.Cells[2].Value.ToString();

                //Chuyen trang thai cua flag sang update
                flag = false;
                txt_maspdv.Enabled = false;
            }
            else if (e.ColumnIndex == 4)
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    //Khai bao bien lay MANH tu DataGridView
                    String ma = dgv_spdv.CurrentRow.Cells[0].Value.ToString();

                    //Khai bao chuoi sql de xoa du lieu
                    String sql = "Delete From spdv Where maspdv=N'" + ma + "'";

                    //Kiem tra trang thai xoa
                    if (lib.execSQL(sql) == true)
                        HienThiSPDV();
                    else
                        MessageBox.Show("Xoa khong thanh cong.", "QLBH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

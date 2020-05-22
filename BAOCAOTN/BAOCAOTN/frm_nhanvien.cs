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
    public partial class frm_nhanvien : Form
    {
        dungchung lib = new dungchung();
        bool flag = true;
        public frm_nhanvien()
        {
            InitializeComponent();
        }
        private void HienThiChucVu()
        {
            //Tao chuoi sql doc du lieu tu bang NHANVIEN
            String sql = "Select * From chucvu where tencv !='admin' order by macv";
            //Lay du lieu tu DataSet do vao DataGridView
            cbb_chucvu.DataSource = lib.reDataSet(sql).Tables[0].DefaultView;
            cbb_chucvu.DisplayMember = "tencv";
            cbb_chucvu.ValueMember = "macv";
        }
        private void XoaDuLieuTrenForm()
        {
            txt_ma.Clear();
            txt_sdtnv.Clear();
            txt_tennv.Clear();
            txt_dcnv.Clear();
            dtp_namsinh.ResetText();
            HienThiChucVu();
        }
        private void HienThiNhanVien()
        {
            //Tao chuoi sql doc du lieu tu bang NHANVIEN
            String sql = "Select manv, tennv, chucvu.tencv, sdt, namsinh, diachi From nhanvien join chucvu on nhanvien.macv = chucvu.macv where chucvu.macv !='ADMIN'";

            //Tat che do tu dong tao ra Column cua DataGridView
            dgv_nhanvien.AutoGenerateColumns = false;

            //Lay du lieu tu DataSet do vao DataGridView
            dgv_nhanvien.DataSource = lib.reDataSet(sql).Tables[0].DefaultView;
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            HienThiChucVu();
            HienThiNhanVien();
        }

        private void btt_luu_Click(object sender, EventArgs e)
        {
            //Khai bao cac bien lay du lieu nhap tu form
            String ma = txt_ma.Text.Trim();
            String ten = txt_tennv.Text.Trim();
            String chucvu = cbb_chucvu.SelectedValue.ToString();
            String sdt = txt_sdtnv.Text.Trim();
            DateTime dt = Convert.ToDateTime(dtp_namsinh.Text.Trim());
            String ngaySinh = String.Format("{0:MM/dd/yyyy}", dt);
            String dc = txt_dcnv.Text.Trim();
            String mk = lib.cryMD5(ma);

            //Khai bao chuoi sql
            String sql = "";

            if (flag == true)
            {
                sql += "Insert into nhanvien Values(N'" + ma + "',N'" + ten + "',N'" + chucvu + "',N'" + sdt + "','" + ngaySinh + "',N'" + dc + "',N'" + mk + "')";
            }
            else
            {
                sql += "Update nhanvien Set tennv=N'" + ten + "',macv=N'" + chucvu + "',sdt=N'" + sdt + "',namsinh='" + ngaySinh + "',diachi=N'" + dc + "',matkhau=N'" + mk + "' where manv=N'" + ma + "'";
            }

            //Kiem tra trang lai button Luu
            if (lib.execSQL(sql) == true)
            {
                HienThiNhanVien();
                txt_ma.Enabled = true;
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

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                //Lay du lieu tu DataGridView hien thi len form
                txt_ma.Text = dgv_nhanvien.CurrentRow.Cells[0].Value.ToString();
                txt_tennv.Text = dgv_nhanvien.CurrentRow.Cells[1].Value.ToString();
                String cv = dgv_nhanvien.CurrentRow.Cells[2].Value.ToString();
                cbb_chucvu.SelectedIndex = cbb_chucvu.FindString(cv);
                txt_dcnv.Text = dgv_nhanvien.CurrentRow.Cells[5].Value.ToString();
                dtp_namsinh.Text = dgv_nhanvien.CurrentRow.Cells[4].Value.ToString();
                txt_sdtnv.Text = dgv_nhanvien.CurrentRow.Cells[3].Value.ToString();

                //Chuyen trang thai cua flag sang update
                flag = false;
                txt_ma.Enabled = false;
            }
            else if (e.ColumnIndex == 7)
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    //Khai bao bien lay MANH tu DataGridView
                    String ma = dgv_nhanvien.CurrentRow.Cells[0].Value.ToString();

                    //Khai bao chuoi sql de xoa du lieu
                    String sql = "Delete From nhanvien Where MAnv=N'" + ma + "'";

                    //Kiem tra trang thai xoa
                    if (lib.execSQL(sql) == true)
                        HienThiNhanVien();
                    else
                        MessageBox.Show("Xóa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

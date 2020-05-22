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
    public partial class frm_inhoadon : Form
    {
        public frm_inhoadon(String mahd)
        {
            dungchung lib = new dungchung();
            InitializeComponent();
            //KHai bao chuoi sql
            String sql = "Select hoadon.mahd,hoadon.maphieu,nhanvien.tennv,ngaylaphd,spdv.tenspdv,chitiethd.soluong,chitiethd.dongia from (hoadon join nhanvien on hoadon.manv=nhanvien.manv) join chitiethd on hoadon.mahd=chitiethd.mahd join spdv on chitiethd.maspdv=spdv.maspdv where hoadon.mahd='" + mahd + "'";
            crp_hoadon Inhoadon = new crp_hoadon();
            if (lib.reDataSet(sql).Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No data.", "QLBH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Inhoadon.SetDataSource(lib.reDataSet(sql).Tables[0].DefaultView);
            crv_inhoadon.ReportSource = Inhoadon;
        }
    }
}

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
    public partial class frm_bc_pn : Form
    {
        dungchung lib = new dungchung();
        public frm_bc_pn()
        {
            InitializeComponent();
            crp_bc_pn sv = new crp_bc_pn();
            DateTime nnhs = DateTime.Today;
            String ngaynhs = String.Format("{0:MM/dd/yyyy}", nnhs);
            String sql = "Select khachhang.tenkh, maphieu, serisp, tensp, nhanvien.tennv,yeucaukh, ngaynhanhs, ngayhentra, ghichu From phieunhan join nhanvien On phieunhan.manv=nhanvien.manv join khachhang on phieunhan.makh=khachhang.makh where ngaynhanhs='"+ngaynhs+"'";

            if (lib.reDataSet(sql).Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No data", "Reporting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sv.SetDataSource(lib.reDataSet(sql).Tables[0]);
            crystalReportViewer1.ReportSource = sv;
        }
    }
}

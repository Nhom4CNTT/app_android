using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BAOCAOTN
{
    public partial class frm_md5 : Form
    {
        public frm_md5()
        {
            InitializeComponent();
        }
        public String cryMD5(String sData)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();

            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(sData);

            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);

            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));

            return sb.ToString();
        }

        private void btn_doi_Click(object sender, EventArgs e)
        {
            txt_md5.Text = cryMD5(txt_bandau.Text);
        }
    }
}

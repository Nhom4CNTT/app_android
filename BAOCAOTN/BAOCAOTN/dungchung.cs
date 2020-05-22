using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BAOCAOTN
{
    class dungchung
    {
        //Tao chuoi ket noi
        String strConn = "Data Source=.\\SQLEXPRESS; Database=QLSUACHUA;Integrated Security=true";

        //Tao ham xu ly sql dang insert, update, delete
        public bool execSQL(String sql)
        {
            //Tao doi tuong Connection
            SqlConnection conn = new SqlConnection(strConn);

            //Tao doi tuong Command
            SqlCommand comm = new SqlCommand(sql, conn);

            //Kiem tra trang thai thuc thi
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                comm.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        //Tao ham xu ly sql dang select
        public DataSet reDataSet(String sql)
        {
            //Tao doi tuong Connection
            SqlConnection conn = new SqlConnection(strConn);

            //Tao doi tuong DataAdapter
            SqlDataAdapter dA = new SqlDataAdapter(sql, conn);

            //Tao doi tuong DataSet
            DataSet dS = new DataSet();

            //Do du lieu tu DataAdapter sang DataSet
            dA.Fill(dS);

            return dS;
        }


        //Ma hoa MD5
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
    }
}

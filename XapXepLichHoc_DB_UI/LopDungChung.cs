using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XapXepLichHoc_DB_UI
{
    internal class LopDungChung
    {
        string kn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hienl\source\repos\XapXepLichHoc\XapXepLichHoc_DB_UI\SapXepLichHoc.mdf;Integrated Security=True";
        SqlConnection conn;

        public LopDungChung()
        {
            conn = new SqlConnection(kn);
        }

        public DataTable LoadData(string sqlcmd)
        {
            SqlConnection conn = new SqlConnection(kn);
            SqlCommand comm = new SqlCommand(sqlcmd, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void NonQuery(string sqlcmd)
        {
            SqlCommand comm = new SqlCommand(sqlcmd, conn);
            conn.Open();
            try
            {
                int ketqua;
                ketqua = comm.ExecuteNonQuery();
                if (ketqua >= 1)
                    MessageBox.Show("thành công");
                else MessageBox.Show("thất bại");
            }
            catch (Exception E)
            {

                MessageBox.Show("Lỗi cacth: " + E.Message);

            }

            conn.Close();
        }

        public int Scalar(string sqlquery)
        {
            SqlCommand comm = new SqlCommand(sqlquery, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }

        public int Scalar2(string sqlquery)
        {
            SqlCommand comm = new SqlCommand(sqlquery, conn);
            int ketqua;
            try
            {
                conn.Open();
                ketqua = (int)comm.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong quá trình thực hiện câu truy vấn: " + ex.Message);
                ketqua = -1; //-1 để đại diện cho lỗi
            }
            finally
            {
                conn.Close();
            }
            return ketqua;
        }

        public object scalarobj(string sqlquery)
        {
            SqlCommand comm = new SqlCommand( sqlquery, conn);
            conn.Open();
            object obj = comm.ExecuteScalar();
            conn.Close();
            return obj;
        }


    }
}

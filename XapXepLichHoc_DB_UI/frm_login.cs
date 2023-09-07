using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XapXepLichHoc_DB_UI
{
    public partial class frm_login : Form
    {

        LopDungChung lopchung;
        Form1 frm_main = new Form1();
        int count = 0;
        public int CurrentLoggedInAccountId{set; get;}

        public frm_login()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string password = txt_password.Text;

            string sql = $"SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan='{username}' and MatKhau = '{password}'";
            // Lấy mã tài khoản từ cơ sở dữ liệu

            if (lopchung.Scalar(sql) >= 1)
            {
                this.Hide();
                Session.UserId = (int)lopchung.scalarobj($"select MaTaiKhoan from TaiKhoan where TenTaiKhoan = '{username}'");
                Session.UserName = username;
                frm_main.Show();
            }
            else
            {
                MessageBox.Show("Sai Maakt khẩu hoặc tài khoản !!", "Lỗi");
                count++;
                if (count == 3)
                {
                    MessageBox.Show("Nhập sai quá 3 lần, chương trình sẽ tự động thoát !!", "Thông báo");
                    Application.Exit();
                }
            }    
           
        }
        

        private void btn_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_register frm_register = new frm_register();
            frm_register.Show();
        }
    }
}

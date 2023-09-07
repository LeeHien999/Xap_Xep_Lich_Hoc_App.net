using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XapXepLichHoc_DB_UI
{
    public partial class frm_info_account : Form
    {
        LopDungChung lopchung;
        public frm_info_account()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            
        }

        private void loadData()
        {
            string sql = $"select * from SinhVien where TaiKhoan = {Session.UserId}";
            DataTable dt = lopchung.LoadData(sql);
            if(dt.Rows.Count > 0 )
            {
                lb_masv.Text = "Mã sinh viên: " + dt.Rows[0]["MaSinhVien"].ToString();
                lb_tensv.Text = "Tên sinh viên: " + dt.Rows[0]["TenSinhVien"].ToString();
                lb_diachi.Text = "Địa chỉ: " + dt.Rows[0]["Diachi"].ToString();
                lb_khoa.Text = "Khoa: " + dt.Rows[0]["Khoa"].ToString();
                lb_nam.Text = "Năm: " + dt.Rows[0]["Nam"].ToString();
                lb_ngaysinh.Text = "Ngày sinh: " + DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
            }

        }

        private void frm_info_account_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}

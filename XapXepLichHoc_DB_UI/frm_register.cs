using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace XapXepLichHoc_DB_UI
{
    public partial class frm_register : Form
    {
        string kn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hienl\source\repos\XapXepLichHoc\XapXepLichHoc_DB_UI\SapXepLichHoc.mdf;Integrated Security=True";
        LopDungChung lopchung;
        string[] khoas = { "CNTT", "CNTP", "Ngoại ngữ", "Du Lịch", "Bất Động Sản", "Quảng Cáo", "Đa Cấp" };
        frm_login login = new frm_login();
        public frm_register()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            cmb_khoa.Items.AddRange(khoas);
            cmb_khoa.SelectedIndex = 0;
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (txt_ten.Text.Trim().Length > 0 && txt_svnam.Text.Trim().Length > 0 && txt_DiaChi.Text.Trim().Length > 0 && txt_user.Text.Trim().Length > 0 && txt_password.Text.Trim().Length > 0)
            {
                if (int.TryParse(txt_svnam.Text.Trim(), out int n))
                {
                    string maSinhVien = GenerateMaSinhVien();
                    string tenSinhVien = txt_ten.Text;
                    DateTime ngaySinh = dtp_NgaySinh.Value;
                    string khoa = cmb_khoa.Text;
                    int nam = int.Parse(txt_svnam.Text);
                    string diaChi = txt_DiaChi.Text;
                    string tenTaiKhoan = txt_user.Text;
                    string matKhau = txt_password.Text;

                    // Kiểm tra xem tài khoản đã tồn tại hay chưa
                    if (KiemTraTaiKhoanTonTai(tenTaiKhoan))
                    {
                        MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên đăng nhập khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int maTaiKhoan = InsertTaiKhoan(tenTaiKhoan, matKhau);
                    InsertSinhVien(maSinhVien, tenSinhVien, ngaySinh, khoa, nam, diaChi, maTaiKhoan);
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();
                    login.Show();
                }
                else
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho năm", "Cảnh báo");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
            

        }

        private int InsertTaiKhoan(string tenTaiKhoan, string matKhau)
        {
            string insertTaiKhoanQuery = $"INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau) VALUES ('{tenTaiKhoan}', '{matKhau}')";
            int matk = -1; //mặc định giá trị của MaTaiKhoan
            lopchung.NonQuery(insertTaiKhoanQuery);
            //do nó báo lỗi không đóng kết nối hoài dù đã đóng nên em dùng tạm cách này để chống cháy
            using (SqlConnection connection = new SqlConnection(kn))
            {
                connection.Open();
                DataTable dt = lopchung.LoadData($"SELECT MaTaiKhoan FROM TaiKhoan WHERE TenTaiKhoan = '{tenTaiKhoan}' AND MatKhau = '{matKhau}'");

                if (dt.Rows.Count > 0)
                {
                    matk = int.Parse(dt.Rows[0]["MaTaiKhoan"].ToString());
                }
            } 


            return matk;
        }

        private void InsertSinhVien(string maSinhVien, string tenSinhVien, DateTime ngaySinh, string khoa, int nam, string diaChi, int maTaiKhoan)
        {
            string insertSinhVienQuery = $"INSERT INTO SinhVien (MaSinhVien, TenSinhVien, NgaySinh, Khoa, Nam, DiaChi, TaiKhoan) VALUES ('{maSinhVien}', N'{tenSinhVien}', '{ngaySinh:yyyy-MM-dd}', N'{khoa}', {nam}, N'{diaChi}', {maTaiKhoan})";
            lopchung.NonQuery(insertSinhVienQuery);
        }

        private string GenerateMaSinhVien()
        {
            Random random = new Random();
            string maSinhVien = "SV" + random.Next(10000, 99999).ToString();
            return maSinhVien;
        }

        public bool KiemTraTaiKhoanTonTai(string tenTaiKhoan)
        {
            //truy vấn kiểm tra tài khoản đã tồn tại hay chưa
            string query = $"SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = '{tenTaiKhoan}'";
            //kiểm tra từ cơ sở dữ liệu
            int count = lopchung.Scalar(query);
            //count > 0 tài khoản đã tồn tại
            return count > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}

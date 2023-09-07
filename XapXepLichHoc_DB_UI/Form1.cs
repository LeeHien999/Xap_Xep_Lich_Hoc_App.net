using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace XapXepLichHoc_DB_UI
{
    public partial class Form1 : Form
    {
        List<MonHoc> ds = new List<MonHoc>();
        string[] thoigian = { "7:00 - 10:15", "7:00 - 9:00", "9:00 - 10:15", "13:00 - 16:15", "13:00 - 15:00", "15:15 - 17:15", "17:45 - 21:00" };
        string[] thu = { "Thứ 2", "thứ 3", "thứ 4", "thứ 5", "thứ 6", "thứ 7", "Chủ nhật" };
        string[] tinchi = { "1", "2", "3", "4", "5" };
        LopDungChung lopchung;
        public int _maTaiKhoan;

        public Form1()
        {
            InitializeComponent();
            cb_thu.Items.AddRange(thu);
            cb_thu.SelectedIndex = 0;
            cb_thoiGian.Items.AddRange(thoigian);
            cb_thoiGian.SelectedIndex = 0;
            cb_tinChi.Items.AddRange(tinchi);
            cb_tinChi.SelectedIndex = 0;
            lopchung = new LopDungChung();
            loaddsmon();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            _maTaiKhoan = Session.UserId;
            txt_test.Text = "Tài Khoản: " + Session.UserName;
            loaddsmon();
            cb_dsmonhienthi.SelectedIndex = 0;
            loaddschi();
            cb_dstinchi.SelectedIndex = 0;
            loaddsthu();
            cb_dsthu.SelectedIndex = 0;
            loadData();
        }

        private void loadData()
        {

            string sqlcmd = $"SELECT * FROM LichHoc WHERE TaiKhoan = '{_maTaiKhoan}'";
            dataGridView1.DataSource = lopchung.LoadData(sqlcmd);
            dataGridView1.Columns["TaiKhoan"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
            loaddsmon();
            loaddschi();
            loaddsthu();
            txt_tongchi.Text = "Tổng số chỉ: " + TongChi().ToString();
            lb_tongmon.Text = "Tổng Môn: " + TongMon().ToString();
        }

        private int TongChi()
        {
            int sum = 0;
            DataTable dt = lopchung.LoadData($"select distinct MaMonHoc,SoChi from LichHoc where TaiKhoan = '{Session.UserId}'");
            foreach (DataRow row in dt.Rows)
            {
                sum += int.Parse(row["SoChi"].ToString());
            }
            return sum;
        }

        private int TongMon()
        {
            int sum = 0;
            DataTable dt = lopchung.LoadData($"select distinct MaMonHoc from LichHoc where TaiKhoan = '{Session.UserId}'");
            foreach (DataRow row in dt.Rows)
            {
                sum ++;
            }
            return sum;
        }
        private void loaddsmon()
        {
            DataTable dt = lopchung.LoadData($"select distinct MaMonHoc from LichHoc where TaiKhoan = '{Session.UserId}'");
            DataRow newrow = dt.NewRow();
            newrow["MaMonHoc"] = "All";
            dt.Rows.InsertAt(newrow, 0);

            cb_dsmonhienthi.DataSource = dt;
            cb_dsmonhienthi.DisplayMember = "MaMonHoc";
            cb_dsmonhienthi.ValueMember = "MaMonHoc";
        }

        private void loaddschi()
        {
            DataTable dt = lopchung.LoadData($"select distinct SoChi from LichHoc where TaiKhoan = '{Session.UserId}'");
            DataRow newrow = dt.NewRow();
            newrow["SoChi"] = -1; 
            dt.Rows.InsertAt(newrow, 0);

            cb_dstinchi.DataSource = dt;
            cb_dstinchi.DisplayMember = "SoChi";
            cb_dstinchi.ValueMember = "SoChi";
        }

        private void loaddsthu()
        {
            DataTable dt = lopchung.LoadData($"select distinct Thu from LichHoc where TaiKhoan = '{Session.UserId}'");
            DataRow newrow = dt.NewRow();
            newrow["Thu"] = "All";
            dt.Rows.InsertAt(newrow, 0);

            cb_dsthu.DataSource = dt;
            cb_dsthu.DisplayMember = "Thu";
            cb_dsthu.ValueMember = "Thu";
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_mamon.Text.Trim().Length > 0 || txt_weekBegin.Text.Trim().Length > 0 || txt_weekEnd.Text.Trim().Length > 0)
            {
                if (int.TryParse(txt_weekBegin.Text.Trim(), out int a) && int.TryParse(txt_weekEnd.Text.Trim(), out int b))
                {
                    string[] thoigianhoc = cb_thoiGian.SelectedItem.ToString().Split('-');
                    string mamonhoc = txt_mamon.Text;
                    string thuhoc = cb_thu.SelectedItem.ToString();
                    int[] tuanhoc = { int.Parse(txt_weekBegin.Text), int.Parse(txt_weekEnd.Text) };
                    int sotinchi = int.Parse(cb_tinChi.SelectedItem.ToString());

                    //kiểm tra trùng lặp thời gian học trước khi thêm
                    if (!CheckTimeConflict(thuhoc, thoigianhoc[0].Trim(), thoigianhoc[1].Trim(), tuanhoc[0], tuanhoc[1]))
                    {
                        //thêm dữ liệu vào cơ sở dữ liệu
                        string sqlcmd = $"INSERT INTO LichHoc (MaMonHoc, Thu, ThoiGianBatDau, ThoiGianKetThuc, TuanBatDau, TuanKetThuc, SoChi, TaiKhoan) VALUES " +
                                        $"('{mamonhoc}', N'{thuhoc}', '{thoigianhoc[0]}', '{thoigianhoc[1]}', {tuanhoc[0]}, {tuanhoc[1]}, {sotinchi}, {_maTaiKhoan})";
                        lopchung.NonQuery(sqlcmd);
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Trùng lặp thời gian học. Vui lòng kiểm tra lại.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho tuần", "Cảnh báo");
                }
            }
            else
                MessageBox.Show("Vui lòng Nhập đầy đủ trước khi thêm", "Cảnh báo");

        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int selectedId = int.Parse(selectedRow.Cells["Id"].Value.ToString());
                //xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa lịch học này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlcmd = $"DELETE FROM LichHoc WHERE Id = {selectedId}";
                    lopchung.NonQuery(sqlcmd);
                    loadData();
                }
            }
        }


        //Phần cập nhật chưa hoàn thiện vì còn lỗi
        private void btn_update_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string[] thoigianhoc = cb_thoiGian.SelectedItem.ToString().Split('-');
            string mamonhoc = txt_mamon.Text;
            string thuhoc = cb_thu.SelectedItem.ToString();
            int[] tuanhoc = { int.Parse(txt_weekBegin.Text), int.Parse(txt_weekEnd.Text) };
            int sotinchi = int.Parse(cb_tinChi.SelectedItem.ToString());
            int selectedId = int.Parse(selectedRow.Cells["Id"].Value.ToString());

            //kiểm tra trùng lặp thời gian học trước 
            if (!CheckTimeConflict(thuhoc, thoigianhoc[0].Trim(), thoigianhoc[1].Trim(), tuanhoc[0], tuanhoc[1], selectedId))
            {
                //cập nhật dữ liệu vào cơ sở dữ liệu
                string sqlcmd = $"UPDATE LichHoc SET MaMonHoc = '{mamonhoc}', Thu = N'{thuhoc}', ThoiGianBatDau = '{thoigianhoc[0]}', " +
                                $"ThoiGianKetThuc = '{thoigianhoc[1]}', TuanBatDau = {tuanhoc[0]}, TuanKetThuc = {tuanhoc[1]}, SoChi = {sotinchi} WHERE Id = {selectedId}";
                lopchung.NonQuery(sqlcmd);
                loadData();
            }
            else
            {
                MessageBox.Show("Trùng lặp thời gian học. Vui lòng kiểm tra lại.");
            }
        }



        private bool CheckTimeConflict(string thu, string thoiGianBatDau, string thoiGianKetThuc, int tuanBatDau, int tuanKetThuc, int currentId = -1)
        {
            string sqlcmd = $"SELECT * FROM LichHoc WHERE Thu = N'{thu}' AND ((ThoiGianBatDau <= '{thoiGianBatDau}' AND ThoiGianKetThuc >= '{thoiGianBatDau}') OR (ThoiGianBatDau <= '{thoiGianKetThuc}' AND ThoiGianKetThuc >= '{thoiGianKetThuc}')) AND TuanKetThuc >= {tuanBatDau} AND TuanBatDau <= {tuanKetThuc}";
            DataTable dslichhoc = lopchung.LoadData(sqlcmd);

            if (dslichhoc.Rows.Count > 0)
            {
                if (currentId != -1)
                {
                    dslichhoc = dslichhoc.AsEnumerable().Where(row => row.Field<int>("Id") != currentId).CopyToDataTable();
                }
            }

            return dslichhoc.Rows.Count > 0;
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txt_mamon.Text = selectedRow.Cells["MaMonHoc"].Value.ToString();
                cb_thu.SelectedItem = selectedRow.Cells["Thu"].Value.ToString();
                cb_thoiGian.SelectedItem = $"{selectedRow.Cells["ThoiGianBatDau"].Value.ToString()} - {selectedRow.Cells["ThoiGianKetThuc"].Value.ToString()}";
                txt_weekBegin.Text = selectedRow.Cells["TuanBatDau"].Value.ToString();
                txt_weekEnd.Text = selectedRow.Cells["TuanKetThuc"].Value.ToString();
                cb_tinChi.SelectedItem = selectedRow.Cells["SoChi"].Value.ToString();
            }
        }

        private void cb_dsmonhienthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            locdieukien();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_info_account info = new frm_info_account();
            info.Show();
        }

        private void txt_test_Click(object sender, EventArgs e)
        {

        }

        private void locdieukien()
        {
            if (cb_dsmonhienthi.SelectedValue != null && cb_dstinchi.SelectedValue != null && cb_dsthu.SelectedValue != null)
            {
                string selectedMonHoc = cb_dsmonhienthi.SelectedValue.ToString();
                int selectedSoChi;
                if (int.TryParse(cb_dstinchi.SelectedValue.ToString(), out selectedSoChi))
                {
                    string selectedThu = cb_dsthu.SelectedValue.ToString();

                    string sql = $"SELECT * FROM LichHoc WHERE TaiKhoan = '{_maTaiKhoan}'";

                    if (selectedMonHoc != "All")
                    {
                        sql += $" AND MaMonHoc = '{selectedMonHoc}'";
                    }

                    if (selectedSoChi != -1)
                    {
                        sql += $" AND SoChi = {selectedSoChi}";
                    }

                    if (selectedThu != "All")
                    {
                        sql += $" AND Thu = N'{selectedThu}'";
                    }

                    dataGridView1.DataSource = lopchung.LoadData(sql);
                    dataGridView1.Columns["TaiKhoan"].Visible = false;
                    dataGridView1.Columns["Id"].Visible = false;
                }
            }
        }



        private void cb_dstinchi_SelectedIndexChanged(object sender, EventArgs e)
        {
            locdieukien();
        }

        private void cb_dsthu_SelectedIndexChanged(object sender, EventArgs e)
        {
            locdieukien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb_dsmonhienthi.SelectedIndex = 0;
            cb_dstinchi.SelectedIndex = 0;
            cb_dsthu.SelectedIndex = 0;
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHTTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grbHoaDon.Visible = false;
            //grbTimKiem.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static public SqlConnection connectstring = null;
        static public SqlCommand cmd = null;
        static public string stringConnection = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=project_pttk;Integrated Security=True";
        // class data provider
        class DataProvider
        {

            public static SqlConnection Connect(SqlConnection conn)
            {
                conn = new SqlConnection(stringConnection);
                conn.Open();
                return conn;
            }
            public static void Disconnect(SqlConnection conn)
            {
                conn.Close();
            }

            public static SqlDataAdapter getDataAdapter(string proc, string idkh)
            {
                connectstring = new SqlConnection(stringConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(proc, connectstring);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@IDKhachHang", SqlDbType.VarChar).Value = idkh;

                return adapter;
            }
            public static SqlDataReader getDataReader(string proc, string idkh)
            {
                connectstring = DataProvider.Connect(connectstring);
                cmd = new SqlCommand(proc, connectstring);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IDKhachHang", SqlDbType.VarChar).Value = idkh;
                SqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
        }

        //process with table khachhang
        class DAO_KHACHHANG
        {
            public static SqlDataReader DocThongTinKhachHang(string idkh)
            {
                string proc = "sp_getInformationCustomer";
                SqlDataReader reader = DataProvider.getDataReader(proc, idkh);
                return reader;

            }
        }
        class BUS_KHACHHANG
        {
            static public string tenkh = "";
            static public string diachi = "";
            static public string sdt = "";
            static public string sofax = "";

            //tạo hàm trả về các giá trị text box
            public static void LayThongTinKhachHang(string idkh)
            {
                SqlDataReader reader = DAO_KHACHHANG.DocThongTinKhachHang(idkh);
                if (reader.Read())
                {
                    tenkh = (string)reader["tenkh"];
                    diachi = (string)reader["diachi"];
                    sdt = (string)reader["sdt"];
                    sofax = (string)reader["sofax"];

                }
                else
                {
                    MessageBox.Show("Customer does not exist, please try again");
                }

            }
        }

        class DAO_PHONG
        {
            public static SqlDataReader DocThongTinphong(string idkh)
            {
                string proc = "sp_getInformationRoom";
                SqlDataReader reader = DataProvider.getDataReader(proc, idkh);
                return reader;
            }
        }

        class BUS_PHONG
        {
            public static string ngaynhanphong = "";
            public static string ngaytraphong = "";
            public static string loaiphong = "";
            public static string sotiendatra = "";
            public static string tongtien = "";

            public static void LayThongTinPhong(string idkh)
            {
                SqlDataReader reader = DAO_PHONG.DocThongTinphong(idkh);
                int rowIndex = 0; // chỉ đọc dòng thứ 1
                while (reader.Read())
                {
                    if (rowIndex == 0) // chỉ đọc dòng thứ 1
                    {
                        ngaynhanphong = (string)reader["ngayden"];
                        ngaytraphong = (string)reader["ngaytraphong"];
                        loaiphong = (string)reader["loaiphong"];
                        sotiendatra = (string)reader["sotiendatra"];
                        tongtien = (string)reader["tongtien"];
                        break;
                    }
                    rowIndex++;
                }
                reader.Close();
            }

        }

        class DA0_TOURDULICH
        {
            public static SqlDataAdapter DocDanhSachTourDuLich(string idkh)
            {
                string proc = "sp_getInformationTour";
                SqlDataAdapter adapter = DataProvider.getDataAdapter(proc, idkh);
                return adapter;
            }
        }

        class BUS_TOURDULICH
        {
            public static DataTable LayDanhSachTour(string idkh)
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter = DA0_TOURDULICH.DocDanhSachTourDuLich(idkh);
                adapter.Fill(table);
                return table;
            }
        }

        class DAO_DICHVU
        {
            public static SqlDataAdapter DocDanhSachDichVu(string idkh)
            {
                string proc = "sp_getInformationService";
                SqlDataAdapter adapter = DataProvider.getDataAdapter(proc, idkh);
                return adapter;
            }

        }
        class BUS_DICHVU
        {
            public static DataTable LayDanhSachDichVu(string idkh)
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter = DAO_DICHVU.DocDanhSachDichVu(idkh);
                adapter.Fill(table);

                return table;
            }
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            BUS_MHHOADONTHANHTOAN.LuuHoaDon(txtIDKhachHang.Text, txtTongSoTien.Text);
            grbHoaDon.Visible = false;
            grbTimKiem.Visible = true;
        }
        class BUS_MHTIMKIEMTHONGTINKHACHHANG
        {
            public static int HienThiManHinhThongBao(string idkh)
            {
                string proc = "CheckIDExists";
                connectstring = DataProvider.Connect(connectstring);
                cmd = new SqlCommand(proc, connectstring);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IDKhachHang", SqlDbType.VarChar).Value = idkh;
                cmd.Parameters.Add("@Exists", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                bool Result = (bool)cmd.Parameters["@Exists"].Value;
                if (Result)
                {
                    return 1;
                }
                else
                {
                    MessageBox.Show("Customer does not exist, please try again!!!");
                    return 0;
                }

            }
        }
        class BUS_MHHOADONTHANHTOAN
        {
            public static void LuuHoaDon(string idkh, string tongsotien)
            {
               

            }
        }

        private void btnLapHoaDon_Click_1(object sender, EventArgs e)
        {
           
        }

        private void txtIDKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            int index = BUS_MHTIMKIEMTHONGTINKHACHHANG.HienThiManHinhThongBao(txtIDKhachHang.Text);
            if (index == 1)
            {
                grbTimKiem.Visible = false;
                grbHoaDon.Visible = true;
                String idkh = txtIDKhachHang.Text;
                BUS_KHACHHANG.LayThongTinKhachHang(idkh);
                BUS_PHONG.LayThongTinPhong(idkh);
                BUS_DICHVU.LayDanhSachDichVu(idkh);
                BUS_TOURDULICH.LayDanhSachTour(idkh);
                txtTenKhachHang.Text = BUS_KHACHHANG.tenkh;
                txtDiaChi.Text = BUS_KHACHHANG.diachi;
                txtSoDienThoai.Text = BUS_KHACHHANG.sdt;
                txtSoFax.Text = BUS_KHACHHANG.sofax;
                txtNgayNhanPhong.Text = BUS_PHONG.ngaynhanphong;
                txtNgayTraPhong.Text = BUS_PHONG.ngaytraphong;
                txtLoaiPhong.Text = BUS_PHONG.loaiphong;
                txtGiaTien.Text = BUS_PHONG.tongtien;
                dgvDichVu.DataSource = BUS_DICHVU.LayDanhSachDichVu(idkh);
                dgvTourDuLich.DataSource = BUS_TOURDULICH.LayDanhSachTour(idkh);
                txtDaThanhToanTruoc.Text = BUS_PHONG.sotiendatra;
                txtTongSoTien.Text = BUS_PHONG.tongtien;
                int tong = int.Parse(txtTongSoTien.Text);
                for (int i = 0; i < dgvDichVu.Rows.Count; i++)
                {
                    string value = dgvDichVu.Rows[i].Cells["giatien"].Value?.ToString();
                    if (!string.IsNullOrEmpty(value))
                    {
                        tong += int.Parse(value);
                    }
                }
                for (int i = 0; i < dgvTourDuLich.Rows.Count; i++)
                {
                    string value = dgvTourDuLich.Rows[i].Cells["chiphi"].Value?.ToString();
                    if (!string.IsNullOrEmpty(value))
                    {
                        tong += int.Parse(value);
                    }
                }
                txtTongSoTien.Text = tong.ToString();
                txtSoTienCanThanhToan.Text = (int.Parse(txtTongSoTien.Text) - int.Parse(txtDaThanhToanTruoc.Text)).ToString();
            }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string proc = "sp_AddHoaDon";
            connectstring = DataProvider.Connect(connectstring);
            cmd = new SqlCommand(proc, connectstring);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IDKhachHang", SqlDbType.VarChar).Value = txtIDKhachHang.Text;

            cmd.Parameters.Add("@TongTien", SqlDbType.NVarChar).Value = txtTongSoTien.Text;
            try
            {
                cmd.ExecuteNonQuery();
                // Hiển thị thông báo khi thực thi thành công
                MessageBox.Show("Save Successfull!!!");
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây
                MessageBox.Show("Errol Occur: " + ex.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Diagnostics;


namespace DA_PTTK
{
    public partial class MH_TRACUUDICHVU : Form
    {
        class MH_THONGBAO
        {
            private string ChuoiThongBao = "";
            public void CapNhapChuoiThongBao(string ChuoiThongBao)
            {
                this.ChuoiThongBao = ChuoiThongBao;
            }
            public void HienThiThongBao()
            {
                MessageBox.Show(ChuoiThongBao);
            }
        }

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=project_pttk;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void DocDSDichVu(string key)
        {
            command = connection.CreateCommand();
            command.CommandText = $"SELECT iddichvu, tendichvu, mieuta, giatien FROM dichvu where tendichvu like '%{key}%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgDSDichVu.DataSource = table;

        }

        public MH_TRACUUDICHVU()
        {
            InitializeComponent();
        }

        private void MH_TRACUUDICHVU_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            DocDSDichVu("");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text;
            DocDSDichVu(key);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemVaoDSChon_Click(object sender, EventArgs e)
        {
            int i = dtgDSDichVu.CurrentRow.Index;
            string madv = dtgDSDichVu.Rows[i].Cells[0].Value.ToString();
            string tendv = dtgDSDichVu.Rows[i].Cells[1].Value.ToString();
            string mota = dtgDSDichVu.Rows[i].Cells[2].Value.ToString();
            string giatien = dtgDSDichVu.Rows[i].Cells[3].Value.ToString();
            string[] rowData = new string[] { madv, tendv, mota, giatien };

            bool isExist = false;
            foreach (DataGridViewRow row in dtgDSDichVuThucHien.Rows)
            {
                if (row.Cells["colmadv"].Value != null && row.Cells["colmadv"].Value.ToString() == madv)
                {
                    isExist = true;
                    break;
                }
            }
            if (isExist)
            {
                MH_THONGBAO mhThongBao = new MH_THONGBAO();
                mhThongBao.CapNhapChuoiThongBao("Dịch vụ này đã được chọn!");
                mhThongBao.HienThiThongBao();
            }
            else
            {
                dtgDSDichVuThucHien.Rows.Add(rowData);
            }
        }

        private void btnXoaKhoiDSChon_Click(object sender, EventArgs e)
        {
            if (dtgDSDichVuThucHien.Rows.Count > 1)
            {
                int i = dtgDSDichVuThucHien.CurrentRow.Index;
                dtgDSDichVuThucHien.Rows.RemoveAt(i);
            }
        }

        private void dtgDSDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgDSDichVu.CurrentRow.Index;
            txtMoTa.Text = dtgDSDichVu.Rows[i].Cells[2].Value.ToString();

        }

        private void dtgDSDichVuThucHien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDongYChon_Click(object sender, EventArgs e)
        {
            if (dtgDSDichVuThucHien.Rows.Count > 1)
            {
                this.Hide();
                int rowsCount = dtgDSDichVuThucHien.Rows.Count - 1;
                int columnsCount = dtgDSDichVuThucHien.Columns.Count;
                string[,] myArray = new string[rowsCount, columnsCount];

                for (int i = 0; i < rowsCount; i++)
                {
                    for (int j = 0; j < columnsCount; j++)
                    {
                        myArray[i, j] = dtgDSDichVuThucHien.Rows[i].Cells[j].Value.ToString();
                    }
                }

                Form2 form2 = new Form2(myArray);
                form2.ShowDialog();
                form2 = null;
                this.Show();

            }
            else
            {
                MH_THONGBAO mhThongBao = new MH_THONGBAO();
                mhThongBao.CapNhapChuoiThongBao("Phiếu sử dụng dịch vụ phải có tối thiểu một dịch vụ!");
                mhThongBao.HienThiThongBao();
            }
        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

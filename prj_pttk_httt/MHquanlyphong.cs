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

namespace prj_pttk_httt
{
    public partial class MHquanlyphong : Form
    {

        class data_provider
        {
            private SqlConnection _cnn = null;
            private string _sqlstring = "";
            private string _strconnection = "";
            public void inputsqlstring(string sqlstring)
            {
                this._sqlstring = sqlstring;
            }
            public void inputstrconnect(string strconnection)
            {
                this._strconnection = strconnection;
            }
            public string getsqlstring()
            {
                return _sqlstring;
            }
            public SqlConnection getconnect()
            {
                return _cnn;
            }
            public SqlConnection connect()
            {
                this._cnn = new SqlConnection(this._strconnection);
                return this._cnn;
            }
            public void disconnect()
            {
                this._cnn.Close();
            }
            public int executenonquery(SqlCommand command)
            {
                int n = command.ExecuteNonQuery();
                return n;
            }
            public SqlDataAdapter getadapter()
            {
                SqlDataAdapter adapter = new SqlDataAdapter(this._sqlstring, this._cnn);
                return adapter;
            }
        };
        static data_provider _data = new data_provider();

        class MHthongbao
        {
            private string _chuoithongbao = "";
            public void capnhatthongbao(string chuoithongbao)
            {
                this._chuoithongbao = chuoithongbao;
            }
            public void hienthi()
            {
                MessageBox.Show(this._chuoithongbao);
            }
        };

        class dao_phong
        {
            public List<bus_phong> docdsphong(string temp_loaiphong)
            {
                _data.connect().Open();
                _data.inputsqlstring("sp_dsphong");
                SqlDataAdapter adapter = _data.getadapter();
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@loaiphong", SqlDbType.VarChar).Value= temp_loaiphong;
                DataTable table = new DataTable();
                adapter.Fill(table);
                List<bus_phong> list = new List<bus_phong>();
                foreach(DataRow r in table.Rows)
                {
                    string idphong = (string)r["idphong"];
                    string loaiphong = (string)r["loaiphong"];
                    string tinhtrang = (string)r["tinhtrang"];
                    string trangthaidichvu = (string)r["trangthaidichvu"];
                    bus_phong p = new bus_phong(idphong, loaiphong, tinhtrang, trangthaidichvu);
                    list.Add(p);
                }
                _data.disconnect();
                return list;


            }
            public int capnhat(bus_phong busphong)
            {
                _data.connect().Open();
                _data.inputsqlstring("sp_updatephong");
                SqlCommand command = new SqlCommand(_data.getsqlstring());
                command.Connection = _data.getconnect();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@idphong", SqlDbType.VarChar).Value = busphong.Idroom;
                command.Parameters.Add("@loaiphong", SqlDbType.VarChar).Value = busphong.Typeroom;
                command.Parameters.Add("@tinhtrang", SqlDbType.VarChar).Value = busphong.Status;
                command.Parameters.Add("@trangthaidichvu", SqlDbType.VarChar).Value = busphong.Statusservice;
                int n = _data.executenonquery(command);
                _data.disconnect();
                return n;
            }
            public string them(bus_phong busphong)
            {
                _data.connect().Open();
                _data.inputsqlstring("sp_insertphong");
                SqlCommand command = new SqlCommand(_data.getsqlstring());
                command.Connection = _data.getconnect();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@loaiphong", SqlDbType.VarChar).Value = busphong.Typeroom;
                command.Parameters.Add("@tinhtrang", SqlDbType.VarChar).Value = busphong.Status;
                command.Parameters.Add("@trangthaidichvu", SqlDbType.VarChar).Value = busphong.Statusservice;
                command.Parameters.Add("@id", SqlDbType.VarChar,10).Direction = ParameterDirection.Output;
                _data.executenonquery(command);
                string n = (string)command.Parameters["@id"].Value;
                _data.disconnect();
                return n;
            }
            public string xoa(bus_phong busphong)
            {
                _data.connect().Open();
                _data.inputsqlstring("sp_deletephong");
                SqlCommand command = new SqlCommand(_data.getsqlstring());
                command.Connection = _data.getconnect();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@idphong", SqlDbType.VarChar).Value = busphong.Idroom;
                int n = _data.executenonquery(command);
                string m = "0";
                if (n > 0)
                {
                    m = busphong.Idroom;
                }
                _data.disconnect();
                return m;
                
            }
        }

        class bus_phong
        {
            private string _idphong="";
            private string _loaiphong = "";
            private string _tinhtrang = "";
            private string _trangthaidichvu = "";
            public string Idroom
            {
                get { return _idphong; }
                set { _idphong = value; }
            }
            public string Typeroom
            {
                get { return _loaiphong; }
                set { _loaiphong = value; }
            }
            public string Status
            {
                get { return _tinhtrang; }
                set { _tinhtrang = value; }
            }
            public string Statusservice
            {
                get { return _trangthaidichvu; }
                set { _trangthaidichvu = value; }
            }
            public bus_phong(string id,string loaiphong,string tinhtrang,string trangthaidichvu)
            {
                _idphong = id;
                _loaiphong = loaiphong;
                _tinhtrang = tinhtrang;
                _trangthaidichvu = trangthaidichvu;
            }
            public bus_phong()
            {
                _idphong = "";
                _loaiphong = "";
                _tinhtrang = "";
                _trangthaidichvu = "";
            }

            public List<bus_phong> laydsphong(string temp_loaiphong)
            {
                dao_phong daophong = new dao_phong();
                return daophong.docdsphong(temp_loaiphong);
               
            }
            public int capnhatphong(bus_phong busphong)
            {
                dao_phong daophong = new dao_phong();
                return daophong.capnhat(busphong);
            }
            public string themphong(bus_phong busphong)
            {
                dao_phong daophong = new dao_phong();
                return daophong.them(busphong);
            }
            public string xoaphong(bus_phong busphong)
            {
                dao_phong daophong = new dao_phong();
                return daophong.xoa(busphong);
            }
        }

        class bus_quanlyphong
        {
            public bus_phong khoitao(string idphong,string loaiphong,string tinhtrang,string trangthaidichvu) 
            {
                bus_phong p = new bus_phong();
                p.Idroom = idphong;
                p.Typeroom = loaiphong;
                p.Status = tinhtrang;
                p.Statusservice = trangthaidichvu;
                return p;
            }
            public List<bus_phong> hienthi(string loaiphong)
            {
                bus_phong busphong = new bus_phong();
                return busphong.laydsphong(loaiphong);

            }
            public int capnhatthongtin(bus_phong busphong)
            {
                bus_phong busp = new bus_phong();
                return busp.capnhatphong(busphong);
            }
            public string themthongtinphong(bus_phong busphong)
            {
                bus_phong busp = new bus_phong();
                return busp.themphong(busphong);
            }
            public string xoathongtinphong(bus_phong busphong)
            {
                bus_phong busp = new bus_phong();
                return busp.xoaphong(busphong);
            }
        };
       

       
        

        public MHquanlyphong()
        {
            InitializeComponent();
        }
        public MHquanlyphong(string strconnect)
        {
            InitializeComponent();
            _data.inputstrconnect(strconnect);
           
        }

        private void MHquanlyphong_Load(object sender, EventArgs e)
        {
            cbbloaiphong.Text = "all";
            bus_quanlyphong busQuanlyphong = new bus_quanlyphong();
            busQuanlyphong.khoitao(txtidphong.Text, txtloaiphong.Text, txttinhtrang.Text, txttrangthaidichvu.Text);
            List<bus_phong> list=busQuanlyphong.hienthi(cbbloaiphong.Text);
            dgvdsphong.DataSource = list;
            //fill list loaiphong vao combobox
            List<string> cbbloaiphong_temp = new List<string>();
            int n = list.Count();
            int m,count=0;
            cbbloaiphong_temp.Add("all");
            for (int i = 0; i < n; i++)
            {
                m = cbbloaiphong_temp.Count();
                for (int j = 0; j < m; j++)
                {
                    if(cbbloaiphong_temp[j]== list[i].Typeroom)
                    {
                        ++count;
                        break;
                    }
                }
                if (count == 0)
                {
                    cbbloaiphong_temp.Add(list[i].Typeroom);
                }
                count = 0;
            }
            cbbloaiphong.Items.AddRange(cbbloaiphong_temp.ToArray());

            
        }

        public void hienthiMHthongbao(string chuoithongbao)
        {
            MHthongbao thongbao = new MHthongbao();
            thongbao.capnhatthongbao(chuoithongbao);
            thongbao.hienthi();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btninsertphong_Click(object sender, EventArgs e)
        {
            if (txtloaiphong.Text == "" || txttinhtrang.Text == "" || txttrangthaidichvu.Text == "")
            {
                hienthiMHthongbao("not enough information");
            }
            else
            {
                bus_quanlyphong busquanlyphong = new bus_quanlyphong();
                bus_phong busphong = new bus_phong(txtidphong.Text,txtloaiphong.Text,txttinhtrang.Text,txttrangthaidichvu.Text);
                string n = busquanlyphong.themthongtinphong(busphong);
                hienthiMHthongbao("insert "+n+" successfull ");
                txtidphong.Text = "";
                txttinhtrang.Text = "";
                txtloaiphong.Text = "";
                txttrangthaidichvu.Text = "";
                bus_quanlyphong busqlphong = new bus_quanlyphong();

                List<bus_phong> list = busqlphong.hienthi(cbbloaiphong.Text);
                dgvdsphong.DataSource = list;
            }

        }
        //CHON DONG TREN DATAGRID VIEW DO VAO GROUBBOX
        private void dgvdsphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dgvdsphong.Rows[e.RowIndex];
                txtidphong.Text = row.Cells["Idroom"].Value.ToString();
                txtloaiphong.Text = row.Cells["Typeroom"].Value.ToString();
                txttinhtrang.Text = row.Cells["Status"].Value.ToString();
                txttrangthaidichvu.Text = row.Cells["Statusservice"].Value.ToString();
            }
        }

        private void cbbloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            bus_quanlyphong busqlphong = new bus_quanlyphong();

            List<bus_phong> list=busqlphong.hienthi(cbbloaiphong.Text);
            dgvdsphong.DataSource = list;
        }

        private void btnupdatephong_Click(object sender, EventArgs e)
        {
            if (txtidphong.Text == "" || txtloaiphong.Text == "" || txttinhtrang.Text == "" || txttrangthaidichvu.Text == "")
            {
                hienthiMHthongbao("choose row");
            }
            else
            {
                bus_quanlyphong busquanlyphong = new bus_quanlyphong();
                bus_phong busphong = busquanlyphong.khoitao(txtidphong.Text, txtloaiphong.Text, txttinhtrang.Text, txttrangthaidichvu.Text);
 
                int n = busquanlyphong.capnhatthongtin(busphong);
                if (n > 0)
                {
                    hienthiMHthongbao("update successfull");
                }
                txtidphong.Text = "";
                txttinhtrang.Text = "";
                txtloaiphong.Text = "";
                txttrangthaidichvu.Text = "";
                bus_quanlyphong busqlphong = new bus_quanlyphong();

                List<bus_phong> list = busqlphong.hienthi(cbbloaiphong.Text);
                dgvdsphong.DataSource = list;
            }
            
        }

        private void btndeletephong_Click(object sender, EventArgs e)
        {
            if (txtidphong.Text == "" || txtloaiphong.Text == "" || txttinhtrang.Text == "" || txttrangthaidichvu.Text == "")
            {
                hienthiMHthongbao("choose row");
            }
            else
            {
                //hiển thị thông bao chắc chán muốn xóa
                DialogResult result;
                result = MessageBox.Show("are you sure delete it ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    bus_quanlyphong busquanlyphong = new bus_quanlyphong();
                    bus_phong busphong = busquanlyphong.khoitao(txtidphong.Text, txtloaiphong.Text, txttinhtrang.Text, txttrangthaidichvu.Text);

                    string n = busquanlyphong.xoathongtinphong(busphong);
                    hienthiMHthongbao("delete " + n + " successfull");
                    txtidphong.Text = "";
                    txttinhtrang.Text = "";
                    txtloaiphong.Text = "";
                    txttrangthaidichvu.Text = "";
                    bus_quanlyphong busqlphong = new bus_quanlyphong();

                    List<bus_phong> list = busqlphong.hienthi(cbbloaiphong.Text);
                    dgvdsphong.DataSource = list;
                }
                else
                {
                    MessageBox.Show("delete fail");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

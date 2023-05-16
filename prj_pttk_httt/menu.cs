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
using project_PTTK;
using PTTKHTTT;
using DA_PTTK;
namespace prj_pttk_httt
{
    public partial class menu : Form
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
                return this._sqlstring;
            }
            public string getstrconnect()
            {
                return this._strconnection;
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
        }
        static data_provider _data = new data_provider();
        public menu()
        {
            InitializeComponent();
        }

        public menu(string strconnect)
        {
            InitializeComponent();
            _data.inputstrconnect(strconnect);
        }
        private void btnquanlyphong_Click(object sender, EventArgs e)
        {
            this.Hide();
            MHquanlyphong phong = new MHquanlyphong(_data.getstrconnect());
            phong.ShowDialog();
            phong = null;
            this.Show();
        }

        private void btnlapphieuphong_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_lapphieudatphong datphong = new Form_lapphieudatphong();
            datphong.ShowDialog();
            datphong = null;
            this.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 payment = new Form1();
            payment.ShowDialog();
            payment = null;
            this.Show();
        }

        private void btnsearchroom_Click(object sender, EventArgs e)
        {
            this.Hide();
            MH_TRACUUDICHVU dichvu = new MH_TRACUUDICHVU();
            dichvu.ShowDialog();
            dichvu = null;
            this.Show();
        }
    }
}

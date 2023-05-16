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
    public partial class login : Form
    {
        static public SqlCommand command = null;
        static string connectionString ="Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=project_pttk;Integrated Security=True";
        class data_provider
        {
            private SqlConnection _cnn = null;
            private string _sqlstring = "";
            private string _strconnection = "";
            public void inputsqlstring(string sqlstring)
            {
                this._sqlstring = sqlstring;
            }
            public void inputstrconnect (string strconnection)
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
        public login()
        {
            InitializeComponent();
        }

        private void quanlyphong_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                data_provider data = new data_provider();
                data.inputstrconnect(connectionString);
                data.inputsqlstring("sp_login");
                data.connect().Open();
                command = new SqlCommand(data.getsqlstring(),data.getconnect());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = txtuserlogin.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtpasslogin.Text;
                command.Parameters.Add("@check", SqlDbType.VarChar,10).Direction = ParameterDirection.Output;
                data.executenonquery(command);
               
                string check =(string) command.Parameters["@check"].Value;
                if (check == "1")
                {
                    
                    this.Hide();
                    menu m = new menu(data.getstrconnect());
                    m.ShowDialog();
                    m = null;
                    this.Show();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

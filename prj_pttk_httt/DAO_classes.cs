using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DAO_TIER
{
    public class DAO_DATAPROVIDER
    {
        protected SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=project_pttk;Integrated Security=True");
    }



    public class DAO_PHONG : DAO_DATAPROVIDER
    {
        public DataTable DocDS()
        {
            DataTable data = new DataTable();
            data.Columns.Add("idphong", typeof(String));
            data.Columns.Add("loaiphong", typeof(String));
            data.Columns.Add("tinhtrang", typeof(String));

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from phong";
            SqlDataReader reader = cmd.ExecuteReader();
            DataRow row = null;
            while (reader.Read())
            {
                row = data.NewRow();
                row["idphong"] = reader["idphong"];
                row["loaiphong"] = reader["loaiphong"];
                row["tinhtrang"] = reader["tinhtrang"];
                data.Rows.Add(row);
            }
            reader.Close();
            con.Close();

            return data;
        }

        public DataTable DocDS_available(String ngayden, int sodemluutru)
        {
            DataTable data = new DataTable();
            data.Columns.Add("idphong", typeof(String));
            data.Columns.Add("loaiphong", typeof(String));
            data.Columns.Add("tinhtrang", typeof(String));

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText =   String.Format(   "select p.* from phong p where p.tinhtrang = 'clean' "
                                                +"except "
                                                +"select p1.*from phong p1, phieudatphong pdp "
                                                + "where p1.idphong = pdp.idphong and p1.tinhtrang = 'clean' and pdp.ngayden <= dateadd(day,{0},convert(date, '{1}',103))", sodemluutru,ngayden);
            SqlDataReader reader = cmd.ExecuteReader();
            DataRow row = null;
            while (reader.Read())
            {
                row = data.NewRow();
                row["idphong"] = reader["idphong"];
                row["loaiphong"] = reader["loaiphong"];
                row["tinhtrang"] = reader["tinhtrang"];
                data.Rows.Add(row);
            }
            reader.Close();
            con.Close();

            return data;
        }
                
    }



    public class DAO_KHACHHANG : DAO_DATAPROVIDER
    {
        public bool Them(String id, String ten, String sdt, String sofax, String diachi)
        {
            con.Open();

            String sql = String.Format("insert into khachhang values ('{0}', '{1}', '{2}', '{3}', '{4}')", id, ten, sdt, diachi, sofax);

            SqlCommand cmd = new SqlCommand(sql, con);

            int temp = cmd.ExecuteNonQuery();

            con.Close();

            if (temp > 0) return true;
            
            return false;
        }

    }



    public class DAO_DOAN : DAO_DATAPROVIDER
    {
        public bool Them(String iddoan, String ten, String idndk, String songuoi)
        {
            con.Open();

            String sql = String.Format("insert into doan values ('{0}', '{1}', '{2}', '{3}')", iddoan, idndk, songuoi, ten);

            SqlCommand cmd = new SqlCommand(sql, con);

            int temp = cmd.ExecuteNonQuery();

            con.Close();

            if (temp > 0) return true;

            return false;
        }
    }



    public class DAO_PHIEUDATPHONG : DAO_DATAPROVIDER
    {
        public bool Them(String idphieu, String idkhach, String idphong, String ngaydat, String ngayden, String sodemluutru, int tongtien, int sotiendatra)
        {
            con.Open();

            String sql = String.Format("insert into phieudatphong values ('{0}', '{1}', '{2}', NULL, convert(datetime,'{3}',103) , convert(datetime,'{4}',103) , '{5}', '{6}', '{7}')", idphieu, idkhach, idphong, ngaydat, ngayden, sodemluutru, sotiendatra, tongtien);

            SqlCommand cmd = new SqlCommand(sql, con);

            int temp = cmd.ExecuteNonQuery();

            con.Close();

            if (temp > 0) return true;

            return false;
        }
    }

}


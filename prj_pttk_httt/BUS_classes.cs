using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DAO_TIER;

namespace BUS_TIER
{
    public class BUS_PHONG
    {
        DAO_PHONG dao_phong = new DAO_PHONG();

        public Stack<String> LayDSIDPhongTheoLoaiPhong(String loaiphong, String ngayden, int sodemluutru)
        {
            Stack<String> result = new Stack<String>();
            DataTable data = dao_phong.DocDS_available(ngayden, sodemluutru);

            foreach (DataRow row in data.Rows)
            {
                if (row["loaiphong"].ToString()  ==  loaiphong)
                    result.Push(row["idphong"].ToString());
            }

            // reverse
            Stack<String> finalresult = new Stack<String>();
            foreach(String i in result)
            {
                finalresult.Push(i);
            }

            return finalresult;
        }
    }



    public class BUS_KHACHHANG
    {
        DAO_KHACHHANG dao_khachhang = new DAO_KHACHHANG();

        public bool Them(String id, String ten, String sdt, String sofax, String diachi)
        {
            return dao_khachhang.Them(id, ten, sdt, sofax, diachi);
        }
    }



    public class BUS_DOAN
    {
        DAO_DOAN dao_doan = new DAO_DOAN();

        public bool Them(String iddoan, String ten, String songuoi, String idkhach)
        {
            DAO_KHACHHANG temp = new DAO_KHACHHANG();
            return dao_doan.Them(iddoan, ten, idkhach, songuoi);
        }
    }



    public class BUS_PHIEUDATPHONG
    {
        DAO_PHIEUDATPHONG dao_pdp = new DAO_PHIEUDATPHONG();
        int giaphong_standard = 100;
        int giaphong_superior = 200;
        int giaphong_deluxe = 400;

        public bool Them(String idphieu, String idkhach, String idphong, String ngayden, String sodemluutru, String loaiphong)
        {
            String ngaydat = "02/01/2000";
            int sodemolai = Convert.ToInt32(sodemluutru);
            int tongtien = 0;

            if (loaiphong == "deluxe")
                tongtien = sodemolai * giaphong_deluxe;
            else if (loaiphong == "superior")
                tongtien = sodemolai * giaphong_superior;
            else
                tongtien = sodemolai * giaphong_standard;

            int sotiendatra = tongtien * 3 / 10;

            return dao_pdp.Them(idphieu, idkhach, idphong, ngaydat, ngayden, sodemluutru, tongtien, sotiendatra);
        }
    }

}

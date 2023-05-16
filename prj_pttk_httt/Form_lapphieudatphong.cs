using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS_TIER;

namespace project_PTTK
{
    public partial class Form_lapphieudatphong : Form
    {
        //SqlConnection con = null;
        //SqlCommand cmd = null;
        //String conStr = @"Data Source=DESKTOP-0FEH9HT;Initial Catalog=PTTK;Integrated Security=True";

        BUS_PHONG bus_phong = new BUS_PHONG();
        BUS_KHACHHANG bus_khachhang = new BUS_KHACHHANG();
        BUS_DOAN bus_doan = new BUS_DOAN();
        BUS_PHIEUDATPHONG bus_pdp = new BUS_PHIEUDATPHONG();



        public Form_lapphieudatphong()
        {
            InitializeComponent();
        }

        private void Form_lapphieudatphong_Load(object sender, EventArgs e)
        {

        }

        private void checkbox_ditheodoan_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = checkbox_ditheodoan.Checked;
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private bool kiemtra_timphong()
        {
            return ( (checkbox_deluxe.Checked == true && checkbox_superior.Checked == true) || (checkbox_deluxe.Checked == true && checkbox_standard.Checked == true) || (checkbox_superior.Checked == true && checkbox_standard.Checked == true)   ||   ((checkbox_deluxe.Checked == false) && (checkbox_superior.Checked == false) && (checkbox_standard.Checked == false))  ||  (textbox_sodemluutru.Text=="" || textbox_ngayden.Text=="") );
        }
        private void button_timphong_Click(object sender, EventArgs e)
        {
            // if BOTH checkboxes are checked or unchecked
            if (kiemtra_timphong() == true )
            {
                MessageBox.Show("Vui long chon chinh xac 1 loai phong   (va nhap thong tin so dem luu tru, ngay den)");
            }
            else
            {
                try
                {
                    // clean list
                    checkedListBox1.Items.Clear();

                    // lay loai phong
                    String loaiphong;
                    if (checkbox_deluxe.Checked == true)
                        loaiphong = "deluxe";
                    else if (checkbox_superior.Checked == true)
                        loaiphong = "superior";
                    else
                        loaiphong = "standard";

                    // lay mot so thong tin khac
                    String ngayden = textbox_ngayden.Text;
                    int sodemluutru = Convert.ToInt16(textbox_sodemluutru.Text);

                    // lay data (danh sach ten phong theo loai phong)
                    Stack<String> data = bus_phong.LayDSIDPhongTheoLoaiPhong(loaiphong, ngayden, sodemluutru);

                    if (data.Count < 1)
                        MessageBox.Show("Khong tim thay phong phu hop");
                    else
                        foreach (String item in data) checkedListBox1.Items.Add(item, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong... ( Exception: " + ex + " )");
                }
                
            }

            

            
        }


        private bool kiemtra_luuphieu()
        {
            return (    (textbox_idkhach.Text == "" || textbox_hoten.Text == "" || textbox_sdt.Text == "" || textbox_fax.Text == "" || textbox_diachi.Text == "" || textbox_sodemluutru.Text == "" || textbox_ngayden.Text == "" || textbox_idphieu.Text == "") 
                        || (checkbox_ditheodoan.Checked == true && (textbox_iddoan.Text == "" || textbox_tendoan.Text == "" || textbox_songuoi.Text == "")) 
                        || (checkedListBox1.CheckedItems.Count == 0)  );
        }
        private void button_luuphieu_Click(object sender, EventArgs e)
        {
            if (kiemtra_luuphieu() == true)
            {
                MessageBox.Show("Vui long thuc hien nhap day du thong tin");
            }
            else
            {
                try
                {
                    // insert into table KHACHHANG
                    bool kh = bus_khachhang.Them(textbox_idkhach.Text, textbox_hoten.Text, textbox_sdt.Text, textbox_fax.Text, textbox_diachi.Text);

                    // insert into table DOAN
                    bool doan = false;
                    if (checkbox_ditheodoan.Checked == true)
                    {
                        doan = bus_doan.Them(textbox_iddoan.Text, textbox_tendoan.Text, textbox_songuoi.Text, textbox_idkhach.Text);
                    }

                    // insert into table PHIEUDATPHONG
                    Stack<bool> pdp = new Stack<bool>();
                    String loaiphong = "";
                    if (checkbox_deluxe.Checked == true)
                        loaiphong = "deluxe";
                    else if (checkbox_superior.Checked == true)
                        loaiphong = "superior";
                    else
                        loaiphong = "standard";
                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    {
                        String idphong = (String)checkedListBox1.CheckedItems[i];
                        idphong = idphong.Replace(" ", "");
                        bool temp = bus_pdp.Them(textbox_idphieu.Text, textbox_idkhach.Text, idphong, textbox_ngayden.Text, textbox_sodemluutru.Text, loaiphong);
                        pdp.Push(temp);
                    }


                    // final annoucement
                    bool flag_pdp = true;
                    foreach (bool i in pdp)
                    {
                        flag_pdp = i;
                    }
                    if (kh == true && flag_pdp == true && (checkbox_ditheodoan.Checked == false || (checkbox_ditheodoan.Checked == true && doan == true)))
                        MessageBox.Show("Luu thanh cong");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong... ( Exception: " + ex + " )");
                }
                
            }

        }

    }

}

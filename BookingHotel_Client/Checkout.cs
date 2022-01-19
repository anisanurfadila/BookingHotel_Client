using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingHotel_Client
{
    public partial class Checkout : Form
    {

        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();


        ServiceReference2.Service1Client service2 = new ServiceReference2.Service1Client();

        ServiceReference3.Service1Client service3 = new ServiceReference3.Service1Client();



        string constring = "Data Source=DESKTOP-8OQRTV4;Initial Catalog=BookingHotel;Persist Security Info=True; User ID=sa;Password=123";
        SqlConnection connection;
        SqlCommand com;
        string trans_id;
        

        public Checkout(int id_trans)
        {
            InitializeComponent();
            trans_id = id_trans.ToString();
            label12.Text = trans_id;

        }

        public void TampilData()
        {
            var list = service3.GetAllTrans(int.Parse(trans_id));
            dgView.DataSource = list;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            string strs3 = "select * from Trans where id_transaksi = " + trans_id;

            connection = new SqlConnection(constring);
            com = new SqlCommand(strs3, connection);
            connection.Open();
            SqlDataReader readerhari = com.ExecuteReader();
            while (readerhari.Read())
            {
                label11.Text = readerhari["tgl_checkin"].ToString();
                label9.Text = readerhari["nama_pelanggan"].ToString();
                label8.Text = readerhari["ktp_pelanggan"].ToString();
                label7.Text = readerhari["total"].ToString();
                label15.Text = readerhari["total_hari"].ToString();

            }
            //data reader ditutup
            readerhari.Close();
            TampilData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTrans addtrans = new AddTrans();
            this.Hide();
            addtrans.Show();

        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

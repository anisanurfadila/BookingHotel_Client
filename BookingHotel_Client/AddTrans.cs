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
    public partial class AddTrans : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();


        ServiceReference2.Service1Client service2 = new ServiceReference2.Service1Client();

        ServiceReference3.Service1Client service3 = new ServiceReference3.Service1Client();


        string constring = "Data Source=DESKTOP-8OQRTV4;Initial Catalog=BookingHotel;Persist Security Info=True; User ID=sa;Password=123";
        SqlConnection connection;
        SqlCommand com;
        int id_trans;

        public AddTrans()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddTrans_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            string tgl_cekin = dateTimePickerIn.Text;
            string nama = textBoxNama.Text;
            int ktp = int.Parse(textBoxKTP.Text);
            int hari = int.Parse(textBoxHari.Text);

            string a = service3.TambahTransaksi(DateTime.Parse(tgl_cekin) ,nama,ktp,hari);

            if (a == "sukses")
            {
                MessageBox.Show("Sukses nambah transaksi");



                string strs3 = "select max(id_transaksi) 'idtrans' from Trans";
                connection = new SqlConnection(constring);
                com = new SqlCommand(strs3, connection);
                connection.Open();
                SqlDataReader readerid = com.ExecuteReader();
                while (readerid.Read())
                {
                    id_trans = int.Parse(readerid["idtrans"].ToString());

                }
                //data reader ditutup
                readerid.Close();

                DetailTransaksi detTrans= new DetailTransaksi(id_trans);
                this.Hide();
                detTrans.Show();


            }
            else {
                MessageBox.Show("gagal tambah transaksi");
            }
        }

        private void dateTimePickerOut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }
    }
}

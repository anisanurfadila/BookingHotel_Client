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
    public partial class DetailTransaksi : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();


        ServiceReference2.Service1Client service2 = new ServiceReference2.Service1Client();

        ServiceReference3.Service1Client service3 = new ServiceReference3.Service1Client();


        string constring = "Data Source=DESKTOP-8OQRTV4;Initial Catalog=BookingHotel;Persist Security Info=True; User ID=sa;Password=123";
        SqlConnection connection;
        SqlCommand com;
        string trans_id, kamar_id;
        int totalhari, harga;
       int subtotal;
        int id_detail;
        int grandtotal;


        public DetailTransaksi(int id_trans)
        {
            InitializeComponent();
            trans_id = id_trans.ToString();
            labelTrans.Text = trans_id;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            labelDetail.Text = Convert.ToString(dgView.Rows[e.RowIndex].Cells[0].Value);
            textBoxKamar.Text = Convert.ToString(dgView.Rows[e.RowIndex].Cells[2].Value);
            id_detail = int.Parse(labelDetail.Text);

//            btUpdate.Enabled = true;
            button1.Enabled = false;

  //          btSimpan.Enabled = false;
        }

        private void DetailTransaksi_Load(object sender, EventArgs e)
        {
        }

      


        private void button3_Click(object sender, EventArgs e)
        {

            Checkout ck= new Checkout(int.Parse(trans_id));
            this.Hide();
            ck.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
            
        }

        public void TampilData()
        {
            var list = service3.GetAllTrans(int.Parse(trans_id));
            dgView.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kamar_id = textBoxKamar.Text;
                connection = new SqlConnection(constring);


                string strs3 = "select total_hari from Trans where id_transaksi = " + trans_id;

                com = new SqlCommand(strs3, connection);
                connection.Open();
                SqlDataReader readerhari = com.ExecuteReader();
                while (readerhari.Read())
                {
                    totalhari = int.Parse(readerhari["total_hari"].ToString());

                }
                //data reader ditutup
                readerhari.Close();



                //buat query buat cek stok produk
                string strs2 = "select harga from Tipe_Kamar where id_kamar=" + kamar_id;
                SqlCommand sqlCommandharga = new SqlCommand(strs2, connection);
                SqlDataReader readerharga = sqlCommandharga.ExecuteReader();
                ////perulangan untuk membaca data dari query
                while (readerharga.Read())
                {
                    //set value nilai stok dari hasil query
                    harga = int.Parse(readerharga["harga"].ToString());
                    //hitung jumlah kurang
                    subtotal = totalhari * harga;
                }
                //data reader ditutup
                readerharga.Close();
                


                int trans_pars = int.Parse(trans_id);
                int kamar_pars = int.Parse(kamar_id);
                string stharga = harga.ToString();
                string stsub = subtotal.ToString();

                string status = "inprogress";
               

                labelDetail.Text = trans_id ;
            /*    label4.Text = stharga ;
               label5.Text = kamar_id ;
                label6.Text = stsub ;
                 label7.Text = status;*/

                string a = service3.TambahDetailTransaksi(trans_pars, kamar_pars,  subtotal);
                if (a != "sukses")
                {
                    MessageBox.Show("gagal nambah transaksi");

                }
                else
                {
                    MessageBox.Show("sukses tambah transaksi");
                    TampilData();




                    //buat query buat cek stok produk
                    string strtotal = "select sum(subtotal) 'total' from DetailTrans where id_trans=" + trans_id;
                    SqlCommand sqlCommandtotal = new SqlCommand(strtotal, connection);
                    SqlDataReader readertotal = sqlCommandtotal.ExecuteReader();
                    ////perulangan untuk membaca data dari query
                    while (readertotal.Read())
                    {
                        //set value nilai stok dari hasil query
                        grandtotal = int.Parse(readertotal["total"].ToString());
                        //hitung jumlah kurang
                        
                    }
                    //data reader ditutup
                    readertotal.Close();

                    label9.Text = grandtotal.ToString();


                    string sqltotal = "update Trans set total =" + grandtotal + "where id_transaksi =" + trans_id;
                    com = new SqlCommand(sqltotal, connection);
                    com.ExecuteNonQuery();
                    connection.Close();


                }
            }
            catch (Exception exc) {
                MessageBox.Show(exc.ToString()); ;
            }


        }

            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = service3.RemoveDetailTransaksi(id_detail);
            if (a == "sukses hapus")
            {
                MessageBox.Show("Berhasil hapus data transaksi");
                TampilData();
                id_detail = 0;
                button1.Enabled = true;

                kamar_id = textBoxKamar.Text;

                int kamar_pars = int.Parse(kamar_id);
                string sql2 = "update Tipe_Kamar set avaibility = avaibility + " + 1 + " where id_kamar= '" + int.Parse(kamar_id)+ "' ";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql2, connection);
                connection.Open();
                com.ExecuteNonQuery();




                //buat query buat cek stok produk
                string strtotal = "select sum(subtotal) 'total' from DetailTrans where id_trans=" + trans_id;
                SqlCommand sqlCommandtotal = new SqlCommand(strtotal, connection);
                SqlDataReader readertotal = sqlCommandtotal.ExecuteReader();
                ////perulangan untuk membaca data dari query
                while (readertotal.Read())
                {
                    //set value nilai stok dari hasil query
                    grandtotal = int.Parse(readertotal["total"].ToString());
                    //hitung jumlah kurang

                }
                //data reader ditutup
                readertotal.Close();

                label9.Text = grandtotal.ToString();


                string sqltotal = "update Trans set total =" + grandtotal + "where id_transaksi =" + trans_id;
                com = new SqlCommand(sqltotal, connection);
                com.ExecuteNonQuery();
                connection.Close();

            }
            else
            {
                MessageBox.Show("gagal hapus transaksi");
            }
        }
    }
}

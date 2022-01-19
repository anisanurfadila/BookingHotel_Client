using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingHotel_Client
{
    public partial class Register : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();


        ServiceReference2.Service1Client service2 = new ServiceReference2.Service1Client();

        ServiceReference3.Service1Client service3 = new ServiceReference3.Service1Client();


        public Register()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string nama = textBoxNama.Text;
            string a = service3.Register(username, password, nama);

            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxNama.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi.");
            }
            else
            {
                
                Form1 login = new Form1();
                this.Hide();
                login.Show();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }
    }
}

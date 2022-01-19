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
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();


        ServiceReference2.Service1Client service2 = new ServiceReference2.Service1Client();


        ServiceReference3.Service1Client service3 = new ServiceReference3.Service1Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            string nama = service3.Login(username, password);

            if (nama == "")
            {
                MessageBox.Show("Username dan Password Invalid");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
            else {
                AddTrans addtrans = new AddTrans();
                this.Hide();
                addtrans.Show();

            }
           

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            this.Hide();
            reg.Show();
        }
    }
}

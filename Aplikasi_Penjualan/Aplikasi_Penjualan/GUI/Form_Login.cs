using Aplikasi_Penjualan.GUI;
using Aplikasi_Penjualan.Kelas;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Penjualan
{
    public partial class Form_Login : Form
    {
        private Menu_Utama mainForm;

        public Form_Login()
        {
            InitializeComponent();
        }
        public Form_Login(Menu_Utama callingForm)
        {
            mainForm = callingForm;
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            
            //lakukan query select ke database.....
            Users user = new Users();
            if (user.getUser(textBox_username.Text,textBox_Pw.Text))
            {
                //jika akun ditemukan, maka lanjutkan proses login
                mainForm.loginProcess();
                this.Close();
            }
            else
            {
                //jika akun tidak ditemukan , tampilkan pesan login gagal
                MessageBox.Show("login gagal");
            }

            /*
            if (textBox_username.Text=="admin" && textBox_Pw.Text="1234")
            {
                mainForm.loginProcess();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login gagal");
            }
            */

            /*Baca dari db
            //misalkan login sukses, kirimkan pesan ke Form Parent.
            Users user = new Users();

            if (user.getUser(textBox_username.Text, textBox_Pw.Text))
            {
                mainForm.loginProcess();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login gagal");
            }
            */

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            Left = (MdiParent.ClientRectangle.Width - Width) / 2;
            Top = (MdiParent.ClientRectangle.Height - Height) / 2;
        }
    }
}

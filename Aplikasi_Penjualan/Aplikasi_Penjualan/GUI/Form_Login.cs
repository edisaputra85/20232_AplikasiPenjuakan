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
            //1. mengecek apakah username dan password benar
            //jika benar, tampil pesan login berhasil, aktifkan menu dan tutup form login
            Users user = new Users();
            if (user.getUser(textBox_username.Text,textBox_Pw.Text)) 
            {
                MessageBox.Show("Login berhasil");
                mainForm.loginProcess();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login gagal");
                textBox_username.Text = string.Empty;
                textBox_Pw.Text = string.Empty; 
            }

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            Left = (MdiParent.ClientRectangle.Width - Width) / 2;
            Top = (MdiParent.ClientRectangle.Height - Height) / 2;
        }
    }
}

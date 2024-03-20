using Aplikasi_Penjualan.GUI;
using Aplikasi_Penjualan.Kelas;
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

        public Form_Login(Menu_Utama callingForm)
        {
            mainForm = callingForm;
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
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

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Penjualan.GUI
{
    public partial class Menu_Utama : Form
    {
        private int childFormNumber = 0;
        Form_Login frmLogin;

        protected override void OnResize(EventArgs e)
        {
            CenterForms();
            base.OnResize(e);
        }
        private void CenterForms()
        {
            foreach (var form in MdiChildren) //This will center all of the Child Forms
            {
                form.Left = (ClientRectangle.Width - form.Width) / 2;
                form.Top = (ClientRectangle.Height - form.Height) / 2;
            }

        }
        
        void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin = null;
        }
        

        bool _loginState;

        public Menu_Utama()
        {
            InitializeComponent();
            _loginState = false;
            toolStripStatusLabel.Text = "Not Login";
            submenu_logout.Enabled = false;
        }
        public void enableMenuMasterData()
        {
            menu_masterdata.Enabled = true;
        }

        private void submenu_login_Click(object sender, EventArgs e)
        {
            //menampilkan form login
            if (frmLogin == null)
            {
                //1. membuat objek dari form login
                frmLogin = new Form_Login(this);
                //2. mengkaitkan objek form login dengan MDI parent
                frmLogin.MdiParent = this;
                frmLogin.FormClosed += new FormClosedEventHandler(frmLogin_FormClosed);
                //3. menampilkan form login
                frmLogin.Show();
            }
            else
            {
                frmLogin.Activate();
            }
            
            
            
            /*
            if (frmLogin == null)
            {
                frmLogin = new Form_Login(this);
                frmLogin.MdiParent = this;
                frmLogin.FormClosed += new FormClosedEventHandler(frmLogin_FormClosed);
                frmLogin.Show();
            }
            else
            {
                frmLogin.Activate();
            }
            */
        }

        private void Menu_Utama_Load(object sender, EventArgs e)
        {

        }

        private void submenu_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                logoutProcess();

            }
        }
        private void logoutProcess()
        {
            _loginState = false;
            toolStripStatusLabel.Text = "Not Login";
            menu_masterdata.Enabled = false;
            submenu_login.Enabled = true;
            submenu_logout.Enabled = false;
        }
        public void loginProcess()
        {
            //_loginState = true;
            toolStripStatusLabel.Text = "Login";
            menu_masterdata.Enabled = true;
            menu_pengaturan.Enabled = true;
            menu_transaksi.Enabled = true;
            submenu_logout.Enabled = true;
            submenu_login.Enabled = false;
        }

        private void submenu_keluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void subMenuDataBarang_Click(object sender, EventArgs e)
        {

        }
    }
}

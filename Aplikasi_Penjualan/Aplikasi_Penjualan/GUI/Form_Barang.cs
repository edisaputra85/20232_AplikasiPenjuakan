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

namespace Aplikasi_Penjualan.GUI
{
    public partial class Form_Barang : Form
    {
        public Form_Barang()
        {
            InitializeComponent();
            textBoxKodeBarang.Enabled = false;
            textBoxNamaBarang.Enabled = false;
            textBoxhargaBarang.Enabled = false;
            textBoxStokBarang.Enabled = false;
            comboBoxSatuan.Enabled = false;
            buttonSimpan.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Barang_Load(object sender, EventArgs e)
        {
            loadBarang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Barangs barang = new Barangs(textBoxKodeBarang.Text, textBoxNamaBarang.Text,
                Convert.ToInt32(textBoxhargaBarang.Text), Convert.ToInt16(textBoxStokBarang.Text), comboBoxSatuan.Text);
            if (barang.insert() == 1)
            {
                MessageBox.Show("Insert barang sukses");
            }
            else
            {
                MessageBox.Show("Insert barang gagal");
            }
            loadBarang();
        }

        private void buttonBaru_Click(object sender, EventArgs e)
        {
            baru();
        }
        private void baru()
        {
            textBoxKodeBarang.Enabled = true;
            textBoxNamaBarang.Enabled = true;
            textBoxhargaBarang.Enabled = true;
            textBoxStokBarang.Enabled = true;
            comboBoxSatuan.Enabled = true;

            textBoxKodeBarang.Text = string.Empty;
            textBoxNamaBarang.Text = string.Empty;
            textBoxhargaBarang.Text = string.Empty;
            textBoxStokBarang.Text = string.Empty;
            comboBoxSatuan.Text = string.Empty;

            buttonSimpan.Enabled = true;
        }

        private void loadBarang()
        {
            DataTable dt = new DataTable();
            dt = Barangs.SelectAll();
            dgvDataBarang.AutoGenerateColumns = false;
            dgvDataBarang.DataSource = dt;
            dgvDataBarang.Show();
        }

        private void searchBarang()
        {
            DataTable dt = new DataTable();
            dt = Barangs.search(textBoxSearch.Text);
            dgvDataBarang.AutoGenerateColumns = false;
            dgvDataBarang.DataSource = dt;
            dgvDataBarang.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            searchBarang();
        }
    }
}

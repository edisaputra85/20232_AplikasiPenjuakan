using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Penjualan.Kelas
{
    internal class Barangs
    {
        protected const String conString = "server=localhost;database=db_penjualan_app;uid=root;pwd=;";
        string kode;
        string nama;
        int harga;
        int stok;
        string satuan;

        public Barangs(string kode,string nama,int harga,int stok,string satuan)
        {
            this.kode = kode;   
            this.nama = nama;
            this.harga = harga;
            this.stok = stok;
            this.satuan = satuan;
        }
        public int insert()
        {
            int result=0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO barangs (kode,nama,harga,stok,satuan) VALUES(@kode,@nama,@harga,@stok,@satuan)");
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@stok", stok);
            cmd.Parameters.AddWithValue("@satuan", satuan);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
          return result;
        }
    }
}

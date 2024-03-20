using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Aplikasi_Penjualan.Kelas
{
    internal class Users
    {
        protected const String conString = "server=localhost;database=db_penjualan_app;uid=root;pwd=;";
        public bool getUser(string usr, string pwd)
        {
            bool val = false;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username='" +
                usr + "' AND password='" + pwd + "'");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            
            try
            {
                connect.Open();
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    val = true;
                }
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
            return val;
        }
    }
}

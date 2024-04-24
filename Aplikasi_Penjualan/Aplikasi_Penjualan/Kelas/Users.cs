using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace Aplikasi_Penjualan.Kelas
{
    internal class Users
    {
        protected const String conString = "server=localhost;database=db_penjualan_app;uid=root;pwd=;";
        //method getUser: method untuk mengecek apakah usr dan pwd tertentu ada di tabel users
        //apabila usr dan pwd ditemukan, maka method getUser akan mengembalikan nilai boolean true;
        public bool getUser(string usr, string pwd)
        {
            bool result = false;
            MySqlConnection connect = new MySqlConnection(conString);//membuat objek untuk koneksi ke mysql
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username = @user && password = @pwd", connect);
            cmd.Parameters.AddWithValue("@user", usr);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.CommandType = CommandType.Text;
            //cmd.Connection = connect;
            try
            {
                connect.Open();
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    result = true;
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
            return result;
        }
    }
}

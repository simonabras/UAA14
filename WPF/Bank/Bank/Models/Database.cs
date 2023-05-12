using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Bank.Models
{
    class Database
    {
        public string ConnectionString()
        {
            return "Server=localhost;Database=bank;port=3306;User Id=root";
        }

        public DataSet Login(string login, string password)
        {
            MySqlConnection myConnection = new MySqlConnection(ConnectionString());
            try
            {
                myConnection.Open();
                DataSet ds = new DataSet();
                string query = "SELECT * FROM accounts WHERE account_login=\"" + login + "\"AND account_password=\"" + password + "\"";
                MySqlDataAdapter data = new MySqlDataAdapter(query, myConnection);
                data.Fill(ds, "data");
                int id = (int)ds.Tables[0].Rows[0]["account_id"];
                int number = (int)ds.Tables[0].Rows[0]["account_number"];
                int balance = (int)ds.Tables[0].Rows[0]["account_balance"];
                string account_login = ds.Tables[0].Rows[0]["account_login"].ToString();
                string account_password = ds.Tables[0].Rows[0]["account_password"].ToString();
                myConnection.Close();
                return ds;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
        }
    }
}

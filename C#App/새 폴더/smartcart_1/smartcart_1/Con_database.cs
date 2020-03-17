using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace smartcart_1
{
    class Con_database
    {
        static string server = "http://oaoopw.dothome.co.kr";
        static string database = "oaoopw";
        static string uid = "oaoopw";
        static string password = "kara1136!";
        string connectionString;
        public static string constring1 = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        MySqlConnection conn = new MySqlConnection();
        private string sConnString = "";
        public void ConnectDB()
        {
            try
            {
                sConnString = constring1;
            }
            catch
            {

            }
            if (conn.State.ToString().Equals("Closed"))
            {
                conn.ConnectionString = sConnString;
                conn.Open();
            }
        }

        public void CloseDB()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        public DataTable GetDBTable(string sql)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace smartcart_1
{
    public partial class ProductOrder : Form
    {
        public ProductOrder()
        {
            InitializeComponent();
        }

        private void ProductOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("주문되었습니다.", "관리자");
            //Dispose(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소되었습니다.", "관리자");
            //Dispose(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runQuery();
        }
        private void runQuery()
        {
            string query = textBox1.Text;

            if(query == "")
            {
                MessageBox.Show("Please insert some sql query !");
                return;
            }

            string MySQLConnectionString = "server=http://oaoopw.dathome.co.kr; uid=oaoopw; password=kara1136!; database=oaoopw;";
            //string MySQLConnectionString = "server=localhost;uid=root;password=apmsetup;database=smartcart;";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if(myReader.HasRows)
                {
                    MessageBox.Show("Your query generated results, please see the console");

                    while (myReader.Read())
                    {
                                          //ID                            first_name                   last_name                         address
                        Console.WriteLine(myReader.GetString(0) + " - " + myReader.GetString(1) + " - " + myReader.GetString(2) + " - " + myReader.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("Query successfully executed");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Query error: " + e.Message);
            }
        }

    }
    
}

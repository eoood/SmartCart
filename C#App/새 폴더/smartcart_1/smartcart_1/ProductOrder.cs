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
        //콤보박스
        public void FillComboName()
        {
            string constring = "server = oaoopw.dothome.co.kr; database=oaoopw; username=oaoopw; password=kara1136!;";
            string Query = "select name from Product";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                while(myReader.Read())
                {
                    string sName = myReader.GetString("name");
                    cbBoxPdName.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        public ProductOrder()
        {
            InitializeComponent();
            FillComboName();
        }

        private void ProductOrder_Load(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.FromArgb(51, 153, 255);
            btnCancel.BackColor = Color.FromArgb(51, 153, 255);

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("주문되었습니다.", "관리자");
            var a = cbBoxPdName.SelectedItem;

            //string constring = "datasource = localhost;username=root;password=apmsetup;database=smartcart;";
            ////string Query = "INSERT INTO product (`name`, `price`, `quantity`) VALUES ({0}, '7000', '20')"(cbBoxPdName);
            //MySqlConnection conDataBase = new MySqlConnection(constring);
            ////MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            //MySqlDataReader myReader;
            //try
            //{
            //    conDataBase.Open();
            //    myReader = cmdDatabase.ExecuteReader();
            //    while (myReader.Read())
            //    {
            //        string sName = myReader.GetString("name");
            //        cbBoxPdName.Items.Add(sName);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //Dispose(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소되었습니다.", "관리자");
            //Dispose(true);
        }

        private void cbBoxPdName_SelectedIndexChanged(object sender, EventArgs e)
        {
                  
        }

        private void cbBoxPdName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
    }
    
}

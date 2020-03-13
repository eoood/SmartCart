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
    public partial class Main : Form
    {
        Login loginForm;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //첫 화면 배경색 지정
            btnLogout.BackColor = Color.FromArgb(64, 64, 64);
            label1.BackColor = Color.FromArgb(64, 64, 64);
            btnPdOrder.BackColor = Color.FromArgb(51, 153, 255);
            btnPdMdfy.BackColor = Color.FromArgb(51, 153, 255);
            btnPdDel.BackColor = Color.FromArgb(51, 153, 255);
            btnMemMdfy.BackColor = Color.FromArgb(51, 153, 255);
            btnMemDel.BackColor = Color.FromArgb(51, 153, 255);
            btnSalesChart.BackColor = Color.FromArgb(51, 153, 255);
            btnPdChart.BackColor = Color.FromArgb(51, 153, 255);
            btnInbound.BackColor = Color.FromArgb(51, 153, 255);
            btnOutbound.BackColor = Color.FromArgb(51, 153, 255);

            //로그인창 띄우기
            loginForm = new Login();
            loginForm.loginEventHandler += new EventHandler(LoginSuccess);
            switch (loginForm.ShowDialog())
            {
                case DialogResult.OK:
                    loginForm.Close();
                    break;
                case DialogResult.Cancel:
                    Dispose();
                    break;
            }
            //첫 화면 datagridview에 카트 테이블 생성
            DataTable cartTbl = new DataTable();

            // column을 추가합니다.
            cartTbl.Columns.Add("카트번호", typeof(int));
            cartTbl.Columns.Add("카트고유ID", typeof(string));
            cartTbl.Columns.Add("사용자 사용 현황", typeof(string));

            // 각각의 행에 내용을 입력합니다.
            cartTbl.Rows.Add("1", "1234", null);
            cartTbl.Rows.Add("2", "5678", null);
            cartTbl.Rows.Add("3", "9012", "박대원");

            // 값들이 입력된 테이블을 DataGridView에 입력합니다.
            dataGridView1.DataSource = cartTbl;

            btnCart.BackColor = Color.FromArgb(255, 192, 192);
            btnProduct.BackColor = Color.FromArgb(51,153,255); 
            btnMember.BackColor = Color.FromArgb(51, 153, 255); 
            btnIbob.BackColor = Color.FromArgb(51, 153, 255); 
            btnSales.BackColor = Color.FromArgb(51, 153, 255); 

            //매출 그래프 series 값
            Random rand = new Random();
            for (int i = 0; i < 12; i++)
            {
                int cnt = i + 1;

                chartSales.Series[0].Points.AddXY(cnt + "월", rand.Next(300, 500));
                chartSales.Series[1].Points.AddXY(cnt + "월", rand.Next(100, 500));
                chartSales.Series[2].Points.AddXY(cnt + "월", rand.Next(400, 500));
                chartSales.Series[3].Points.AddXY(cnt + "월", rand.Next(100, 500));
                chartSales.Series[4].Points.AddXY(cnt + "월", rand.Next(200, 500));

                chartSales2.Series[0].Points.AddXY(cnt + "월", rand.Next(1000, 5000));

                
            }
        }

        //로그인 생성 시 메시지박스 띄우기
        private void LoginSuccess(string userName)
        {
            MessageBox.Show(userName + "님이 로그인하셨습니다.");
            LblLogname.Text = userName + "님";
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            DataTable cartTbl = new DataTable();

            // column을 추가합니다.
            cartTbl.Columns.Add("카트번호", typeof(int));
            cartTbl.Columns.Add("카트고유ID", typeof(string));
            cartTbl.Columns.Add("사용자 사용 현황", typeof(string));

            // 각각의 행에 내용을 입력합니다.
            cartTbl.Rows.Add("1", "1234", null);
            cartTbl.Rows.Add("2", "5678", null);
            cartTbl.Rows.Add("3", "9012", "박대원");

            // 값들이 입력된 테이블을 DataGridView에 입력합니다.
            dataGridView1.DataSource = cartTbl;

            chartSales.Visible = false;
            chartSales2.Visible = false;

            btnCart.BackColor = Color.FromArgb(255, 192, 192);            
            btnProduct.BackColor = Color.FromArgb(51, 153, 255);
            btnMember.BackColor = Color.FromArgb(51, 153, 255);
            btnIbob.BackColor = Color.FromArgb(51, 153, 255);
            btnSales.BackColor = Color.FromArgb(51, 153, 255);

            btnInbound.Visible = false;
            btnOutbound.Visible = false;
            btnMemRegis.Visible = false;
            btnMemMdfy.Visible = false;
            btnMemDel.Visible = false;
            btnPdOrder.Visible = false;
            btnPdMdfy.Visible = false;
            btnPdDel.Visible = false;
            btnPdChart.Visible = false;
            btnSalesChart.Visible = false;
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            DataTable memberTbl = new DataTable();

            // column을 추가합니다.
            memberTbl.Columns.Add("회원번호", typeof(int));
            memberTbl.Columns.Add("회원이름", typeof(string));
            memberTbl.Columns.Add("성별", typeof(string));
            memberTbl.Columns.Add("나이", typeof(int));
            memberTbl.Columns.Add("폰번호", typeof(string));

            // 각각의 행에 내용을 입력합니다.
            memberTbl.Rows.Add("1", "송찬호", "남", "26", "010-4526-5594");
            memberTbl.Rows.Add("2", "한수정", "여", "25", "010-4223-1345");
            memberTbl.Rows.Add("3", "박대원", "남", "26", "010-4113-5223");
            memberTbl.Rows.Add("4", "장혁진", "남", "26", "010-4444-5213");
            memberTbl.Rows.Add("5", "어동규", "남", "27", "010-4133-1234");

            // 값들이 입력된 테이블을 DataGridView에 입력합니다.
            dataGridView1.DataSource = memberTbl;

            chartSales.Visible = false;
            chartSales2.Visible = false;

            btnMember.BackColor = Color.FromArgb(255, 192, 192);
            btnProduct.BackColor = Color.FromArgb(51, 153, 255); ;
            btnCart.BackColor = Color.FromArgb(51, 153, 255); ;
            btnIbob.BackColor = Color.FromArgb(51, 153, 255); ;
            btnSales.BackColor = Color.FromArgb(51, 153, 255); ;

            btnInbound.Visible = false;
            btnOutbound.Visible = false;
            //btnMemRegis.Visible = true;
            btnMemMdfy.Visible = true;
            btnMemDel.Visible = true;
            btnPdOrder.Visible = false;
            btnPdMdfy.Visible = false;
            btnPdDel.Visible = false;
            btnPdChart.Visible = false;
            btnSalesChart.Visible = false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            DataTable productTbl = new DataTable();

            // column을 추가합니다.
            productTbl.Columns.Add("상품번호", typeof(int));
            productTbl.Columns.Add("상품 명", typeof(string));
            productTbl.Columns.Add("가격", typeof(int));
            productTbl.Columns.Add("수량", typeof(int));

            // 각각의 행에 내용을 입력합니다.
            productTbl.Rows.Add("1", "레몬", "3000", "30");
            productTbl.Rows.Add("2", "수박", "5500", "25");
            productTbl.Rows.Add("3", "딸기", "7000", "6");
            productTbl.Rows.Add("4", "바나나", "3500", "9");

            // 값들이 입력된 테이블을 DataGridView에 입력합니다.
            dataGridView1.DataSource = productTbl;

            chartSales.Visible = false;
            chartSales2.Visible = false;

            btnProduct.BackColor = Color.FromArgb(255, 192, 192);
            btnMember.BackColor = Color.FromArgb(51, 153, 255); ;
            btnCart.BackColor = Color.FromArgb(51, 153, 255); ;
            btnIbob.BackColor = Color.FromArgb(51, 153, 255); ;
            btnSales.BackColor = Color.FromArgb(51, 153, 255); ;

            btnInbound.Visible = false;
            btnOutbound.Visible = false;
            btnPdOrder.Visible = true;
            btnPdMdfy.Visible = true;
            btnPdDel.Visible = true;
            btnMemRegis.Visible = false;
            btnMemMdfy.Visible = false;
            btnMemDel.Visible = false;
            btnPdChart.Visible = false;
            btnSalesChart.Visible = false;
        }

        private void btnInoutgo_Click(object sender, EventArgs e)
        {
            DataTable inoutgoTbl = new DataTable();

            Random rand2 = new Random();
            Random rand1 = new Random();
            int num1;

            string IBOB;
            
            int num2 = rand1.Next(1, 4);
            string Product;
            
            // column을 추가합니다.
            inoutgoTbl.Columns.Add("날짜", typeof(string));
            inoutgoTbl.Columns.Add("상품명", typeof(string));
            inoutgoTbl.Columns.Add("수량", typeof(int));
            inoutgoTbl.Columns.Add("입출고", typeof(string));

            // 각각의 행에 내용을 입력합니다.
            for (int i = 0; i < 50; i++)
            {
                num1 = rand1.Next(0, 10) % 2;
                num2 = rand1.Next(1, 4);
                if (num1 == 0)
                {
                    num1 = -1;
                }
                else
                {
                    num1 = 1;
                }
                if (num1 < 0)
                {
                    IBOB = "출고";
                }
                else
                {
                    IBOB = "입고";
                }
                if (num2 == 1)
                {
                    Product = "바나나";
                }
                else if (num2 == 2)
                {
                    Product = "딸기";
                }
                else if (num2 == 3)
                {
                    Product = "메론";
                }
                else
                {
                    Product = "참외";
                }

                inoutgoTbl.Rows.Add("2020/03/" + (i + 1), Product, "" + rand2.Next(10, 50) * num1, IBOB);
            }

            // 값들이 입력된 테이블을 DataGridView에 입력합니다.
            dataGridView1.DataSource = inoutgoTbl;

            btnIbob.BackColor = Color.FromArgb(255, 192, 192);
            btnProduct.BackColor = Color.FromArgb(51, 153, 255); ;
            btnMember.BackColor = Color.FromArgb(51, 153, 255); ;
            btnCart.BackColor = Color.FromArgb(51, 153, 255); ;
            btnSales.BackColor = Color.FromArgb(51, 153, 255); ;

            chartSales.Visible = false;
            chartSales2.Visible = false;
            btnInbound.Visible = true;
            btnOutbound.Visible = true;
            btnMemRegis.Visible = false;
            btnMemMdfy.Visible = false;
            btnMemDel.Visible = false;
            btnPdOrder.Visible = false;
            btnPdMdfy.Visible = false;
            btnPdDel.Visible = false;
            btnPdChart.Visible = false;
            btnSalesChart.Visible = false;



        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            chartSales2.Visible = true;

            btnSales.BackColor = Color.FromArgb(255, 192, 192);
            btnProduct.BackColor = Color.FromArgb(51, 153, 255);
            btnMember.BackColor = Color.FromArgb(51, 153, 255); ;
            btnCart.BackColor = Color.FromArgb(51, 153, 255); ;
            btnIbob.BackColor = Color.FromArgb(51, 153, 255); ;

            btnInbound.Visible = false;
            btnOutbound.Visible = false;
            btnMemRegis.Visible = false;
            btnMemMdfy.Visible = false;
            btnMemDel.Visible = false;
            btnPdOrder.Visible = false;
            btnPdMdfy.Visible = false;
            btnPdDel.Visible = false;
            btnPdChart.Visible = true;
            btnSalesChart.Visible = true;
        }

        private void chartSales_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnInbound_Click(object sender, EventArgs e)
        {
            DataTable ingoTbl = new DataTable();

            Random rand2 = new Random();
            Random rand1 = new Random();
            int num1;

            string IBOB;

            int num2 = rand1.Next(1, 4);
            string Product;

                        
            // column을 추가합니다.
            ingoTbl.Columns.Add("날짜", typeof(string));
            ingoTbl.Columns.Add("상품명", typeof(string));
            ingoTbl.Columns.Add("수량", typeof(int));
            ingoTbl.Columns.Add("입출고", typeof(string));

            // 각각의 행에 내용을 입력합니다.
            for (int i = 0; i < 50; i++)
            {
                num1 = rand1.Next(0, 10) % 2;
                num2 = rand1.Next(1, 4);
                if (num1 == 0)
                {
                    num1 = -1;
                }
                else
                {
                    num1 = 1;
                }
                if (num1 < 0)
                {
                    IBOB = "출고";
                }
                else
                {
                    IBOB = "입고";
                }
                if (num2 == 1)
                {
                    Product = "바나나";
                }
                else if (num2 == 2)
                {
                    Product = "딸기";
                }
                else if (num2 == 3)
                {
                    Product = "메론";
                }
                else
                {
                    Product = "참외";
                }
                if (IBOB == "입고")
                {
                    ingoTbl.Rows.Add("2020/03/" + (i + 1), Product, "" + rand2.Next(10, 50) * num1, IBOB);
                }
            }
                dataGridView1.DataSource = ingoTbl;

            }

        private void btnOutbound_Click(object sender, EventArgs e)
        {
            DataTable outgoTbl = new DataTable();

            Random rand2 = new Random();
            Random rand1 = new Random();
            int num1;

            string IBOB;


            int num2 = rand1.Next(1, 4);
            string Product;


            // column을 추가합니다.
            outgoTbl.Columns.Add("날짜", typeof(string));
            outgoTbl.Columns.Add("상품명", typeof(string));
            outgoTbl.Columns.Add("수량", typeof(int));
            outgoTbl.Columns.Add("입출고", typeof(string));

            // 각각의 행에 내용을 입력합니다.
            for (int i = 0; i < 50; i++)
            {
                num1 = rand1.Next(0, 10) % 2;
                num2 = rand1.Next(1, 4);
                if (num1 == 0)
                {
                    num1 = -1;
                }
                else
                {
                    num1 = 1;
                }
                if (num1 < 0)
                {
                    IBOB = "출고";
                }
                else
                {
                    IBOB = "입고";
                }
                if (num2 == 1)
                {
                    Product = "바나나";
                }
                else if (num2 == 2)
                {
                    Product = "딸기";
                }
                else if (num2 == 3)
                {
                    Product = "메론";
                }
                else
                {
                    Product = "참외";
                }
                if (IBOB == "출고")
                {
                    outgoTbl.Rows.Add("2020/03/" + (i + 1), Product, "" + rand2.Next(10, 50) * num1, IBOB);
                }
            }
            dataGridView1.DataSource = outgoTbl;
        }

        private void btnSalesChart_Click(object sender, EventArgs e)
        {
            chartSales.Visible = false;
            chartSales2.Visible = true;
        }

        private void btnPdChart_Click(object sender, EventArgs e)
        {
            chartSales.Visible = true;
            chartSales2.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm = new Login();
            loginForm.loginEventHandler += new EventHandler(LoginSuccess);
            switch (loginForm.ShowDialog())
            {
                case DialogResult.OK:
                    loginForm.Close();
                    break;
                case DialogResult.Cancel:
                    Dispose();
                    break;
            }
        }

        private void LblLogname_Click(object sender, EventArgs e)
        {
        }

        private void btnPdOrder_Click(object sender, EventArgs e)
        {

            ProductOrder f = new ProductOrder();
            DialogResult = DialogResult.OK;
            f.Show();
        }

        private void btnPdMdfy_Click(object sender, EventArgs e)
        {
            ProductModify f = new ProductModify();
            DialogResult = DialogResult.OK;
            f.Show();
        }

        private void btnPdDel_Click(object sender, EventArgs e)
        {
            ProductDelete f = new ProductDelete();
            DialogResult = DialogResult.OK;
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

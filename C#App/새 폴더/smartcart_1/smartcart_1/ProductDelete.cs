using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smartcart_1
{
    public partial class ProductDelete : Form
    {
        public ProductDelete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("삭제되었습니다.", "관리자");
            Dispose(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소되었습니다.", "관리자");
            Dispose(true);
        }
    }
}

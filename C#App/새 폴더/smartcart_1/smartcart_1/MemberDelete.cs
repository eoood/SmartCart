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
    public partial class MemberDelete : Form
    {
        public MemberDelete()
        {
            InitializeComponent();
        }

        private void MemberModify_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("삭제되었습니다.", "관리자");
            Dispose(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform0302_2.DTO;

namespace winform0302_2.UI
{
    partial class AddUserUI : Form
    {
        DaoOracle ora;
        public AddUserUI()
        {
            InitializeComponent();
        }

        public AddUserUI(DaoOracle ora)
        {
            InitializeComponent();
            this.ora = ora;
        }

        private void addUserOK_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string strAge = tbAge.Text;
            string addr = tbAddr.Text;

            if (name.Equals(""))
            {
                MessageBox.Show("이름을 입력하세요.");
                return;
            }

            if (strAge.Equals(""))
            {
                MessageBox.Show("나이를 입력하세요.");
                return;
            }

            if (addr.Equals(""))
            {
                MessageBox.Show("주소를 입력하세요.");
                return;
            }
            ora.insertDB(new AddrUser(name, int.Parse(strAge), addr));
            tbName.Text = "";
            tbAge.Text = "";
            tbAddr.Text = "";
            MessageBox.Show("데이터가 입력되었습니다.");
        }

        private void addUserCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

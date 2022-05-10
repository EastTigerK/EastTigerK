using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform0217
{
    public partial class FormTest1 : Form
    {
        public FormTest1()
        {
            InitializeComponent();
        }

        private void getData_Click(object sender, EventArgs e)
        {
            // textbox에 입력된 정보
            string data = inputData.Text;
            // label에 정보 출력
            viewData.Text = data;
        }
    }
}

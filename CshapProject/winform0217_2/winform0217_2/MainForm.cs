using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform0217_2
{
    public partial class MainForm : Form
    {
        // MainForm 클래스 인스턴스 변수
        int num1;
        int num2;
        int res;

        public MainForm()
        {
            InitializeComponent();       
        }

        private void plus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(input1.Text);
            num2 = int.Parse(input2.Text);
            res = num1 + num2;
            output.Text = res.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            output.Text = 
                (int.Parse(input1.Text) - int.Parse(input2.Text)).ToString();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(input1.Text);
            int num2 = int.Parse(input2.Text);
            int res = num1 * num2;
            output.Text = res.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(input1.Text);
            num2 = int.Parse(input2.Text);
            res = num1 / num2;
            output.Text = res.ToString();
        }
    }
}

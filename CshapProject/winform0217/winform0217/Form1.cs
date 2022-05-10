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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 이벤트 핸들러
        private void btnClick(object sender, EventArgs e)
        {
            // 확인 버튼이 클릭되면 동작됨
            MessageBox.Show("확인 버튼 클릭");
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소 버튼 클릭");
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("라디오버튼1 버튼 클릭 이벤트 발생");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("checkBox1_CheckedChanged 이벤트 발생");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form1_Load 이벤트 발생");
        }        
    }
}

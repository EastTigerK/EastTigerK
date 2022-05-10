using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform0218
{
    public partial class MainForm : Form
    {
        private static MainForm inst;
        public MainForm()
        {
            InitializeComponent();
            inst = this;
        }

        public static MainForm getMainInst()
        {
            return inst;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // 모든 폼 강제 종료
            Application.Exit();
        }

        private void open_Click(object sender, EventArgs e)
        {
            SubForm frm = new SubForm();
            frm.ShowDialog();
        }

        public void setData(string data)
        {
            input.Text = data;
        }

        public string getData()
        {
            return input.Text;
        }
    }
}

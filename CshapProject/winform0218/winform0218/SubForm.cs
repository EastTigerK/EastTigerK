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
    public partial class SubForm : Form
    {
        TextBox txtBox;
        MainForm form;
        public SubForm()
        {
            InitializeComponent();
            output.Text = MainForm.getMainInst().getData();
        }

        public SubForm(string data)
        {
            InitializeComponent();
            output.Text = data;
        }

        public SubForm(TextBox txtBox)
        {
            InitializeComponent();
            this.txtBox = txtBox;
            output.Text = txtBox.Text;
        }

        public SubForm(MainForm form, string data)
        {
            InitializeComponent();
            this.form = form;
            output.Text = form.getData();
        }

        private void subExit_Click(object sender, EventArgs e)
        {
            MainForm.getMainInst().setData(output.Text);
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz0218
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainStart_Click(object sender, EventArgs e)
        {
            Quiz1 quiz1 = new Quiz1();
            quiz1.ShowDialog();
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainStart2_MouseDown(object sender, MouseEventArgs e)
        {
            mainStart2.BackgroundImage = Properties.Resources.start_press;
        }

        private void mainStart2_MouseUp(object sender, MouseEventArgs e)
        {
            mainStart2.BackgroundImage = Properties.Resources.start_normal;
        }

        private void mainStart2_MouseHover(object sender, EventArgs e)
        {
            mainStart2.BackgroundImage = Properties.Resources.start_hover;
        }

        private void mainStart2_MouseLeave(object sender, EventArgs e)
        {
            mainStart2.BackgroundImage = Properties.Resources.start_normal;
        }
    }
}

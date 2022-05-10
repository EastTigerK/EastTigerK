using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform0224.common;

namespace winform0224
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            Util.initTheme(this);
        }

        private void initTheme()
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.LIGHT;
            skin.ColorScheme = new ColorScheme(
                Primary.Indigo800,
                Primary.Indigo800,
                Primary.LightBlue500,
                Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void mainMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMin_MouseDown(object sender, MouseEventArgs e)
        {
            mainMin.BackgroundImage = Properties.Resources.min_press;
        }

        private void mainMin_MouseUp(object sender, MouseEventArgs e)
        {
            mainMin.BackgroundImage = Properties.Resources.min_normal;
        }

        private void mainExit_MouseDown(object sender, MouseEventArgs e)
        {
            mainExit.BackgroundImage = Properties.Resources.exit_press;
        }

        private void mainExit_MouseUp(object sender, MouseEventArgs e)
        {
            mainExit.BackgroundImage = Properties.Resources.exit_normal;
        }
    }
}

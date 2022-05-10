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
    public partial class Form3 : MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
            Util.initTheme(this);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //this.Text = "차량 관리 프로그램v2.0";
        }
    }
}

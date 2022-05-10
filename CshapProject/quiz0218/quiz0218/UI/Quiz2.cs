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
    public partial class Quiz2 : Form
    {
        int totalScore;
        public Quiz2()
        {
            InitializeComponent();
        }

        public Quiz2(int score)
        {
            InitializeComponent();
            totalScore = score;
        }

        private void quiz2Main_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void quiz2Next_Click(object sender, EventArgs e)
        {
            Close();
            Quiz3 quiz3 = new Quiz3();
            quiz3.ShowDialog();
        }

        private void Quiz2_Load(object sender, EventArgs e)
        {
            quiz2Score.Text = totalScore.ToString();
        }
    }
}

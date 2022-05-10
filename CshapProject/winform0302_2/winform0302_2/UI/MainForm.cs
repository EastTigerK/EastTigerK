using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform0302_2.Common;
using winform0302_2.DTO;
using winform0302_2.UI;

namespace winform0302_2
{
    public partial class MainForm : Form
    {
        DaoOracle ora = new DaoOracle();
        public MainForm()
        {
            InitializeComponent();
            //ora.dbConn();
        }

        private void createTb_Click(object sender, EventArgs e)
        {
            ora.createTable();
            //DaoOracle.Instance().createTable();
        }

        private void dropTb_Click(object sender, EventArgs e)
        {
            ora.dropTable();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            AddUserUI addUi = new AddUserUI(ora);
            addUi.ShowDialog();
            //ora.insertDB();
        }

        private void view_Click(object sender, EventArgs e)
        {
            //ora.showDB();
            ShowUserUI showUi = new ShowUserUI(ora);
            showUi.ShowDialog();

        }

        private void update_Click(object sender, EventArgs e)
        {
            ora.updateDB();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ora.deleteDB();
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insRand_Click(object sender, EventArgs e)
        {
            string randNum = Microsoft.VisualBasic.
                Interaction.InputBox("랜덤한 데이터 생성 갯수를 입력하세요",
                "랜덤 생성", "숫자를 입력하세요");

            AddrUser[] userArr = new AddrUser[int.Parse(randNum)];
            for (int i = 0; i < userArr.Length; i++)
            {
                userArr[i] = new AddrUser(RandData.getName(),
                    RandData.getAge(), RandData.getAddr());
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine(userArr[i].ToString());
                Console.WriteLine("----------------------");
                ora.insertDB(userArr[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform0302_2.DTO;

namespace winform0302_2.UI
{
    partial class ShowUserUI : Form
    {
        DaoOracle ora;
        public ShowUserUI()
        {
            InitializeComponent();
        }

        public ShowUserUI(DaoOracle ora)
        {
            InitializeComponent();
            this.ora = ora;
        }

        private void viewOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void initListView()
        {
            string[] strTemp = { "1", "홍길동", "200", "조선 한양 홍대감댁 1번지" };
            listView.Items.Add(new ListViewItem(strTemp));


            for (int i = 0; i < 100; i++)
            {
                listView.Items.Add(new ListViewItem(new string[]
                {
                    (i+2).ToString(),"전우치",(i+100).ToString(),
                "강원 두메 깊은산골"}));
            }

            //마지막행 자동 선택
            int idx = listView.Items.Count - 1;
            listView.Items[idx].Selected = true;
            listView.Items[idx].Focused = true;
            listView.Focus();
            listView.EnsureVisible(idx);

            //선택한 행의 값 가져오기
            string count = listView.Items[listView.FocusedItem.Index].SubItems[0].Text;
            string name = listView.Items[listView.FocusedItem.Index].SubItems[1].Text;
            string age = listView.Items[listView.FocusedItem.Index].SubItems[2].Text;
            string addr = listView.Items[listView.FocusedItem.Index].SubItems[3].Text;
            Console.WriteLine("번호: " + count);
            Console.WriteLine("이름: " + name);
            Console.WriteLine("나이: " + age);
            Console.WriteLine("주소: " + addr);
        }

        private void initListView2()
        {
            List<AddrUser> userList = ora.getDB();
            for (int i = 0; i < userList.Count; i++)
            {
                Console.WriteLine(userList[i].Age);


                listView.Items.Add(new ListViewItem(new string[]
                {
                    (i+1).ToString(),
                userList[i].Name,
                (userList[i].Age).ToString(),
                userList[i].Addr
                }));

            }

            //마지막행 자동 선택
            int idx = listView.Items.Count - 1;
            listView.Items[idx].Selected = true;
            listView.Items[idx].Focused = true;
            listView.Focus();
            listView.EnsureVisible(idx);
        }
        private void ShowUserUI_Load(object sender, EventArgs e)
        {
            initListView2();
            initGridView2();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.FocusedItem != null && listView.FocusedItem.Selected)
            {
                int idx = listView.FocusedItem.Index;
                Console.Write(listView.Items[idx].SubItems[0].Text + "#");
                Console.Write(listView.Items[idx].SubItems[1].Text + "#");
                Console.Write(listView.Items[idx].SubItems[2].Text + "#");
                Console.Write(listView.Items[idx].SubItems[3].Text);
                //subitem0,1,2,3은 번호,이름,나이,주소
            }
        }
        private void initGridView()
        {
            string[] data = { "1", "홍길동", "200", "조선 한양 홍대감댁 1번지" };
            dataGridView.Rows.Add(data);

            for (int i = 0; i < 100; i++)
            {
                dataGridView.Rows.Add(new string[]
                {
                    (i+2).ToString(),"전우치",(i+100).ToString(),"강원도 두메산골 아주깊은곳"
                });
            }
            dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.Rows.Count - 1;
            dataGridView.CurrentCell = dataGridView.Rows[dataGridView.Rows.Count - 2].Cells[0];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(dataGridView.Rows[dataGridView.CurrentCellAddress.Y].Cells[i].Value.ToString());
            }
        }
        private void initGridView2()
        {
            List<AddrUser> userList = ora.getDB();
            for (int i = 0; i < userList.Count; i++)
            {
                Console.WriteLine(userList[i].Age);


                dataGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(),
                userList[i].Name,
                userList[i].Age.ToString(),
                userList[i].Addr
                });

            }
            dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.Rows.Count - 1;
            dataGridView.CurrentCell = dataGridView.Rows[dataGridView.Rows.Count - 2].Cells[0];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(dataGridView.Rows[dataGridView.CurrentCellAddress.Y].Cells[i].Value.ToString());
            }
        }
    }
}

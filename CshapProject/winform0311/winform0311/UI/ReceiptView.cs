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
using winform0311.DTO;
using winform0311.Handler;

namespace winform0311.UI
{
    partial class ReceiptView : MaterialForm
    {
        BaseAdapter baseAd;
        public ReceiptView()
        {
            InitializeComponent();
        }

        public ReceiptView(BaseAdapter baseAd)
        {
            InitializeComponent();
            this.baseAd = baseAd;
        }

        private void rcClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReceiptView_Load(object sender, EventArgs e)
        {
            
            initListView2();
            initGridView2();
        }

        private void initListView()
        {
            string[] strTemp = { "1", "홍길동", "200", "조선 한양 홍대감댁 1번지" };
            rcListView.Items.Add(new ListViewItem(strTemp));


            for (int i = 0; i < 100; i++)
            {
                rcListView.Items.Add(new ListViewItem(new string[]
                {
                    (i+2).ToString(),"전우치",(i+100).ToString(),
                "강원 두메 깊은산골"}));
            }

            //마지막행 자동 선택
            int idx = rcListView.Items.Count - 1;
            rcListView.Items[idx].Selected = true;
            rcListView.Items[idx].Focused = true;
            rcListView.Focus();
            rcListView.EnsureVisible(idx);

            //선택한 행의 값 가져오기
            string count = rcListView.Items[rcListView.FocusedItem.Index].SubItems[0].Text;
            string name = rcListView.Items[rcListView.FocusedItem.Index].SubItems[1].Text;
            string age = rcListView.Items[rcListView.FocusedItem.Index].SubItems[2].Text;
            string addr = rcListView.Items[rcListView.FocusedItem.Index].SubItems[3].Text;
            Console.WriteLine("번호: " + count);
            Console.WriteLine("이름: " + name);
            Console.WriteLine("나이: " + age);
            Console.WriteLine("주소: " + addr);
        }

        private void initListView2()
        {
            List<ReceiptItem> list = baseAd.getReceiptDb();
            for (int i = 0; i < list.Count; i++)
            {
                rcListView.Items.Add(new ListViewItem(new string[]
                {
                    (i+2).ToString(),list[i].Indate,list[i].Total_price,list[i].StaffName,
                    list[i].CustName,list[i].CustTel,list[i].CarNum,list[i].RepairChk}));
            }
        }

        private void initGridView()
        {
            string[] data = { "1", "홍길동", "200", "조선 한양 홍대감댁 1번지" };
            rcGridView.Rows.Add(data);

            for (int i = 0; i < 100; i++)
            {
                rcGridView.Rows.Add(new string[]
                {
                    (i+2).ToString(),"전우치",(i+100).ToString(),"강원도 두메산골 아주깊은곳"
                });
            }
            rcGridView.FirstDisplayedScrollingRowIndex = rcGridView.Rows.Count - 1;
            rcGridView.CurrentCell = rcGridView.Rows[rcGridView.Rows.Count - 2].Cells[0];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(rcGridView.Rows[rcGridView.CurrentCellAddress.Y].Cells[i].Value.ToString());
            }
        }

        private void initGridView2()
        {
            List<RepairItem> list = baseAd.getRepairDb();
            for (int i = 0; i < list.Count; i++)
            {
                rcGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(),list[i].Repair,String.Format("￦{0:#,0}원",list[i].Price)
                });
            }
        }

        private void initGridView2(List<RepairItem> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                rcGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(),list[i].Repair,String.Format("￦{0:#,0}원",list[i].Price)
                });
            }
        }

        private void rcListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rcListView.SelectedItems.Count != 0)
            {
                int n = rcListView.SelectedItems[0].Index;
                string name = rcListView.Items[n].SubItems[4].Text;
                string tel = rcListView.Items[n].SubItems[5].Text;
                rcGridView.Rows.Clear();
                List<RepairItem> list = baseAd.getRepairDb(name, tel);
                initGridView2(list);
            }
        }
    }
}

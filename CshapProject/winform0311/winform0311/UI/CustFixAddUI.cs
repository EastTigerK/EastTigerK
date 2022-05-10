using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform0311.DTO;
using winform0311.Handler;
using winform0311.Util;

namespace winform0311.UI
{
    partial class CustFixAddUI : MaterialForm
    {
        BaseAdapter baseAd;
        public CustFixAddUI()
        {
            InitializeComponent();
        }

        public CustFixAddUI(BaseAdapter baseAd)
        {
            InitializeComponent();
            this.baseAd = baseAd;
        }

        private void CustFixAddUI_Load(object sender, EventArgs e)
        {
            setYear();
            setMonth();
            setDay();
        }

        private void setYear()
        {
            //custYear.Items.Add("2002");
            for (int i = 2002; i>=1950; i--)
            {
                custYear.Items.Add(i.ToString());
            }
        }

        private void setMonth()
        {
            for (int i=1; i<=12; i++)
            {
                custMonth.Items.Add(i.ToString());
            }
        }

        private void setDay()
        {
            for (int i = 1; i <= 31; i++)
            {
                custDay.Items.Add(i.ToString());
            }
        }

        private void custClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void custModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string model = custModel.SelectedItem.ToString();
            switch (model)
            {
                case "벨로스터":
                    carPic.Image = Properties.Resources.벨로스터;
                    break;
                case "소나타":
                    carPic.Image = Properties.Resources.소나타;
                    break;
                case "그랜저":
                    carPic.Image = Properties.Resources.그랜저;
                    break;
                case "제네시스":
                    carPic.Image = Properties.Resources.제네시스;
                    break;
                case "K7":
                    carPic.Image = Properties.Resources.K7;
                    break;
                default:
                    carPic.Image = Properties.Resources.defalut_car;
                    break;
            }
        }

        private void custSave_Click(object sender, EventArgs e)
        {
            string name = custName.Text;
            string telH = custTelH.Text;
            string telB = custTelB.Text;
            string year = custYear.Text;
            string month = custMonth.Text;
            string day = custDay.Text;
            string model = custModel.Text;
            string num = carNumber.Text;
            string cc = carCC.Text;
            string caryear = carYear.Text;
            string staffName = custStaff.Text;

            Control[] arrObj = new Control[]
            {
                custName, custTelH, custTelB, custYear, custMonth,
                custDay, custModel, carNumber, carCC, carYear, custStaff
            };

            string[] arrData = new string[]
            {
                name, telH, telB, year, month, day, 
                model, num, cc, caryear, staffName
            };

            string[] arrMsg = new string[]
            {
                Properties.Resources.ERR_NAME, Properties.Resources.ERR_TEL_H,
                Properties.Resources.ERR_TEL_B, Properties.Resources.ERR_BIRTH_YEAR,
                Properties.Resources.ERR_BIRTH_MONTH, Properties.Resources.ERR_BIRTH_DAY,
                Properties.Resources.ERR_CAR_MODEL, Properties.Resources.ERR_CAR_NUM,
                Properties.Resources.ERR_CAR_CC, Properties.Resources.ERR_CAR_YEAR,
                Properties.Resources.ERR_STAFF_NAME
            };

            Dictionary<Control, string> dic = new Dictionary<Control, string>();
            for (int i=0; i<arrData.Length; i++)
            {
                dic.Add(arrObj[i], arrData[i]);
            }

            int cnt = 0;
            string telAll = telH + telB;
            foreach (KeyValuePair<Control, string> kvp in dic)
            {
                if (kvp.Value.Equals("") || kvp.Value.Equals("선택"))
                {
                    setFocus(kvp.Key, arrMsg[cnt]);
                    return;
                }
                
                if (!checkName(name) || !checkTel(telAll))
                {
                    return;
                }
                cnt++;
            }

            UICheckBox[] checkBox =
            {
                chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8, chk9, chk10
            };

            List<RepairItem> itemList = new List<RepairItem>();
            int total = 0;
            for (int i = RepairTable.ENGINE_OIL;
                i <= RepairTable.ETC_COST; i++)
            {
                if (checkBox[i].Checked)
                {
                    Console.WriteLine(checkBox[i].Text);
                    itemList.Add(new RepairItem(checkBox[i].Text,
                        RepairTable.fixMoney[i]));
                    total += RepairTable.fixMoney[i];
                }
            }

            if (itemList.Count == 0)
            {
                MessageBox.Show("수리항목을 선택하세요");
                return;
            }

            Customer cust = new Customer(name, telAll, year + month + day);
            Car car = new Car(model, num, cc, caryear);
            Receipt receipt = 
                new Receipt(cust, car, 
                DateTime.Now.ToString("yyyy년MM월dd일"),
                staffName, itemList, total, "NO");
            baseAd.addReceiptList(receipt);
            MessageBox.Show("데이터가 정상적으로 저장되었습니다.");
            Close();
        }

        private void setFocus(Control obj, string msg)
        {
            MessageBox.Show(msg);
            ActiveControl = obj;
            obj.Focus();
        }

        private bool checkName(string name)
        {
            Regex regex = new Regex(@"^[가-힣]{2,4}$");
            Match m = regex.Match(name);
            //if (!m.Success)
            if (m.Success == false)
            {
                setFocus(custName, "잘못된 이름 정보입니다.");
                return false;
            }
            return true;
        }

        private bool checkTel(string tel)
        {
            Regex regex = new Regex(@"^01{1}[01]{1}[0-9]{7,8}$");
            Match m = regex.Match(tel);
            //if (!m.Success)
            if (m.Success == false)
            {
                setFocus(custName, "잘못된 전화 정보입니다.");
                return false;
            }
            return true;
        }
    }
}

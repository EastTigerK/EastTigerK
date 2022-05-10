using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform0217_2
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();

            string test = "1+2";            
            string[] num = test.Split('+');
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }

        private void Calc_Load(object sender, EventArgs e)
        {
            
        }

        private void onClickHandler(object sender, EventArgs e)
        {
            string str = ((Button)sender).Name;
            switch (str)
            {
                case "num0": case "num1": case "num2": case "num3":
                case "num4": case "num5": case "num6": case "num7":
                case "num8": case "num9": case "plus": case "minus":
                case "multi": case "div":
                    output.Text += ((Button)sender).Text;
                    break;
                case "clear":
                    output.Text = "";
                    break;
                case "enter":
                    string res = output.Text;
                    string val = "";
                    string op = string.Empty;

                    try
                    {
                        for (int i = 0; i < res.Length; i++)
                        {
                            // 연산자와 피연산자 분리
                            string s = res.Substring(i, 1);
                            Console.WriteLine(s);
                            if (s.Equals("+") || s.Equals("-") ||
                                s.Equals("x") || s.Equals("÷"))
                            {
                                val += ":";
                                op += s;
                            }
                            else
                            {
                                val += s;
                            }
                        }

                        string[] valArr = val.Split(':');
                        int[] intVal = new int[valArr.Length];
                        for (int i = 0; i < intVal.Length; i++)
                        {
                            intVal[i] = Convert.ToInt32(valArr[i]);
                        }

                        for (int i = 0; i < op.Length; i++)
                        {
                            string opStr = op.Substring(i, 1);
                            switch (opStr)
                            {
                                case "+":
                                    intVal[i + 1] = intVal[i] + intVal[i + 1];
                                    break;
                                case "-":
                                    intVal[i + 1] = intVal[i] - intVal[i + 1];
                                    break;
                                case "x":
                                    intVal[i + 1] = intVal[i] * intVal[i + 1];
                                    break;
                                case "÷":
                                    intVal[i + 1] = intVal[i] / intVal[i + 1];
                                    break;
                            }
                            output.Text = intVal[i + 1].ToString();
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("입력식이 잘못되었습니다.");
                    }
                    break;
            }
        }
    }
}

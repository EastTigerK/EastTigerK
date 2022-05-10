using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform0216_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            initCar();
            initCar2();
        }

        public void initCar()
        {
            Car car = new Car("그랜저", "4천만원", "파랑");
            car.setModel("소나타1");
            car.printCarInfo();
            Console.WriteLine("변경된 모델: " + car.getModel());
        }

        public void initCar2()
        {
            Car2 car2 = new Car2("G80", "7천만원", "검정");
            car2.Model = "소나타2";
            Console.WriteLine(car2.ToString());
            car2.printCarInfo();
            Console.WriteLine("변경된 모델: " + car2.Model);
        }
    }
}

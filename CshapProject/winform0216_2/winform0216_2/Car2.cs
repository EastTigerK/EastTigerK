using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform0216_2
{
    internal class Car2
    {
        private string model;
        private string price;
        private string color;

        public Car2(string model, string price, string color)
        {
            this.model = model;
            this.price = price;
            this.color = color;
        }

        public string Model { get => model; set => model = value; }
        public string Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }

        // 재정의
        public override string ToString()
        {
            string str = "모델: " + model + "\n";
            str += "가격: " + price + "\n";
            str += "색상: " + color + "\n";
            return str;
        }

        public void printCarInfo()
        {
            Console.WriteLine("모델: " + model);
            Console.WriteLine("가격: " + price);
            Console.WriteLine("색상: " + color);
        }
    }
}

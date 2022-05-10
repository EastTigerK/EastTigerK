using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform0216_2
{
    internal class Car
    {
        private string model;
        private string price;
        private string color;

        public Car(string model, string price, string color)
        {
            this.model = model;
            this.price = price;
            this.color = color;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public string getModel()
        {
            return model;
        }

        public void printCarInfo()
        {
            Console.WriteLine("모델: " + model);
            Console.WriteLine("가격: " + price);
            Console.WriteLine("색상: " + color);
        }
    }
}

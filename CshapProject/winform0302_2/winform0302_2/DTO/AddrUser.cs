using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform0302_2.DTO
{
    internal class AddrUser
    {
        private string name;
        private int age;
        private string addr;

        public AddrUser(string name, int age, string addr)
        {
            this.name = name;
            this.age = age;
            this.addr = addr;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Addr { get => addr; set => addr = value; }

        public override string ToString()
        {
            string data = "이름: " + name + "\n";
            data += "나이: " + age + "\n";
            data += "주소: " + addr;
            return data;
        }
    }
}

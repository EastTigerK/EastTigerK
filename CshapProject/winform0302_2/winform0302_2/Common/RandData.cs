using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform0302_2.Common
{
    internal class RandData
    {
        static string[] first = { "동", "아", "경", "수", "호" };
        static string[] mid = { "길", "세", "나", "민", "연" };
        static string[] last = { "김", "이", "박", "최", "홍" };
        static int[] age = {20, 30, 40, 50, 60};
        static string[] addr = {"대구 동구 신천3동", "부산 동구 신천3동", 
            "서울 동구 신천3동", "광주 동구 신천3동", "대전 동구 신천3동"};

        static Random r = new Random();

        public static string getName()
        {
            string fullName = last[r.Next(0, 5)] + mid[r.Next(0, 5)] +
                first[r.Next(0, 5)];
            return fullName;
        }

        public static int getAge()
        {
            return age[r.Next(0, age.Length)];
        }

        public static string getAddr()
        {
            return addr[r.Next(0, addr.Length)];
        }
    }
}

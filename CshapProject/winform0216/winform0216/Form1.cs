using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform0216
{
    // Form 클래스에서 상속받아 화면 구성 및 기능 구현 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Form1 생성자");
            writeTest();
        }

        public void writeTest()
        {
            /*
            Console.WriteLine("기본 콘솔 출력");
            string name = "홍길동";
            // + 연산자를 사용한 변수 출력
            Console.WriteLine("1.이름: " + name);
            
            // 문자열 format 을 이용한 변수 출력
            Console.WriteLine("2.이름: {0}", name);
            string name2 = string.Format("3.이름: {0}, 나이: {1}", name, 20);
            Console.WriteLine(name2);
            
            // 보간 문자열 출력 (C#6.0 이상)
            Console.WriteLine($"4.이름: {name}");

            Console.Write("이름을 입력하세요: ");
            string name3 = Console.ReadLine(); // 문자열만 입력 가능
            Console.WriteLine($"5.이름: {name3}");

            Console.Write("나이를 입력하세요: ");
            string age = Console.ReadLine();
            int age2 = int.Parse(age);
            int age3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"나이: {age2}, {age3}");
            */

            // 1차원 배열
            int[] arrInt = { 10, 20, 30, 40 };
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.Write(arrInt[i] + " ");
                string str = string.Format("배열[{0}]:{1}", i, arrInt[i]);
                Console.Write(str + " ");
                Console.WriteLine($"배열[{i}]:{arrInt[i]}");
            }

            char[] arrChar = new char[4] { '이', '김', '박', '최' };
            for (int i = 0; i < arrChar.Length; i++)
            {
                Console.Write(arrChar[i] + " ");
            }
            Console.WriteLine();

            // 2차원 배열1
            int[,] arrInt2 =
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            for (int i = 0; i<2; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    Console.Write(arrInt2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 2차원 배열2
            const int SIZE_ROW = 2;
            const int SIZE_COL = 3;
            int[,] arrInt3 = new int[SIZE_ROW, SIZE_COL]
            {
                {10, 20, 30 }, {40, 50, 60}
            };

            for (int i=0; i< SIZE_ROW; i++)
            {
                for (int j=0; j<SIZE_COL; j++)
                {
                    Console.Write(arrInt3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 2차원배열3
            string[][] arrStr = new string[2][];
            arrStr[0] = new string[] { "홍길동", "김길동", "전우치" };
            arrStr[1] = new string[] { "박길동" };
            for (int i=0; i<arrStr.Length; i++)
            {
                for(int j=0; j<arrStr[i].Length; j++)
                {
                    Console.Write(arrStr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 2차원 배열4
            int[][] arrInt4 = new int[3][];
            for (int i=0;i<arrInt4.Length; i++)
            {
                arrInt4[i] = new int[i + 1];
                for (int j=0; j<arrInt4[i].Length; j++)
                {
                    arrInt4[i][j] = 10 + j;
                    Console.Write(arrInt4[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // foreach
            int[] arrEach = { 1, 2, 3, 4 };
            foreach (int i in arrEach)
            {
                Console.Write(i + " ");
            }

            // 컬렉션 클래스 + 제네릭 클래스
            // List
            List<string> list = new List<string>();
            list.Add("홍길동");
            list.Add("김길동");
            list.Add("박길동");
            list.RemoveAt(0);
            list.Remove("김길동");
            list.Insert(0, "전우치");

            for (int i=0; i<list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            // Hash table(키, 값)
            Hashtable hTable = new Hashtable();
            hTable.Add(1, "홍길동");
            hTable.Add(2, "전우치");

            if (hTable.Contains(1))
            {
                Console.WriteLine(hTable[1]);
            }

            // 딕셔너리 (키, 값)
            Dictionary<string, string> dic =
                new Dictionary<string, string>();
            dic.Add("key1", "홍길동");
            dic.Add("key2", "전우치");
            dic.Add("key3", "유관순");

            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (string key in dic.Keys)
            {
                Console.Write(key + " ");
            }
            Console.WriteLine();

            foreach(string val in dic.Values)
            {
                Console.WriteLine(val + " ");
            }

            Console.WriteLine($"key2키의 값: {dic["key2"]}");
        }
    }
}

using System;

namespace ConsoleApp3141
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數");
            string a = Console.ReadLine();
            int Num = Convert.ToInt32(a);
            if (Num % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (Num >= 2 && Num <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (Num >= 6 && Num <= 20)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }

            string b = Console.ReadLine();
            int c = Convert.ToInt32(b);
            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            int k;
            for (int i = 1; i <= c; i++)
            {
                k = c * i;
                Console.WriteLine(c + "*" + i + "=" + k);

            }
            //九九乘法
            int z;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    z = i * j;
                    Console.WriteLine(i + "*" + j + "=" + z);
                }

            }

            string[,] score = new string[6, 5] { { "座號", "姓名", "電腦概論", "程式設計", "動畫設計" },
                                                 {"1","Jack","80","75","60"},
                                                 {"2","Mary","65","67","62"},
                                                 {"3","Tom","100","93","91"},
                                                 {"4","Grace","98","25","50"},
                                                 {"5","Alice","83","82","87"}};
            Console.WriteLine("請輸入座號(1-5)");
            string d = Console.ReadLine();
            int e = Convert.ToInt32(d);
            string name = score[e, 1];
            string cpt = score[e, 2];
            string pro = score[e, 3];
            string ani = score[e, 4];

            Console.WriteLine("輸入座號" + e);
            Console.WriteLine("1.姓名：" + name);
            Console.WriteLine("2.電腦概論：" + cpt);
            Console.WriteLine("3.程式設計：" + pro);
            Console.WriteLine("4.動畫設計：" + ani);
        }
    }
}

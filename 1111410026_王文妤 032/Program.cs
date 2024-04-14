using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111410026_王文妤_032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數：");
            string r = Console.ReadLine();
            string[] rs = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] ri = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            int a = Convert.ToInt32(r);
            string roma = "";
            for (int i = 0; i < rs.Length; i++)
            {
                while (a >= ri[i])
                { 
                    a -= ri[i]; 
                    roma +=  rs[i]; 
                }
            }
            Console.WriteLine("對應的羅馬數字為：" + roma);
            Console.Read();
        }
    }
}

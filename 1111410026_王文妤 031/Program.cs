using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111410026_王文妤_031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入想索引的字串陣列(以空格區隔)");
            string [] words =Console.ReadLine().Split(' ');
            Console.WriteLine("請輸入想索引的字元");
            char x = Console.ReadLine()[0];
            for(int i=0;i<words.Length;i++)
            {
                if (words[i].IndexOf(x) != -1)
                {
                    Console.WriteLine("[" + i + "]");
                }
                else
                {
                    Console.WriteLine("");
                }
            }
            Console.Read();
        }
    }
}

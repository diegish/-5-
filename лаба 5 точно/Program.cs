using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_5_точно
{
    internal class Program
    {
        static int vvodA, vvodB;
        static void Main(string[] args)
        {
            while (vvodB == 0)
            {
                Console.WriteLine("Введите B: ");
                string vvod = Console.ReadLine();
                try
                {
                    vvodB = int.Parse(vvod);
                }
                catch
                {
                    Console.WriteLine("Давай заново");
                }
            }
            while (vvodB == 0)
            {
                Console.WriteLine("Введите B: ");
                string vvod = Console.ReadLine();
                try
                {
                    vvodB = int.Parse(vvod);
                }
                catch
                {
                    Console.WriteLine("Давай заново");
                }
            }
            Console.WriteLine("A = " + vvodA + "\n" + "B = " + vvodB);


            Console.ReadLine();
        }

        //static void ass(int a, int b)
        //{
        //    return a + b;
        //}
    }
}

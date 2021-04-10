using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.14 ж
            Console.WriteLine("введите число");
            double a = Convert.ToDouble(Console.ReadLine());
            double a2 = -7.5 * Math.Pow(a, 2);
            Console.WriteLine("Ответ: " + a2);
            Console.ReadKey();

            //1.14 з
            Console.WriteLine("введите число");
            double x = Convert.ToDouble(Console.ReadLine());
            double b2 = 3 * Math.Sqrt(x);
            Console.WriteLine("Ответ:" + b2);
            Console.ReadKey();

            //1.14 м
            Console.WriteLine("1.14");
            Console.WriteLine("введите число z");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число y");
            double y = Convert.ToDouble(Console.ReadLine());
            double zy = -5 * Math.Sqrt(z + Math.Sqrt(y));
            Console.WriteLine(" ответ :" + zy);
            Console.ReadKey();





        }
    }
}

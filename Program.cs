using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Введите коэффициент а: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("преобразование строки в число");
            bool ConvertResult1 = double.TryParse(str1, out a);
            if (ConvertResult1)
            {
                Console.WriteLine("Вы ввели число " + a.ToString("F5"));
            }
            else
            {
                Console.WriteLine("ошибка");
            }

            Console.Write("Введите коэффициент b: ");
            string str2 = Console.ReadLine();
            bool ConvertResult2 = double.TryParse(str2, out b);
            if (ConvertResult2)
            {
                Console.WriteLine("Вы ввели число " + b.ToString("F5"));
            }
            else
            {
                Console.WriteLine("ошибка");
            }

            Console.Write("Введите коэффициент c: ");
            string str3 = Console.ReadLine();
            bool ConvertResult3 = double.TryParse(str3, out c);
            if (ConvertResult3)
            {
                Console.WriteLine("Вы ввели число " + c.ToString("F5"));
            }
            else
            {
                Console.WriteLine("ошибка");
            }

            double D;
            D = b * b - 4 * c * a;
            double x1, x2;

            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }

            else if (D == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("x1 = " + x1 + ", x2 = x1");
            }

            else
            {
                Console.WriteLine("Нет действительных корней");
            }


            Console.ReadKey();
        }
    }
}


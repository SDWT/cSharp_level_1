// 3.
// а) Написать программу, которая подсчитывает расстояние между точками с
// координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) +
// Math.Pow(y2 - y1, 2).Вывести результат используя спецификатор формата .2f
//(с двумя знаками после запятой);
// б) * Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода;
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_3
{
    class Program
    {
        static double ro(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            double x1 = 0, x2 = 0, y1 = 0, y2 = 0, r;
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            //r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            r = ro(x1, y1, x2, y2);

            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}

// 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
// Продемонстрировать работу структуры;
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел.
// Проверить работу класса;
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityForStudyNameSpace;

namespace HW3_1
{
    class Program
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var specFunc = new UtilityForStudy();
            Complex a = new Complex(7);
            Complex b = new Complex(10, 20);
            Complex c = new Complex();
            Complex d = b;

            Console.WriteLine(string.Format("a = {0}, b = {1}, " +
                "c = {2}, d = {3}\n", a, b, c, d));

            Console.WriteLine(string.Format("-d = {0}", -d));
            Console.WriteLine(string.Format("a + b = {0} + {1} = {2}", a, b, a + b));
            Console.WriteLine(string.Format("d - a = {0} - {1} = {2}", d, a, d - a));
            Console.WriteLine(string.Format("b * (a + d) = {0} * ({1} + {2}) = {3}", b, a, d, b * (a + d)));
            Console.WriteLine(string.Format("b * b = {0} * {0} = {1}", b, b * b));
            //Console.WriteLine();
            //Console.WriteLine(string.Format("b == d = {0} == {1} = {2}", b, d, b == d));
            //Console.WriteLine(string.Format("b != d = {0} != {1} = {2}", b, d, b != d));
            //Console.WriteLine(string.Format("a == c = {0} == {1} = {2}", a, c, a == c));
            //Console.WriteLine(string.Format("a != c = {0} != {1} = {2}", a, c, a != c));


            specFunc.Pause();
        }
    }
}

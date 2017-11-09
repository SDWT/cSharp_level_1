// 3. Напишите соответствующую функцию
// Описать класс дробей - рациональных чисел, являющихся отношением двух целых
// чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей.
// Написать программу, демонстрирующую все разработанные элементы класса.
//* Добавить упрощение дробей.
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityForStudyNameSpace;

namespace HW3_3
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
            Fraction a = new Fraction(7);
            Fraction b = new Fraction(10, 20);
            Fraction c = new Fraction();
            Fraction d = b, e = new Fraction(15, 7), f = new Fraction(21, 20);

            Console.WriteLine(string.Format("a = {0}, b = {1}, " +
                "c = {2}, d = {3}, e = {4}, f = {5}\n", a, b, c, d, e, f));

            Console.WriteLine(string.Format("-d = {0}", -d));
            Console.WriteLine(string.Format("a + b = {0} + {1} = {2}", a, b, a + b));
            Console.WriteLine(string.Format("d - a = {0} - {1} = {2}", d, a, d - a));
            Console.WriteLine(string.Format("b * (a + d) = {0} * ({1} + {2}) = {3}", b, a, d, b * (a + d)));
            Console.WriteLine(string.Format("b * b = {0} / {0} = {1}", b, b / b));
            Console.WriteLine(string.Format("e * f = {0} * {1} = {2}", e, f, e * f));
            Console.WriteLine(string.Format("e / f = {0} / {1} = {2}", e, f, e / f));
            specFunc.Pause();
        }
    }
}

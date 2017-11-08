// 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в
// новой строке). Требуется подсчитать сумму всех нечетных положительных чисел.
// Сами числа и сумму вывести на экран; Используя tryParse;
// б) Добавить обработку исключительных ситуаций на то, что могут быть введены
// некорректные данные.При возникновении ошибки вывести сообщение.
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityForStudyNameSpace;

namespace HW3_2
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

            //TaskA();
            TaskB();
            specFunc.Pause();
        }

        /// <summary>
        /// Пункт А задачи 2
        /// </summary>
        static void TaskA()
        {
            int sum = 0, sym;
            bool isContinue = false;

            do
            {
                isContinue = false;
                if (!(int.TryParse(Console.ReadLine(), out sym)))
                    isContinue = true;
                sum += sym % 2 == 1 && sym > 0 ? sym : 0;
            } while (sym != 0 || isContinue);
            Console.WriteLine(string.Format("Сумма: {0}", sum));
        }

        /// <summary>
        /// Пункт Б задачи 2
        /// </summary>
        static void TaskB()
        {
            int sum = 0, sym;
            bool isContinue = false;

            do
            {
                try
                {
                    sym = int.Parse(Console.ReadLine());
                    sum += sym % 2 == 1 && sym > 0 ? sym : 0;
                }
                catch (Exception)
                {
                    sym = 0;
                    isContinue = true;
                    Console.WriteLine("Ошибка: Введены неверные данные!\nНеобходимо вводить целые числа.");
                }
            } while (sym != 0 || isContinue);
            Console.WriteLine(string.Format("Сумма: {0}", sum));
        }
    }
}

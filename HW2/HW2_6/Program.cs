// 6. *Написать программу подсчета количества “Хороших” чисел в диапазоне от 1
// до 1 000 000 000. Хорошим называется число, которое делится на сумму своих
// цифр. Реализовать подсчет времени выполнения программы, используя структуру
// DateTime.
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityForStudyNameSpace;


namespace HW2_6
{
    class Program
    {
        /// <summary>
        /// Функция подсчёта суммы цифр в числе
        /// </summary>
        /// <param name="number">Исходное число</param>
        /// <returns>Сумма чисел исходного числа</returns>
        static int SumOfNumeral(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        /// <summary>
        /// Является ли данное число "хорошим"?
        /// </summary>
        /// <param name="number">Данное число</param>
        /// <returns>Возращает true, если число хорошее, иначе false</returns>
        static bool IsGoodNumber(int number)
        {
            if (number % SumOfNumeral(number) == 0)
                return true;
            return false;
        }

        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var specFunc = new  UtilityForStudy();
            var startTime = DateTime.Now;
            int cnt = 0;

            for (int i = 1; i <= 1000000000; i++)
            {
                if (IsGoodNumber(i))
                    cnt++;
                if (i % 1000000 == 0)
                    Console.Write(string.Format("Проверено: {0}\r", i));
            }

            var endTime = DateTime.Now;

            Console.WriteLine(string.Format("Количество хороших чисел: {0}\nВремя выполнения: {1}", cnt, endTime - startTime));
            specFunc.Pause();
        }
    }
}

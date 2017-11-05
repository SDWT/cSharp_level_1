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
            for (; number > 0; number /= 10)
                sum += number % 10;
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
            var specFunc = new FunctionsForStudy();
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

        /// <summary>
        /// Класс полезных функций
        /// </summary>
        class FunctionsForStudy
        {
            /// <summary>
            /// Ожидания нажатие любой клавиши клавиатуры
            /// </summary>
            public void Pause()
            {
                Console.WriteLine("Press any key for exit...");
                Console.ReadKey();
            }

            /// <summary>
            /// Вывод в консоль сообщения по центру экрана
            /// </summary>
            /// <param name="msg"></param>
            public void PrintCenter(string msg)
            {
                int x = Console.WindowWidth / 2, y = Console.WindowHeight / 2;
                Console.SetCursorPosition(x, y);
                Console.WriteLine(msg);
            }

            /// <summary>
            /// Вывод в консоль сообщения
            /// </summary>
            /// <param name="msg"></param>
            public void Print(string msg)
            {
                Console.Write(msg);
            }

            /// <summary>
            /// Вывод в консоль сообщения на координаты x и y
            /// </summary>
            /// <param name="msg"></param>
            /// <param name="x"></param>
            /// <param name="y"></param>
            public void Print(string msg, int x, int y)
            {
                if (x >= 0 && x < Console.WindowWidth && y >= 0 && y < Console.WindowHeight)
                    Console.SetCursorPosition(x, y);
                Console.WriteLine(msg);
            }

            /// <summary>
            /// Обмен 2-ух переменных
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="a"></param>
            /// <param name="b"></param>
            public static void Swap<T>(ref T a, ref T b)
            {
                T temp;
                temp = a;
                a = b;
                b = temp;
            }
        }
    }
}

// 7. a) Разработать рекурсивный метод, который выводит на экран числа
// от a до b(a<b);
// б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_7
{

    class Program
    {
        /// <summary>
        /// Задание 7 пункт а
        /// </summary>
        /// <param name="a">Граница 1</param>
        /// <param name="b">Граница 2</param>
        static void TaskA(int a, int b)
        {
            if (a < b)
                PrintRec(a, b);
            else
                PrintRec(a, b);
        }

        /// <summary>
        /// рекурсивный метод, который выводит на экран числа от a до b, a < b
        /// </summary>
        /// <param name="a">Меньшое число</param>
        /// <param name="b">Большое число</param>
        static void PrintRec(int a, int b)
        {
            if (a >= b)
            {
                if (a == b)
                    Console.Write(string.Format("{0} ", a));
                return;
            }
            Console.Write(string.Format("{0} ", a));
            PrintRec(a + 1, b - 1);
            Console.Write(string.Format("{0} ", b));
        }

        /// <summary>
        /// Задание 7 пункт б
        /// </summary>
        /// <param name="a">Граница 1</param>
        /// <param name="b">Граница 2</param>
        /// <returns>Сумму чисел от a до b</returns>
        static int TaskB(int a, int b)
        {
            if (a < b)
                return SumRec(a, b);
            else
                return SumRec(a, b);
        }

        /// <summary>
        /// рекурсивный метод, который считает сумму чисел от a до b, a < b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Сумму чисел от a до b</returns>
        static int SumRec(int a, int b)
        {
            if (a == b)
                return a;
            if (a > b)
                return 0;
            return a + b + SumRec(a + 1, b - 1);
        }

        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var specFunc = new FunctionsForStudy();
            char sym;
            int a, b;
            // Исполнение программы до нажатия символа '0'
            do
            {
                Console.WriteLine("Нажмите\n" +
                    "0 - Выход;\n" +
                    "a - Вывести числа от a до b\n" +
                    "b - Вывести сумму чисел от a до b;");
                sym = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (sym == 'a' || sym == 'b')
                {
                    specFunc.Print("Введите целое a:\n");
                    a = int.Parse(Console.ReadLine());
                    specFunc.Print("Введите целое b:\n");
                    b = int.Parse(Console.ReadLine());

                    if (sym == 'a')
                    {
                        TaskA(a, b);
                        Console.WriteLine();
                    }
                    else
                        Console.WriteLine(string.Format("Sum: {0}", TaskB(a, b)));
                }

            } while (sym != '0');

            specFunc.Pause();
        }
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

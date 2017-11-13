using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityForStudyNameSpace
{
    /// <summary>
    /// Класс полезных функций
    /// </summary>
    class UtilityForStudy
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

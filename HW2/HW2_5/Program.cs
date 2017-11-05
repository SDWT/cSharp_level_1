// 5. а) Написать программу, которая запрашивает массу и рост человека,
// вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать
// вес или все в норме;
// б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_5
{
    class Program
    {
        /// <summary>
        /// Функция, которая считает индекс массы
        /// </summary>
        /// <param name="m">Масса</param>
        /// <param name="h">Рост</param>
        /// <returns>Возвращяает индекс массы</returns>
        static double IndexMass(double m, double h)
        {
            return m / (h * h);
        }

        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var specFunc = new FunctionsForStudy();
            Console.WriteLine("Введите массу тела в килограммах.");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост тела в метрах.");
            double h = double.Parse(Console.ReadLine());
            double im = IndexMass(m, h);

            double bestM = 21 * h * h;

            if (im < 18.5)
                Console.WriteLine(string.Format("Вам необходимо набрать {0:F2} кг.\nВам желательно набрать {1:F2} кг.", 18.6 * h * h - m, bestM - m));
            else if (im > 25)
                Console.WriteLine(string.Format("Вам необходимо похудеть на {0:F2} кг.\nВам желательно похудеть на {1:F2} кг.", m - 24.9 * h * h, m - bestM));
            else
                Console.WriteLine(string.Format("Вам вес находится в пределах нормы."));

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

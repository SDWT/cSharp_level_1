// 4. Реализовать метод проверки логина и пароля. На вход подается логин и
// пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел
// (Логин:root, Password:GeekBrains). Используя метод проверки логина и пароля,
// написать программу: пользователь вводит логин и пароль, программа пропускает
// его дальше или не пропускает. С помощью цикла do while ограничить ввод
// пароля тремя попытками.
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_4
{
    class Program
    {
        /// <summary>
        /// Программа для проверки корректности логина и пароля
        /// </summary>
        /// <param name="loginIn">Логин для проверки</param>
        /// <param name="passwordIn">Пароль для проверки</param>
        /// <returns>Возвращает true, если логин и пароль верны, иначе false</returns>
        static bool CheckPassword(string loginIn, string passwordIn)
        {
            string login = "root";
            string password = "GeekBrains";

            if (login == loginIn && password == passwordIn)
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

            Console.WriteLine(CheckPassword("root", "GeekBrains"));
            Console.WriteLine(CheckPassword("admin", "GeekBrains"));
            Console.WriteLine(CheckPassword("root", "Reality"));
            Console.WriteLine(CheckPassword("admin", "Reality"));
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

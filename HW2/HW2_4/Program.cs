﻿// 4. Реализовать метод проверки логина и пароля. На вход подается логин и
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
using UtilityForStudyNameSpace;


namespace HW2_4
{
    class Program
    {
        /// <summary>
        /// Программа для проверки корректности логина и пароля
        /// </summary>
        /// <param name="loginIn">Логин для проверки</param>
        /// <param name="passwordIn">Пароль для проверки</param>
        /// <returns>Возвращает true, если логин и пароль верны</returns>
        static bool CheckPassword(string loginIn, string passwordIn)
        {
            string login = "root";
            string password = "GeekBrains";

            if (login == loginIn && password == passwordIn)
                return true;
            return false;
        }

        /// <summary>
        /// Функция чтения пароля с заменой символов пароля на символ '*'
        /// </summary>
        /// <returns>Возвращает введённый пароль</returns>
        static string ReadPassword()
        {
            string password = string.Empty;
            char sym;

            while ((sym = Console.ReadKey(true).KeyChar) != '\n' && sym != '\r')
            {
                if (sym == 8) // Поддержка работы клавиши Backspace
                {
                    //Console.WriteLine(password);
                    password = password.Remove(password.Length - 1);
                    //Console.WriteLine(password);
                    continue;
                }
                Console.Write('*');
                password += sym;
            }
            //Console.WriteLine(sym.KeyChar);
            //Console.WriteLine(password);

            return password;
        }

        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var specFunc = new  UtilityForStudy();
            int tries = 3;
            string login = string.Empty;
            string password = string.Empty;

            //Console.WriteLine((int)Console.ReadKey(true).KeyChar);

            do
            {
                if (tries <= 0)
                {
                    specFunc.Print("\nУ вас закончились попытки.\nДоступ закрыт.\n");
                    specFunc.Pause();
                    return;
                } else if (tries < 3)
                {
                    specFunc.Print(string.Format("\nУ вас осталось {0} попытки.\n", tries));
                }
                specFunc.Print("Введите логин:\n");
                login = Console.ReadLine();
                specFunc.Print("Введите пароль:\n");
                password = ReadPassword();
                //password = Console.ReadLine();

                tries--;
            } while (!CheckPassword(login, password));


            Console.WriteLine($"\nВы вошли в программу под {login}.");
            specFunc.Pause();

        }
    }
}

// 6. ***В заданной папке найти во всех html файлах теги <img src=...> и
// вывести названия картинок. Использовать регулярные выражения.
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using UtilityForStudyNameSpace;

namespace HW6_6
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
            string src = @"C:\temp";
            Console.WriteLine("Введите имя файла для html файлов.");
            PrintAllNumbers(LoadText(Console.ReadLine()).Split('<', '>'));
            //PrintAllNumbers(LoadText(src).Split('<', '>'));


            specFunc.Pause();
        }

        /// <summary>
        /// Загрузить текст из файл 
        /// </summary>
        /// <param name="path">Путь к файлам</param>
        /// <returns>Возвращает текст в виде строки</returns>
        static string LoadText(string path)
        {
            StringBuilder str = new StringBuilder(string.Empty);

            string[] filesName = Directory.GetFiles(path);

            for (int i = 0; i < filesName.Length; i++)
            {
                string[] tmp = filesName[i].Split('.');
                if (tmp[tmp.Length - 1] == "html")
                {
                    str.Append(File.ReadAllText(filesName[i]));
                }
            }
            
            return str.ToString();
        }

        /// <summary>
        /// Вывести ссылки из текста
        /// </summary>
        /// <param name="txt">Текст</param>
        static void PrintAllNumbers(string[] txt)
        {
            bool flag = false;
            Regex src = new Regex(@"img src=");
            int cnt = 0;
            for (int i = 0; i < txt.Length; i++)
                if (src.IsMatch(txt[i]))
                {
                    Console.Write($"{++cnt} ");
                    Console.WriteLine(txt[i].Split('\"')[1]);
                    flag = true;
                }

            if (!flag)
                Console.WriteLine("Ссылки на изображения не найдены.");
        }
    }
}

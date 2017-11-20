// 4. **В файле могут встречаться номера телефонов, записанные в формате
// xx-xx-xx, xxx-xxx или xxx-xx-xx. Вывести все номера телефонов, которые
// содержатся в файле.
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using UtilityForStudyNameSpace;

namespace HW6_4
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

            Console.WriteLine("Введите имя файла для поиска номеров.");
            PrintAllNumbers(LoadText(Console.ReadLine()).Split(' ', '\n', '\t', '\r'));

            specFunc.Pause();
        }

        /// <summary>
        /// Загрузить текст из файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns>Возвращает текст в виде строки</returns>
        static string LoadText(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        /// <summary>
        /// Вывести номера из текста
        /// </summary>
        /// <param name="txt">Текст</param>
        static void PrintAllNumbers(string[] txt)
        {
            bool flag = false;
            Regex number1 = new Regex(@"\d{3}(-\d\d){2}");
            Regex number2 = new Regex(@"\d{2}(-\d\d){2}");
            Regex number3 = new Regex(@"\d{3}-\d{3}");

            for (int i = 0; i < txt.Length; i++)
                if (txt[i].Length >= 7 &&  txt[i].Length <= 9 && (number1.IsMatch(txt[i]) || number2.IsMatch(txt[i]) || number3.IsMatch(txt[i])))
                {
                    Console.WriteLine(txt[i]);
                    flag = true;
                }

            if (!flag)
                Console.WriteLine("Номера не найдены.");
        }
    }
}

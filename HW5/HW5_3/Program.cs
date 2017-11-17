// 3. *Для двух строк написать метод, определяющий, является ли одна строка
// перестановкой другой. Регистр можно не учитывать.
// а) с использованием методов C#
// б) * разработав собственный алгоритм
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityForStudyNameSpace;

namespace HW5_3
{
    class Program
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string str1 = string.Empty, str2 = string.Empty;
            var specFunc = new UtilityForStudy();

            Console.WriteLine("Это программа проверяет являетсяли строки " +
                "перестановками друг друга");
            Console.WriteLine("Введите первую строку:");
            str1 = Console.ReadLine();
            Console.WriteLine("Введите второю строку:");
            str2 = Console.ReadLine();
            
            Console.WriteLine(string.Format("Строка 1: {0}\nСтрока 2: {1}",
                str1, str2));
            
            Console.WriteLine(string.Format(TaskA(str1, str2) ?
                "Строка 2 является перестановкой строки 1" : "Строка 2 не " +
                "является перестановкой строки 1"));

            Console.WriteLine(string.Format(CheckStringReshuffle(str1, str2) ?
                "Строка 2 является перестановкой строки 1" : "Строка 2 не " +
                "является перестановкой строки 1"));

            specFunc.Pause();
        }

        /// <summary>
        /// Метод выявления перестановки решения с использованием методов C#
        /// </summary>
        /// <param name="str1">1-ая строка</param>
        /// <param name="str2">2-ая строка</param>
        /// <returns>Возвращает true, если строки равносоставлены</returns>
        static bool TaskA(string str1, string str2)
        {
            char[] arr1, arr2;
            
            arr1 = str1.ToCharArray();
            arr2 = str2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            str1 = new string(arr1);
            str2 = new string(arr2);
            
            return str1.CompareTo(str2) == 0;
        }

        /// <summary>
        /// Метод позв-щий узнать, является ли одна строка переста-кой другой
        /// </summary>
        /// <param name="str1">1-ая строка</param>
        /// <param name="str2">2-ая строка</param>
        /// <returns>Возвращает true, если строки равносоставлены</returns>
        static bool CheckStringReshuffle(string str1, string str2)
        {
            int[] arr1 = new int[Convert.ToInt32(char.MaxValue) + 1];
            int[] arr2 = new int[Convert.ToInt32(char.MaxValue) + 1];
            //arr1[Convert.ToInt32(char.MaxValue)] = 0;

            if (str1.Length != str2.Length)
                return false;
            else if (str1 == string.Empty)
                return true;

            for (int i = 0; i < str1.Length; i++)
            {
                arr1[str1[i]]++;
                arr2[str2[i]]++;
            }

            for (int i = 0; i < arr1.Length; i++)
                if (arr1[i] != arr2[i])
                    return false;
            return true;
        }
    }
}

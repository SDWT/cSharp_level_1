// 2. Разработать методы для решения следующих задач. Дано сообщение:
// а) Вывести только те слова сообщения, которые содержат не более чем n букв;
// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;
// в) Найти самое длинное слово сообщения;
// г) Найти все самые длинные слова сообщения.
// Постараться разработать класс MyString.
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityForStudyNameSpace;

namespace HW5_2
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
            MyString str = new MyString("Privet Ya chelovek, a ti kto? Albolite");

            Console.WriteLine(str);
            Console.WriteLine(str.WordsLessNLetters(4));
            Console.WriteLine(str.WordsDeleteLastLetter('a'));
            Console.WriteLine(str.FirstMaxLengthWord());
            string[] strArr = str.MaxLengthWords();
            Console.WriteLine();
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i]);
            }

            specFunc.Pause();
        }
    }
}

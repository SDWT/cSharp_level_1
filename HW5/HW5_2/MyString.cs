using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2
{
    /// <summary>
    /// Класс моих строк
    /// </summary>
    class MyString
    {
        /// <summary>
        /// Строка
        /// </summary>
        private string str;

        /// <summary>
        /// Конструктор от строки
        /// </summary>
        /// <param name="str"></param>
        public MyString(string str)
        {
            this.str = str;
        }

        /// <summary>
        /// Метод по возвращению строки из слов меньших опр-ного кол-ва букв
        /// </summary>
        /// <param name="cntOfWord">Максимальное количество букв</param>
        /// <returns>Строка</returns>
        public string WordsLessNLetters(int cntOfWord)
        {
            if (cntOfWord < 1)
                return string.Empty;
            string[] strArr = str.Split(' ', ',', ';', ':', '.', '?',
                '.', '!');
            string[] strArrRet = new string[strArr.Length];
            int cnt = 0;

            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i].Length > 0 && strArr[i].Trim().Length <=
                    cntOfWord)
                {
                    strArrRet[cnt] = strArr[i];
                    cnt++;
                }
            }
            StringBuilder strReturn = new StringBuilder();
            for (int i = 0; i < cnt; i++)
            {
                strReturn.Append(strArrRet[i]);
                strReturn.Append(" ");
            }
            return strReturn.ToString();
        }

        /// <summary>
        /// Метод удаляющий слова с последним символом равным данному
        /// </summary>
        /// <param name="letter">символом</param>
        /// <returns>Строка</returns>
        public string WordsDeleteLastLetter(char letter)
        {
            string[] strArr = str.Split(' ');
            string[] strArrRet = new string[strArr.Length];
            int cnt = 0;

            // strArr[i][strArr[i].Length - 1]
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i].Length > 0 && strArr[i].Last() != letter)
                {
                    strArrRet[cnt] = strArr[i];
                    cnt++;
                }
            }

            StringBuilder strReturn = new StringBuilder();
            for (int i = 0; i < cnt; i++)
            {
                strReturn.Append(strArrRet[i]);
                strReturn.Append(" ");
            }
            return strReturn.ToString();
        }

        /// <summary>
        /// Первое слово наибольшой длины
        /// </summary>
        /// <returns>Строка</returns>
        public string FirstMaxLengthWord()
        {
            int mx = 0;
            string[] strArr = str.Split(' ', ',', ';', ':', '.', '?',
                '.', '!');
            string[] strArrRet = new string[strArr.Length];


            for (int i = 1; i < strArr.Length; i++)
            {
                if (strArr[mx].Length < strArr[i].Length)
                {
                    mx = i;
                }
            }

            return strArr[mx];
        }

        /// <summary>
        /// Возвращает массив слов максимальной длины
        /// </summary>
        /// <returns>Массив строк</returns>
        public string[] MaxLengthWords()
        {
            int mx = 0;
            string[] strArr = str.Split(' ', ',', ';', ':', '.', '?',
                '.', '!');
            int cnt = 1;

            for (int i = 1; i < strArr.Length; i++)
            {
                if (mx < strArr[i].Length)
                {
                    mx = strArr[i].Length;
                    cnt = 1;
                }
                else if (mx == strArr[i].Length)
                    cnt++;
            }

            string[] strReturn = new string[cnt];
            for (int i = 0, j = 0; i < strArr.Length; i++)
            {
                if (mx == strArr[i].Length)
                {
                    strReturn[j] = strArr[i];
                    j++;
                }
            }
            return strReturn;
        }
    }
}

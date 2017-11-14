using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW4_6
{
    class BaseOfGame
    {
        /// <summary>
        /// База вопросов
        /// </summary>
        private string[,] dataBase;
        /// <summary>
        /// Загружены ли вопросы
        /// </summary>
        private bool lBase;

        /// <summary>
        /// Количество вопросов в базе
        /// </summary>
        public int CntQuest
        {
            get
            {
                return dataBase.GetLength(0);
            }
        }
        /// <summary>
        /// Загружены ли вопросы
        /// </summary>
        public bool LBase
        {
            get { return lBase; }
        }

        /// <summary>
        /// Конструктор базы викторины
        /// </summary>
        public BaseOfGame()
        {
            lBase = true;
            if (!LoadBase())
            {
                lBase = false;
            }
        }

        /// <summary>
        /// Загрузить вопросы из файла
        /// </summary>
        /// <returns>true, если файл верный</returns>
        private bool LoadBase()
        {
            string[] str = new string[1];
            try
            {
                str = File.ReadAllLines("QB.qbf");
            }
            catch (Exception)
            {
                return false;
            }
            if (str[0] != "QuizBaseFile")
                return false;

            dataBase = new string[int.Parse(str[1]), 2];

            for (int j = 0; j < dataBase.GetLength(0); j++)
            {
                dataBase[j, 0] = str[2 + 2 * j];
                dataBase[j, 1] = str[3 + 2 * j];
            }
            //Print();
            return true;
        }

        /// <summary>
        /// Сохранить вопросы в файл
        /// </summary>
        private void SaveBase()
        {
            File.WriteAllText("QB.qbf", "QuizBaseFile\n");

            var stream = File.AppendText("QB.qbf");
            stream.WriteLine(string.Format("{0}",
                dataBase.GetLength(0)));

            for (int j = 0; j < dataBase.GetLength(0); j++)
            {
                stream.WriteLine(dataBase[j, 0]);
                stream.WriteLine(dataBase[j, 1]);
            }

            stream.Close();
        }

        /// <summary>
        /// Метод вывода вопросов в консоль (для проверки загрузки)
        /// </summary>
        private void Print()
        {
            Console.WriteLine(dataBase.GetLength(0));
            for (int j = 0; j < dataBase.GetLength(0); j++)
            {
                Console.WriteLine(dataBase[j, 0] + " " + dataBase[j, 1]);
            }
        }

        /// <summary>
        /// Метод вопроса и проверки ответа
        /// </summary>
        /// <param name="indexQuestion">Номер вопроса (от 0)</param>
        /// <returns>Возвращает true если ответ с консоли правильный.</returns>
        public bool QuestionAnswer(int indexQuestion)
        {
            if (dataBase.GetLength(0) > indexQuestion)
            {
                Console.WriteLine($"Вопрос: {dataBase[indexQuestion, 0]}");
                if (Console.ReadLine().ToLower()[0] == dataBase[indexQuestion, 1].ToLower()[0])
                    return true;
            }
            return false;
        }
    }
}

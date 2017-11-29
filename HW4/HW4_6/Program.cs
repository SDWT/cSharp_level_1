// 6. ***Написать игру “Верю. Не верю”.
// В файле хранятся некоторые данные и правда это или нет.
// Например: “Шариковую ручку изобрели в древнем Египте”, “Да”.
//
// Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и
// задает их игроку.
// Игрок пытается ответить правда или нет, то что ему загадали и набирает баллы
// Список вопросов ищите во вложении или можно воспользоваться Интернетом.
//
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityForStudyNameSpace;

namespace HW4_6
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
            bool isGame = true;

            do
            {
                Console.WriteLine("Выберите:\n" +
                    "1 - запустить викторину;\n" +
                    "0 - выход.\n");
                switch (Console.ReadKey(false).KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine(string.Format("Количество правильных ответов: {0}", StartQuiz()));
                        specFunc.Pause();
                        break;
                    case '0':
                        isGame = false;
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (isGame);
            specFunc.Pause();
        }

        /// <summary>
        /// Запуск викторины
        /// </summary>
        /// <returns>Возвращает количество правильных ответов</returns>
        static int StartQuiz()
        {
            BaseOfGame a = new BaseOfGame();
            if (!a.LBase)
            {
                Console.WriteLine("Вопросы не найдены!");
                return 0;
            }
            var number = new Random();
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Здравствуйте, это Викторина.\n" +
                "Отвечайте на вопросы \"Верю\" или " +
                "\"Не верю\".\n");
                if (a.QuestionAnswer(number.Next() % a.CntQuest))
                    score++;
                Console.Clear();
            }

            return score;
        }
    }
}

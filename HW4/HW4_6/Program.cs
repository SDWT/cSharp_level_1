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

            specFunc.Pause();
        }
    }
}

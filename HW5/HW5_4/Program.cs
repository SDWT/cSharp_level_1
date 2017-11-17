// 4. *Задача ЕГЭ.
// На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов
// некоторой средней школы.В первой строке сообщается количество учеников N,
// которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет
// следующий формат:
// <Фамилия> <Имя> <оценки>,
// где <Фамилия> – строка, состоящая не более чем из 20 символов, <Имя> –
// строка, состоящая не более чем из 15 символов, <оценки> – через пробел три
// целых числа, соответствующие оценкам по пятибалльной системе. <Фамилия> и
// <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной
// строки:
// Иванов Петр 4 5 3
// Требуется написать как можно более эффективную программу, которая будет
// выводить на экран фамилии и имена трех худших по среднему баллу учеников.
// Если среди остальных есть ученики, набравшие тот же средний балл, что и один
// из трех худших, то следует вывести и их фамилии и имена.
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityForStudyNameSpace;

namespace HW5_4
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

            int n = int.Parse(Console.ReadLine());
            Student[] stds = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Student std = new Student(Console.ReadLine().Split(' '));
                int j = i - 1;
                for (j = i - 1; j >= 0; j--)
                    if (stds[j].AverageMark > std.AverageMark)
                        stds[j + 1] = stds[j];
                    else
                        break;
                stds[j + 1] = std;
            }

            int cnt = 3, k = 0;
            do
            {
                Console.WriteLine(stds[k]);
                k++;
                cnt--;
            }
            while (cnt > 0 || stds[k].AverageMark == stds[k - 1].AverageMark);


            specFunc.Pause();
        }
    }
}

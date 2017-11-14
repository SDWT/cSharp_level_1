// 5. **Существует алгоритмическая игра “Удвоитель”. В этой игре человеку
// предлагается какое-то число, а человек должен, управляя роботом “Удвоитель”,
// достичь этого числа за минимальное число шагов. Робот умеет выполнять 
// несколько команд: увеличить число на 1, умножить число на 2 и сбросить число
// до 1. Начальное значение удвоителя равно 1.
//
// Реализовать класс “Удвоитель”. Класс хранит в себе поле current - текущее
// значение, finish - число, которого нужно достичь, конструктор,
// в котором задается конечное число.Методы: увеличить число на 1, увеличить
// число в два раза, сброс текущего до 1, свойство Current, которое возвращает
// текущее значение, свойство Finish, которое возвращает конечное значение.
// Создать с помощью этого класса игру, в которой компьютер загадывает число,
// а человек.выбирая из меню на экране, отдает команды удвоителю и старается
// получить это число за наименьшее число ходов.Если человек получает число
// больше положенного, игра прекращается.
//
// Samsonov


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityForStudyNameSpace;

namespace HW4_5
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
            var dataGames = new Doubler();
            bool isGame = true;
            int cntStep = 0;

            Console.WriteLine("Здравствуйте, это игра Удвоитель.\n" +
                "Вам необходимо с помощью действий \"умножения числа на 2\" и " +
                "\"прибавления на 1\" получить данное число.");

            do
            {
                Console.WriteLine(string.Format("Текущее: {0}, " +
                    "Необходимое: {1}, Количество шагов {2}:\n", 
                    dataGames.Current, dataGames.Finish, cntStep++));
                Console.WriteLine("Действия:\n" +
                    "1 - текущее значение увеличить на 1;\n" +
                    "2 - удвоить текущее значение;\n" +
                    "3 - перезагрузить игру;\n" +
                    "0 - выход.\n");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        dataGames.Step(Doubler.Action.Up1);
                        break;
                    case '2':
                        dataGames.Step(Doubler.Action.Multy2);
                        break;
                    case '3':
                        Console.WriteLine("\n\nВнимание!!!\n" +
                            "Текущий прогресс будет потерян. " +
                            "Необходимое значение не будет изменено.\n" +
                            "Если вы уверены введите текущее значение " +
                            "и нажмите клавишу Enter.");
                        int Number;
                        int.TryParse(Console.ReadLine(), out Number);
                        if (Number == dataGames.Current)
                        {
                            Console.Clear();
                            Console.WriteLine("Перезагрузка!");
                            dataGames.Step(Doubler.Action.return1);
                            cntStep = 0;
                        }
                        cntStep--;
                        break;
                    case '0':
                        isGame = false;
                        break;
                    default:
                        cntStep--;
                        break;
                }
                if (dataGames.Current >= dataGames.Finish)
                {
                    if (dataGames.Current == dataGames.Finish)
                        Console.WriteLine(string.Format("\rВеликолепно! " +
                            "Вы достигли необходимого значения. " +
                            "Количество шагов: {0}", cntStep));
                    else
                        Console.WriteLine("\rК сожалению вы " +
                            "превысили необходимое значение.");
                    Console.WriteLine("Хотите сыграть ещё раз?\n" +
                        "Введите \"Yes\" or \"No\"?");
                    isGame = false;
                    bool isAnswer;

                    do
                    {
                        string answer = Console.ReadLine();
                        isAnswer = false;
                        switch (answer)
                        {
                            case "yes":
                            case "Yes":
                                dataGames = new Doubler();
                                isGame = true;
                                break;
                            case "no":
                            case "No":
                                break;
                            default:
                                isAnswer = true;
                                break;
                        }
                    } while (isAnswer);
                }

                Console.Clear();
            } while (isGame);
            Console.WriteLine("Пока.");
            specFunc.Pause();
        }
    }
}

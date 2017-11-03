// 5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город
//проживания. б) *Сделать задание, только вывод организуйте в центре экрана
//в) **Сделать задание б с использованием собственных методов (например,
//Print(string ms, int x,int y) 
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_5
{
    class Program
    {
        static void HW_a(string Info)
        {
            Console.WriteLine(Info);
        }

        static void HW_b(string Info)
        {
            int x = Console.WindowWidth / 2, y = Console.WindowHeight / 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(Info);
        }

        static void HW_c(string Info)
        {
            var Pr = new FunctionsForStudy();
            Pr.PrintCenter(Info);
        }

        static void Main(string[] args)
        {
            string Info = "Samsonov Dmitry 1999 Saint-Petersburg";
            var Pr = new FunctionsForStudy();

            //HW_a(Info);
            //HW_b(Info);
            //HW_c(Info);
            Pr.Print(Info, (Console.WindowWidth - Info.Length)/ 2, Console.WindowHeight / 2);
            Pr.Pause();
        }
    }

    class FunctionsForStudy
    {
        public void Pause()
        {
            Console.ReadKey();
        }

        public void PrintCenter(string msg)
        {
            int x = Console.WindowWidth / 2, y = Console.WindowHeight / 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Print(string msg, int x, int y)
        {
            if (x >= 0 && x < Console.WindowWidth && y >= 0 && y < Console.WindowHeight)
                Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
    }

}

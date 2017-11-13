// 4. *а) Реализовать класс для работы с двумерным массивом. Реализовать
// конструктор, заполняющий массив случайными числами. Создать методы, которые
// возвращают сумму всех элементов массива, сумму всех элементов массива больше
// заданного, свойство, возвращающее минимальный элемент массива, свойство,
// возвращающее максимальный элемент массива, метод, возвращающий номер
// максимального элемента массива (через параметры, используя модификатор ref
// или out)
// ** б) Добавить конструктор и методы, которые загружают данные из файла и
// записывают данные в файл.
// Samsonov


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using UtilityForStudyNameSpace;

namespace HW4_4
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
            DoubleArray list = new DoubleArray(10, 5);
            int iW, iH;
            list.PlaceMaxElement(out iW, out iH);


            Console.WriteLine(list);
            //Console.WriteLine($"{double.MinValue} {double.MaxValue * -1} {double.MinValue <= double.MaxValue * -1}");
            Console.WriteLine(list.SumOfElements());
            Console.WriteLine(list.SumOfElements(950));
            Console.WriteLine($"Минимальный элемент: {list.MinElement}");
            Console.WriteLine($"Максимальный элемент: {list.MaxElement}:");
            Console.WriteLine(string.Format("Положение по горизонтали: {0}, Положение по вертикали: {1}", iW, iH));
            list.SaveToFile("savebase.pt");
            list.LoadFromFile("savebase.pt");
            Console.WriteLine();
            Console.WriteLine(list);


            specFunc.Pause();
        }
    }
}

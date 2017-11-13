// 1. Дан целочисленный массив из 20 элементов. Элементы массива могут
// принимать целые значения от –10 000 до 10 000 включительно. Написать
// программу, позволяющую найти и вывести количество пар элементов массива,
// в которых хотя бы одно число делится на 3. В данной задаче под парой
// подразумевается два подряд идущих элемента массива. Например, для массива
// из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
//
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityForStudyNameSpace;

namespace HW4_1
{
    class Program
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int cntArrEl = 20;
            var specFunc = new UtilityForStudy();
            int[] arr = new int[cntArrEl];

            for (int i = 0; i < cntArrEl; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(CountOfPair(arr));
            specFunc.Pause();
        }

        /// <summary>
        /// Метод, считающий количество пар, одно из чисел в паре кратно 3
        /// </summary>
        /// <param name="arr">Данный массив</param>
        /// <returns>Количество пар</returns>
        static int CountOfPair(int[] arr)
        {
            int cnt = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] * arr[i + 1]) % 3 == 0)
                    cnt++;
            }
            return cnt;
        }
    }
}

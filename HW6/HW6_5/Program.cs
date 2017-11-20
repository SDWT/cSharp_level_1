// Сложная задача ЕГЭ<param name="maxElements"></param>
// Для заданной последовательности неотрицательных целых чисел необходимо найти
// максимальное произведение двух её элементов, номера которых различаются не
// менее, чем на 8. Значение каждого элемента последовательности не превышает
// 100 000. Количество элементов последовательности равно 100 000.
// Сгенерировать файл из случайных чисел и решить эту задачу.

// 5. **Модифицировать задачу “Сложную задачу” ЕГЭ так, чтобы она решала задачу
// с 10 000 000 элементов менее чем за минуту.

// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UtilityForStudyNameSpace;

namespace HW6_5
{
    class Program
    {
        /// <summary>
        /// Метод для записи в файл произвольных чисел от 0 до 100000
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="n">количество произвольных чисел для записи</param>
        static void Save(string fileName, int n)
        {
            Random rnd = new Random();
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 1; i < n; i++)
            {
                bw.Write(rnd.Next(0, 100000)); // int - занимает 4 байта
            }

            fs.Close(); bw.Close();
        }

        /// <summary>
        /// Метод для чтения из файла чисел типа int 
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        static void Load(string fileName)
        {
            DateTime d = DateTime.Now;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int[] a = new int[fs.Length / 4];


            for (int i = 0; i < fs.Length / 4; i++) // int - занимает 4 байта
            {
                a[i] = br.ReadInt32();
            }

            br.Close();
            fs.Close();

            int max = 0;

            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length; j++)
                    if (Math.Abs(i - j) >= 8 && a[i] * a[j] > max)
                        max = a[i] * a[j];

            Console.WriteLine(max);
            Console.WriteLine(DateTime.Now - d);
        }

        /// <summary>
        /// Метод для чтения и поиска масимальных элементов в последо-ти
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="maxElements">Массив максимальных элементов</param>
        /// <param name="maxElementsId">Массив индексов максимальных элементов</param>
        static void Load2(string fileName, ref int[] maxElements, ref int[] maxElementsId)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            
            int x;

            for (int i = 0; i < fs.Length / 4; i++) // int - занимает 4 байта
            {
                x = br.ReadInt32();
                for (int j = 0; j < maxElements.Length; j++)
                    if (maxElements[j] < x)
                    {
                        for (int k = maxElements.Length - 1; k > j; k--)
                        {
                            maxElements[k] = maxElements[k - 1];
                            maxElementsId[k] = maxElementsId[k - 1];
                        }
                        maxElements[j] = x;
                        maxElementsId[j] = i;
                        break;
                    }
            }
            br.Close();
            fs.Close();
        }

        /// <summary>
        /// Поиск максимального произведения 2-ух чисел с учётом
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns>Максимальное произведение 2-ух эл-тов с ограничениями</returns>
        static int FindMaxMulty(string fileName)
        {
            const int maxEl = 16;
            int[] maxElements = new int[maxEl];
            int[] maxElementsId = new int[maxEl];

            Load2("data.bin", ref maxElements, ref maxElementsId);
            int max = 0;

            // Достаточно помнить 8 максимальных элементов и их индексы, т.к. если максимальные элементы в порядке возрастания, 
            // то максимальный элемент * максимальный элемент с индексом - 8 будет максимальным произведением

            for (int i = 0; i < maxElements.Length; i++)
                for (int j = 0; j < maxElements.Length; j++)
                    if (Math.Abs(maxElementsId[i] - maxElementsId[j]) >= 8 && maxElements[i] * maxElements[j] > max)
                        max = maxElements[i] * maxElements[j];

            return max;
        }

        /// <summary>
        /// Задача 5 описание вверху
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="cntOfElements">количество произвольных чисел для записи</param>
        static void Task5(string fileName, int cntOfElements)
        {
            Save(fileName, cntOfElements);
            DateTime d = DateTime.Now;
            Console.WriteLine(FindMaxMulty(fileName));
            Console.WriteLine(DateTime.Now - d);
        }

        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var specFunc = new UtilityForStudy();

            Task5("data.bin", 10_000_000);
            //Save("data.bin", 10_000_000);
            //Load2("data.bin");
            
            specFunc.Pause();
        }
    }
}

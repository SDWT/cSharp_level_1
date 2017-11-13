using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HW4_4
{
    class DoubleArray
    {
        /// <summary>
        /// Двумерный массив хранения чисел
        /// </summary>
        private double[,] table;
        /// <summary>
        /// Минимальный элемент в массиве
        /// </summary>
        private double minEl;
        /// <summary>
        /// Максимальный элемент в массиве
        /// </summary>
        private double maxEl;

        /// <summary>
        /// Свойство максимального элемента
        /// </summary>
        public double MaxElement
        {
            get { return maxEl; }
        }

        /// <summary>
        /// Свойство минимального элемента
        /// </summary>
        public double MinElement
        {
            get { return minEl; }
        }

        /// <summary>
        /// Конструктор от ширины и высоты двумерного массива
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        public DoubleArray(int width, int height)
        {
            var rand = new Random();
            double multi = Convert.ToDouble(1000);

            minEl = double.MaxValue;
            maxEl = double.MinValue;

            table = new double[width, height];
            for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                {
                    double x = rand.NextDouble() * multi;
                    table[i, j] = x;
                    if (x < minEl)
                        minEl = x;
                    else if (x > maxEl)
                        maxEl = x;
                }
        }

        // Для проверки записи и чтения из файла
        //public DoubleArray()
        //{
        //    table = new double[5, 10];
        //    for (int j = 0; j < table.GetLength(1); j++)
        //        for (int i = 0; i < table.GetLength(0); i++)
        //            table[i, j] = j * table.GetLength(0) + i;
        //}

        /// <summary>
        /// Метод нахождения суммы эллементов ">=" данного числа
        /// </summary>
        /// <param name="min">Данное число, по умолчанию сумму всех</param>
        /// <returns>Сумма элементов</returns>
        public double SumOfElements(double min = double.MinValue)
        {
            double sum = 0;
            for (int j = 0; j < table.GetLength(1); j++)
                for (int i = 0; i < table.GetLength(0); i++)
                    sum += table[i, j] >= min ? table[i, j] : 0;
            return sum;
        }

        /// <summary>
        /// Нахождение позиции данного элемента (от 0)
        /// </summary>
        /// <param name="widthIndex">Индекс по ширине</param>
        /// <param name="heightIndex">Индекс по высоте</param>
        public void PlaceMaxElement(out int widthIndex, out int heightIndex)
        {
            widthIndex = -1;
            heightIndex = -1;
            for (int j = 0; j < table.GetLength(1); j++)
                for (int i = 0; i < table.GetLength(0); i++)
                    if (table[i, j] == maxEl)
                    {
                        widthIndex = i;
                        heightIndex = j;
                        return;
                    }
        }

        /// <summary>
        /// Перегрузка метода для класса двумерного массива в строку.
        /// </summary>
        /// <returns>Строку</returns>
        override public string ToString()
        {
            string str = string.Empty;

            for (int j = 0; j < table.GetLength(1); j++)
            {
                for (int i = 0; i < table.GetLength(0); i++)
                    str += string.Format("{0:F2} ", table[i, j]);
                str += "\n";
            }

            return str;
        }

        /// <summary>
        /// Запись двумерного массива в файл по имени файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        public void SaveToFile(string fileName)
        {
            File.WriteAllText(fileName, string.Format("{0}\n",
                table.GetLength(0)));

            var stream = File.AppendText(fileName);
            stream.WriteLine(string.Format("{0}",
                table.GetLength(1)));

            for (int j = 0; j < table.GetLength(1); j++)
                for (int i = 0; i < table.GetLength(0); i++)
                    stream.WriteLine(table[i, j]);

            stream.Close();
        }

        /// <summary>
        /// Чтение двумерного массива из файла по имени файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        public void LoadFromFile(string fileName)
        {
            string[] str = File.ReadAllLines(fileName);

            table = new double[int.Parse(str[0]), int.Parse(str[1])];
            //Console.WriteLine($"{table.GetLength(0)} {table.GetLength(1)}");
            for (int j = 0; j < table.GetLength(1); j++)
                for (int i = 0; i < table.GetLength(0); i++)
                    table[i, j] = double.Parse(str[2 + j * table.GetLength(0) + i]);
        }
    }
}

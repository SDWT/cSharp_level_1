using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_4
{
    /// <summary>
    /// 
    /// </summary>
    class Student
    {
        /// <summary>
        /// Средняя оценка
        /// </summary>
        private double averageMark;

        /// <summary>
        /// Строки имени и фамилии
        /// </summary>
        private string name, surname;

        /// <summary>
        /// Свойство средней оценки
        /// </summary>
        public double AverageMark
        {
            get { return averageMark; }
        }

        /// <summary>
        /// Конструктор от массива строк
        /// </summary>
        /// <param name="info">Массив строк</param>
        public Student(string[] info)
        {
            surname = info[0];
            name = info[1];
            averageMark = (int.Parse(info[2]) + int.Parse(info[3]) + int.Parse(info[4])) / 3.0;
        }

        /// <summary>
        /// Конструктор от элементов
        /// </summary>
        /// <param name="Surname">Фамилия</param>
        /// <param name="Name">Имя</param>
        /// <param name="Mark1">1-ая оценка</param>
        /// <param name="Mark2">2-ая оценка</param>
        /// <param name="Mark3">3-ья оценка</param>
        public Student(string Surname, string Name, int Mark1, int Mark2, int Mark3)
        {
            name = Name;
            surname = Surname;
            averageMark = (Mark1 + Mark2 + Mark3) / 3.0;
        }

        /// <summary>
        /// Перегрузка метода для класса студента в строку.
        /// </summary>
        /// <returns>Строку</returns>
        override public string ToString()
        {
            string str = string.Format("{0} {1}", surname, name);
            return str;
        }
    }
}

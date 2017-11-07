// 5. а) Написать программу, которая запрашивает массу и рост человека,
// вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать
// вес или все в норме;
// б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityForStudyNameSpace;


namespace HW2_5
{
    class Program
    {
        /// <summary>
        /// Функция, которая считает индекс массы
        /// </summary>
        /// <param name="m">Масса</param>
        /// <param name="h">Рост</param>
        /// <returns>Возвращяает индекс массы</returns>
        static double IndexMass(double m, double h)
        {
            return m / (h * h);
        }

        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const double indexMassMax = 24.9;
            const double indexMassMin = 18.6;


            var specFunc = new  UtilityForStudy();
            Console.WriteLine("Введите массу тела в килограммах.");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост тела в метрах.");
            double h = double.Parse(Console.ReadLine());
            double im = IndexMass(m, h);

            double bestM = 21 * h * h;

            if (im < indexMassMin - 0.1)
                Console.WriteLine(string.Format("Вам необходимо набрать {0:F2} кг.\nВам желательно набрать {1:F2} кг.", indexMassMin * h * h - m, bestM - m));
            else if (im > indexMassMax + 0.1)
                Console.WriteLine(string.Format("Вам необходимо похудеть на {0:F2} кг.\nВам желательно похудеть на {1:F2} кг.", m - indexMassMax * h * h, m - bestM));
            else
                Console.WriteLine(string.Format("Вам вес находится в пределах нормы."));

            specFunc.Pause();
        }
    }
}

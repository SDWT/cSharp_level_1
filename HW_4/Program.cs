// 4. Написать программу обмена значениями двух переменных
// а) с использованием третьей переменной;
// б) * без использования третьей переменной.
// Samsonov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_4
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Swap2(ref double a, ref double b)
        {
            a += b;
            b = a - b;
            a -= b;

        }

        static void Main(string[] args)
        {
            double a = 1.4, b = 3.2;
            int c = 10, d = 12;
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}", a, b, c, d);

            //Swap<double>(ref a, ref b);
            Swap2(ref a, ref b);
            Swap<int>(ref c, ref d);

            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}", a, b, c, d);
            Console.ReadKey();
        }
    }
}

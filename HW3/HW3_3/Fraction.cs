using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    /// <summary>
    /// Класс дробей
    /// </summary>
    class Fraction
    {
        /// <summary>
        /// Числитель
        /// </summary>
        private int p;
        /// <summary>
        /// Знаменатель
        /// </summary>
        private int q;

        /// <summary>
        /// Конструктор от числителя и знаминателя дроби
        /// </summary>
        /// <param name="p">Числитель</param>
        /// <param name="q">Знаменатель</param>
        public Fraction(int p = 0, int q = 1)
        {
            this.p = p;
            this.q = q;
            this.Simplefication();
        }

        /// <summary>
        /// Конструктор от дроби
        /// </summary>
        /// <param name="a">Дробь</param>
        public Fraction(Fraction a)
        {
            p = a.p;
            q = a.q;
            this.Simplefication();
        }

        /// <summary>
        /// Перегрузка метода для преобразования дроби в строку.
        /// </summary>
        /// <returns>Строку</returns>
        override public string ToString()
        {
            if (q == 0)
                return string.Format("infinity");
            else if (q == 1)
                return string.Format("{0}", p);
            else if (p < 0)
                return string.Format("({0})/{1}", p, q);
            else
                return string.Format("{0}/{1}", p, q);
        }

        /// <summary>
        /// Упрощение дроби
        /// </summary>
        public Fraction Simplefication()
        {
            if (q == 0 || p == 0)
                return this;
            if (q < 0)
            {
                this.q *= -1;
                this.p *= -1;
            }

            int x = Math.Abs(p), y = Math.Abs(q);
            if (x > y)
            {
                int tmp = x;
                x = y;
                y = tmp;
            }
            while (x > 0)
            {
                int tmp = y % x;
                y = x;
                x = tmp;
            }

            p /= y;
            q /= y;

            return this;
        }

        /// <summary>
        /// Упрощение дроби
        /// </summary>
        /// <param name="a">Дробь</param>
        /// <returns>Упрощённая дробь</returns>
        public static Fraction Simplefication(ref Fraction a)
        {
            if (a.q == 0 || a.p == 0)
                return a;
            if (a.q < 0)
            {
                a.q *= -1;
                a.p *= -1;
            }

            int x = Math.Abs(a.p), y = Math.Abs(a.q);
            if (x > y)
            {
                int tmp = x;
                x = y;
                y = tmp;
            }
            while (x > 0)
            {
                int tmp = y % x;
                y = x;
                x = tmp;
            }

            a.p /= y;
            a.q /= y;

            return a;
        }

        /// <summary>
        /// Перегрузка оператора сложения для комплексных чисел
        /// </summary>
        /// <param name="a">1 дробь</param>
        /// <param name="b">2 Дробь</param>
        /// <returns>Возвращает дробь равное сумме дробей</returns>
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.p * b.q + a.q * b.p, a.q * b.q).Simplefication();
        }

        /// <summary>
        /// Перегрузка оператора '-' для разности комплексных чисел
        /// </summary>
        /// <param name="a">Уменьшаемое комплексное число</param>
        /// <param name="b">Вычитаемое комплексное число</param>
        /// <returns>Возвращает дробь равную разности дробей</returns>
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.p * b.q - a.q * b.p, a.q * b.q).Simplefication();
        }

        /// <summary>
        /// Перегрузка унарного оператора '-' для дроби
        /// </summary>
        /// <param name="a">Данное комплексное число</param>
        /// <returns>Возвращает дробь равную противоположной дроби</returns>
        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.p, a.q).Simplefication();
        }

        /// <summary>
        /// Перегрузка оператора '*' для комплексных дробей
        /// </summary>
        /// <param name="a">1 дробь</param>
        /// <param name="b">2 Дробь</param>
        /// <returns>Возвращает дробь равную произведению дробей</returns>
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.p * b.p, a.q * b.q).Simplefication();
        }

        /// <summary>
        /// Перегрузка оператора '/' для дробей
        /// </summary>
        /// <param name="a">Делиммое</param>
        /// <param name="b">Делитель</param>
        /// <returns>Возвращает дробь равную делению дробей</returns>
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.p * b.q, a.q * b.p).Simplefication();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_1
{
    /// <summary>
    /// Класс комплексных чисел
    /// </summary>
    class Complex
    {
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double im;
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double re;

        /// <summary>
        /// Конструктор комплексного числа по умолчанию
        /// </summary>
        public Complex()
        {
            im = 0;
            re = 0;
        }

        /// <summary>
        ///Конструктор комплексного числа от действительного и мнимого значения
        /// </summary>
        /// <param name="Re">Данное действительное значение</param>
        /// <param name="Im">Данное мнимое значение</param>
        public Complex(double Re, double Im = 0)
        {
            this.im = Im;
            this.re = Re;
        }

        /// <summary>
        /// Конструктор комплексного числа от данного комплексного числа
        /// </summary>
        /// <param name="Other">Данное комплексное число</param>
        public Complex(Complex Other)
        {
            this.im = Other.im;
            this.re = Other.re;
        }

        /// <summary>
        /// Метод сложения комплексного числа с данным комплексом числом
        /// </summary>
        /// <param name="Other">Данное комплексное число</param>
        /// <returns>Возвращает комплексное число равное сумме чисел</returns>
        public Complex Plus(Complex Other)
        {
            Complex tmp = new Complex(this.re + Other.re, this.im + Other.im);
            return tmp;
        }

        /// <summary>
        /// Метод hfpyjcnb комплексного числа с данным комплексом числом
        /// </summary>
        /// <param name="a">Данное комплексное число</param>
        /// <returns>Возвращает комплексное число равное разности</returns>
        public Complex Minus(Complex a)
        {
            Complex tmp = new Complex(this).Plus(-a);
            return tmp;
        }

        /// <summary>
        /// Метод произведения комплексного числа с данным комплексом числом
        /// </summary>
        /// <param name="Other">Данное комплексное число</param>
        /// <returns>>Возвращает комплексное число равное произв-нию</returns>
        public Complex Multi(Complex Other)
        {
            Complex tmp = new Complex(re * Other.re - im * Other.im,
                re * Other.im + im * Other.re);
            return tmp;
        }

        /// <summary>
        /// Перегрузка оператора сложения для комплексных чисел
        /// </summary>
        /// <param name="a">1 комплексное число</param>
        /// <param name="b">2 комплексное число</param>
        /// <returns>Возвращает комплексное число равное сумме чисел</returns>
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a).Plus(b);
        }

        /// <summary>
        /// Перегрузка оператора '-' для разности комплексных чисел
        /// </summary>
        /// <param name="a">Уменьшаемое комплексное число</param>
        /// <param name="b">Вычитаемое комплексное число</param>
        /// <returns>Возвращает комплексное число равное разности ч.</returns>
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a).Plus(-b);
        }

        /// <summary>
        /// Перегрузка унарного оператора '-' для комплексного числа
        /// </summary>
        /// <param name="a">Данное комплексное число</param>
        /// <returns>Возвращает комплексное число равное -комп. ч.</returns>
        public static Complex operator -(Complex a)
        {
            return new Complex(-a.re, -a.im);
        }

        /// <summary>
        /// Перегрузка оператора '*' для комплексных чисел
        /// </summary>
        /// <param name="a">1 комплексное число</param>
        /// <param name="b">2 комплексное число</param>
        /// <returns>Возвращает комплексное число равное произв-нию</returns>
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a).Multi(b);
        }

        /// <summary>
        /// Перегрузка метода для преобразования комплексного числа в строку.
        /// </summary>
        /// <returns>Строку</returns>
        override public string ToString()
        {
            if (im == 0)
                return string.Format("{0}", re);
            else if (re == 0)
                return string.Format("{0}i", im);
            else if (im == -1)
                return string.Format("({0} - i)", re);
            else if (im == 1)
                return string.Format("({0} + i)", re);
            else if (im < 0)
                return string.Format("({0} - {1}i)", re, -im);
            else
                return string.Format("({0} + {1}i)", re, im);
        }

        ///// <summary>
        ///// Перегрузка оператора == на равенство комплексных чисел
        ///// </summary>
        ///// <param name="a">1 комплексное число</param>
        ///// <param name="b">2 комплексное число</param>
        ///// <returns>Возвращает true, если числа равны, иначе false</returns>
        //public static bool operator ==(Complex a, Complex b)
        //{
        //    if (a.re == b.re && a.im == b.im)
        //        return true;
        //    return false;
        //}

        ///// <summary>
        ///// Перегрузка оператора == на равенство комплексных чисел
        ///// </summary>
        ///// <param name="a">1 комплексное число</param>
        ///// <param name="b">2 комплексное число</param>
        ///// <returns>Возвращает true, если числа не равны, иначе false</returns>
        //public static bool operator !=(Complex a, Complex b)
        //{
        //    if (a.re != b.re || a.im != b.im)
        //        return true;
        //    return false;
        //}
    }
}

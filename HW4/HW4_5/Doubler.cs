using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_5
{
    /// <summary>
    /// Класс удвоителя
    /// </summary>
    class Doubler
    {
        /// <summary>
        /// Текущее значение
        /// </summary>
        private int current;
        /// <summary>
        /// Необходимое значение
        /// </summary>
        private int finish;

        /// <summary>
        /// Перечисляемый тип действий с текущем значением
        /// </summary>
        public enum Action
        {
            Up1, Multy2, return1
        }

        /// <summary>
        /// Свойства текущего значения
        /// </summary>
        public int Current
        {
            get { return this.current; }
        }

        /// <summary>
        /// Свойства необходимого значения
        /// </summary>
        public int Finish
        {
            get { return this.finish; }
        }
        
        /// <summary>
        /// Конструктор удвоителя
        /// </summary>
        public Doubler()
        {
            current = 1;
            finish = Convert.ToInt32(new Random().NextDouble() * 1000 + 2);
        }

        /// <summary>
        /// Шаг игры удвоителя
        /// </summary>
        /// <param name="action">Действие для выполнения</param>
        public void Step(Action action)
        {
            switch (action)
            {
                case Action.Up1:
                    current += 1;
                    break;
                case Action.Multy2:
                    current *= 2;
                    break;
                case Action.return1:
                    current = 1;
                    break;
                default:
                    break;
            }
        }
    }
}

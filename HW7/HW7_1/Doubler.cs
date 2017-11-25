using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HW7_1
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

        private Stack<Action> actions;

        /// <summary>
        /// Перечисляемый тип действий с текущем значением
        /// </summary>
        public enum Action
        {
            Up1, Multy2, Return1, Cancel1
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
            actions = new Stack<Action>();
            current = 1;
            finish = Convert.ToInt32(new Random().NextDouble() * 1000 + 2);
            
        }

        /// <summary>
        /// Шаг игры удвоителя
        /// </summary>
        /// <param name="action">Действие для выполнения</param>
        public void Step(Action action)
        {
            if (action != Action.Cancel1)
            {
                actions.Push(action);
                switch (action)
                {
                    case Action.Up1:
                        current += 1;
                        break;
                    case Action.Multy2:
                        current *= 2;
                        break;
                    case Action.Return1:
                        current = 1;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if (current == 1)
                    return;
                action = actions.Pop();
                switch (action)
                {
                    case Action.Up1:
                        current -= 1;
                        break;
                    case Action.Multy2:
                        current /= 2;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}

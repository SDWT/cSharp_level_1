using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_3
{
    /// <summary>
    /// Данных формы
    /// </summary>
    public class FormData
    {
        private string director;
        private string company;
        private string name;
        private string nameSp;
        private string position;
        private DateTime day;
        private DateTime dayStart;
        private DateTime dayFinish;
        /// <summary>
        /// Имя директора
        /// </summary>
        public string Director
        {
            get { return director;  }
            set { director = value; }
        }
        /// <summary>
        /// Название фирмы/компании
        /// </summary>
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// Имя в родительном падеже
        /// </summary>
        public string NameSp
        {
            get { return nameSp; }
            set { nameSp = value; }
        }
        /// <summary>
        /// Должность
        /// </summary>
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        /// <summary>
        /// Сегодняшний день
        /// </summary>
        public DateTime Day
        {
            get { return day; }
            set { day = value; }
        }
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime DayStart
        {
            get { return dayStart; }
            set { dayStart = value; }
        }
        /// <summary>
        /// Дата конца
        /// </summary>
        public DateTime DayFinish
        {
            get { return dayFinish; }
            set { dayFinish = value; }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public FormData()
        {
            Position = Name = NameSp = Director = Company = string.Empty;
            DayFinish = DayStart = new DateTime();
            Day = DateTime.Now;
        }

        /// <summary>
        /// Конструктор от элемента своего класса
        /// </summary>
        /// <param name="db">Данные формы</param>
        public FormData(FormData db)
        {
            director = db.Director;
            company = db.Company;
            name = db.Name;
            nameSp = db.NameSp;
            position = db.Position;
            day = DateTime.Now;
            dayStart = db.DayStart;
            dayFinish = db.DayFinish;
        }

        /// <summary>
        /// Перегрузка метода для класса данных формы в строку.
        /// </summary>
        /// <returns>Строку</returns>
        override public string ToString()
        {
            string str = string.Format("Директору {0}\n{1}\nот {2}\n{3}\n" +
                "Заявление\nПрошу предоставить мне ежегодный очередной " +
                "оплачиваемый отпуск с {4} г. по {5} г.\n{6} {7}", company,
                director, position, nameSp, dayStart.ToShortDateString(),
                dayFinish.ToShortDateString(), day.ToShortDateString(), name);
            return str;
        }

        /// <summary>
        /// метод для преобразования класса данных формы в массив строк.
        /// </summary>
        /// <returns></returns>
        public string[] ToStringArr()
        {
            string[] str = new string[8];
            int i = 0;

            str[i++] = company;
            str[i++] = director;
            str[i++] = position;
            str[i++] = nameSp;
            str[i++] = string.Format("{0}", dayStart.ToBinary());
            str[i++] = string.Format("{0}", dayFinish.ToBinary());
            str[i++] = string.Format("{0}", day.ToBinary());
            str[i++] = name;
            return str;
        }

        /// <summary>
        /// метод для загрузки класса данных формы из массива строк.
        /// </summary>
        /// <param name="str"></param>
        public void FromStringArr(string[] str)
        {
            int i = 0;

            company = str[i++];
            director = str[i++];
            position = str[i++];
            nameSp = str[i++];
            dayStart = DateTime.FromBinary(long.Parse(str[i++]));
            dayFinish = DateTime.FromBinary(long.Parse(str[i++]));
            day = DateTime.FromBinary(long.Parse(str[i++]));
            name = str[i++];
        }
    }
}

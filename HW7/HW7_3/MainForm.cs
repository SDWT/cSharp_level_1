using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HW7_3
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Данные формы
        /// </summary>
        private FormData data;

        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            //this.Icon;
            data = new FormData();
            data.Director = this.director.Text;
            data.Company = this.company.Text;
            data.Name = this.name.Text;
            data.Position = this.position.Text;
            data.NameSp = this.nameSp.Text;
            try
            {
                File.OpenRead("mt\\mt.db").Close();
            }
            catch (Exception)
            {
                button1.Enabled = false;
            }
        }

        /// <summary>
        /// обработчик Текстовой коробки "директор"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            data.Director = this.director.Text;
        }

        /// <summary>
        /// обработчик Текстовой коробки "фирма"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            data.Company = this.company.Text;
        }

        /// <summary>
        /// обработчик Текстовой коробки "заявитель"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            data.Name = this.name.Text;
        }

        /// <summary>
        /// обработчик Текстовой коробки "должность"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            data.Position = this.position.Text;
        }

        /// <summary>
        /// обработчик Текстовой коробки "заявитель в род.падеже"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            data.NameSp = this.nameSp.Text;
        }

        /// <summary>
        /// обработчик кнопки "сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            string fileName = "mt.db";
            Directory.CreateDirectory("mt");
            File.Create("mt\\" + fileName).Close();
            File.WriteAllLines("mt\\" + fileName, data.ToStringArr());
            button1.Enabled = true;
        }

        /// <summary>
        /// Форма показывающая вид заявления
        /// </summary>
        Form fr2;

        /// <summary>
        /// обработчик кнопки "шаблон"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            fr2 = new TextForm(data);
            fr2.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// обработчик кнопки "загрузить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            data.FromStringArr(File.ReadAllLines("mt\\mt.db"));

            name.Text = data.Name;
            nameSp.Text = data.NameSp;
            company.Text = data.Company;
            position.Text = data.Position;
            director.Text = data.Director;
            data.DayStart = dateTimePicker1.Value;
            data.DayFinish = dateTimePicker2.Value;
            data.Day = DateTime.Now;
        }

        /// <summary>
        /// обработчик выбора даты "начала"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            data.DayStart = dateTimePicker1.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// обработчик выбора даты "конца"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            data.DayFinish = dateTimePicker2.Value;
        }
    }
}

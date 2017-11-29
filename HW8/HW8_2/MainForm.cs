using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8_2
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Компонент игры
        /// </summary>
        static BaseOfGame game = new BaseOfGame();
        /// <summary>
        /// Конструктор приложения
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            if (!game.LBase)
                play.Enabled = false;
        }

        /// <summary>
        /// обработчик нажатия на кнопку "Играть"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Play_Click(object sender, EventArgs e)
        {
            if (!game.LBase)
            {
                MessageBox.Show("Вопросы не найдены!");
                return;
            }
            var number = new Random();
            int score = 0;

            MessageBox.Show("Здравствуйте, это Викторина.\n" +
                "Отвечайте на вопросы \"Верю\" или " +
                "\"Не верю\".\n", "Правила", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            for (int i = 0; i < 5; i++)
            {
                var quest = game.QuestionAnswer(number.Next() % game.CntQuest);
                var res = MessageBox.Show("Вопрос: " +
                    quest.Key, $"Вопрос {i}", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                

                if (quest.Value == res.HasFlag(DialogResult.Yes))
                    score++;
            }

            MessageBox.Show($"Ваш счёт: {score}", "Результат", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// обработчик нажатия на кнопку "выход" в главном меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
    }
}

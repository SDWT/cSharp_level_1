using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_1
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Компонент игры
        /// </summary>
        Doubler game;
        /// <summary>
        /// Конструктор приложения
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            plus1.Click += GameButtonClick;
            multy2.Click += GameButtonClick;
            cancel.Click += GameButtonClick;
            HideGame();
            ShowMainMenu();
        }

        /// <summary>
        /// Метод показа главного меню.
        /// </summary>
        private void ShowMainMenu()
        {
            play.Show();
            exit1.Show();
        }

        /// <summary>
        /// Метод скрытия главного меню.
        /// </summary>
        private void HideMainMenu()
        {
            play.Hide();
            exit1.Hide();
        }

        /// <summary>
        /// Метод показа компонентов игры.
        /// </summary>
        private void ShowGame()
        {
            plus1.Show();
            multy2.Show();
            cancel.Show();
            mainMenu.Show();
            exit2.Show();
            currentNumber.Show();
            finishNumber.Show();
            game = new Doubler();
            currentNumber.Text = game.Current.ToString();
            finishNumber.Text = game.Finish.ToString();
        }

        /// <summary>
        /// Метод скрытия компонентов игры.
        /// </summary>
        private void HideGame()
        {
            plus1.Hide();
            multy2.Hide();
            cancel.Hide();
            mainMenu.Hide();
            exit2.Hide();
            currentNumber.Hide();
            finishNumber.Hide();
            gameEnd.Hide();
        }

        /// <summary>
        /// обработчик нажатия на кнопку "Играть"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Play_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            ShowGame();
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

        /// <summary>
        /// обработчик нажатия на кнопку "выход" в игре
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// обработчик нажатия на кнопку "Главное меню"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenu_Click(object sender, EventArgs e)
        {
            HideGame();
            ShowMainMenu();
        }

        /// <summary>
        /// Обработчик нажатия кнопок игры и сама игра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameButtonClick(object sender, EventArgs e)
        {
            var sndr = (sender as Button);
            if (sndr.Name == plus1.Name)
                game.Step(Doubler.Action.Up1);
            else if (sndr.Name == multy2.Name)
                game.Step(Doubler.Action.Multy2);
            else if (sndr.Name == cancel.Name)
                game.Step(Doubler.Action.Cancel1);
            currentNumber.Text = game.Current.ToString();

            if (game.Current >= game.Finish)
            {
                HideGame();
                exit2.Show();
                mainMenu.Show();
                gameEnd.Text = string.Empty;
                if (game.Current > game.Finish)
                {
                    gameEnd.AppendText("Вы проиграли!\n");
                }
                else
                {
                    gameEnd.AppendText("Вы выйграли!\n");
                }
                gameEnd.AppendText("Вы можете выйти из игры или пройти в главное меню.");
                gameEnd.Show();
            }
        }
    }
}

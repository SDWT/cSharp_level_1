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

        private void ShowMainMenu()
        {
            play.Show();
            exit1.Show();
        }

        private void HideMainMenu()
        {
            play.Hide();
            exit1.Hide();
        }

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

        private void HideGame()
        {
            plus1.Hide();
            multy2.Hide();
            cancel.Hide();
            mainMenu.Hide();
            exit2.Hide();
            currentNumber.Hide();
            finishNumber.Hide();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            ShowGame();
        }

        private void exit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            HideGame();
            ShowMainMenu();
        }

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
                plus1.Hide();
                multy2.Hide();
                cancel.Hide();
            
                if (game.Current > game.Finish)
                {
                    gameEnd.Text = "";
                }
                else
                {

                }
            }
        }
    }
}

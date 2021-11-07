using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_v2App
{
    public partial class Form1 : Form
    {
        int _computerCount; // число побед компа
        int _userCount; // число побед игрока

        public Form1()
        {
            InitializeComponent();
        }

        private void imgRock_Click(object sender, EventArgs e)
        {
            labelBorderCompRock.BackColor = Color.Green;
            labelBorderUserRock.BackColor = Color.Green;

            ImgEnabled(false);
            WhoIsTheWinner(1);
        }

        private void imgPaper_Click(object sender, EventArgs e)
        {
            labelBorderCompPaper.BackColor = Color.Green;
            labelBorderUserPaper.BackColor = Color.Green;

            ImgEnabled(false);
            WhoIsTheWinner(0);
        }

        private void imgScissors_Click(object sender, EventArgs e)
        {
            labelBorderCompScissors.BackColor = Color.Green;
            labelBorderUserScissors.BackColor = Color.Green;

            ImgEnabled(false);
            WhoIsTheWinner(2);
        }

        private void ImgEnabled(bool choice)
        {
            imgRock.Enabled = choice;
            imgPaper.Enabled = choice;
            imgScissor.Enabled = choice;
        }

        // выбор знака компьютером
        // бумага - 0, камень - 1, ножницы -2
        private int ComputerChoise()
        {
            Random random = new Random();
            int computerChoise = random.Next(0, 3);

            switch (computerChoise)
            {
                case 0:
                    labelBorderCompPaper.BackColor = Color.Red;
                    // при одинаковом выборе (игрока и компа) видны будут обе рамки
                    if (labelBorderUserPaper.BackColor != Color.Green)
                        labelBorderUserPaper.BackColor = Color.Red;
                    break;
                case 1:
                    labelBorderCompRock.BackColor = Color.Red;
                    if (labelBorderUserRock.BackColor != Color.Green)
                        labelBorderUserRock.BackColor = Color.Red;
                    break;
                case 2:
                    labelBorderCompScissors.BackColor = Color.Red;
                    if (labelBorderUserScissors.BackColor != Color.Green)
                        labelBorderUserScissors.BackColor = Color.Red;
                    break;
            }

            return computerChoise;
        }

        // Определение победителя
        private void WhoIsTheWinner(int userChoise)
        {
            int computerChoise = ComputerChoise();
            int differentCompUser = computerChoise - userChoise;

            if ((differentCompUser == -2) || (differentCompUser == 1))
            {
                labelInfoTable.Text = InfoTable(computerChoise, userChoise);
                _userCount++;
            }
            else if ((differentCompUser == -1) || (differentCompUser == 2))
            {
                labelInfoTable.Text = InfoTable(computerChoise, userChoise);
                _computerCount++;
            }
            else // то есть differentCompUser = 0
            {
                labelInfoTable.Text = InfoTable(computerChoise, userChoise);
            }

            labelScore.Text = _computerCount + " : " + _userCount;
        }

        private void BorderColor(Color backColor)
        {
            // рамка компютера
            labelBorderCompRock.BackColor = backColor;
            labelBorderCompScissors.BackColor = backColor;
            labelBorderCompPaper.BackColor = backColor;

            // рамка игрока
            labelBorderUserRock.BackColor = backColor;
            labelBorderUserScissors.BackColor = backColor;
            labelBorderUserPaper.BackColor = backColor;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ImgEnabled(true); // снятие запрета будет только после нажатия кнопки "Еще разок..."
            BorderColor(SystemColors.Control); /* и после этого будут изменяться границы. 
                                                * Передаем цвет, кот. был по умолчанию */
        }

        /* анализирует, что выбрали игроки
         и дает информацию об этом.
         (бумага - 0, камень - 1, ножницы - 2).
        Если сложить оба выбора:
        - Ничья: (выбрали оба бумагу - это 0 + 0 = 0; оба камень 1 + 1 = 2; ножницы 2 + 2 = 4)
        - Бумага-камень 0 + 1 = 1
        - Ножницы-бумага 2 + 0 = 2
        - Камень-ножницы 1 + 2 = 3 */
        private string InfoTable(int computerChoise, int userChoise)
        {
            int sumOfChoise = computerChoise + userChoise;

            if (computerChoise == userChoise)
            {
                return "No one loses when the game's a draw!!!"; // ничья
            }
            else if (sumOfChoise == 1)
            {
                return "Paper wrapped a stone.";
            }
            else if (sumOfChoise == 3)
            {
                return "A stone broke scissors.";
            }
            else // сумма равна 2, но не ничья (ножницы-бумага)
            {
                return "Scissors cut paper.";
            }
        }

        private void labelUserName_DoubleClick(object sender, EventArgs e)
        {
            txtReadName.Visible = true;
            txtReadName.Enabled = true;
        }

        // событие проверяет, была ли нажата какая-то клавиша
        private void txtReadName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                labelUserName.Text = txtReadName.Text;
                txtReadName.Visible = false;
                txtReadName.Enabled = false;
            }
        }
    }
}

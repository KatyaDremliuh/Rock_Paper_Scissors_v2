using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_v2App
{
    public partial class pictBoxPaperWin : Form
    {
        int _computerCount; // число побед компа
        int _userCount; // число побед игрока

        public pictBoxPaperWin()
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
            WhoIsTheWinner(2);
        }

        private void imgScissors_Click(object sender, EventArgs e)
        {
            labelBorderUserScissors.BackColor = Color.Green;
            labelBorderCompScissors.BackColor = Color.Green;

            ImgEnabled(false);
            WhoIsTheWinner(0);
        }

        private void ImgEnabled(bool choice)
        {
            imgRock.Enabled = choice;
            imgPaper.Enabled = choice;
            imgScissor.Enabled = choice;
        }

        // выбор знака компьютером
        // бумага - 2, камень - 1, ножницы -0
        private int ComputerChoise()
        {
            Random random = new Random();
            int computerChoise = random.Next(0, 3);

            switch (computerChoise)
            {
                case 0:
                    labelBorderCompScissors.BackColor = Color.Red;
                    // при одинаковом выборе (игрока и компа) видны будут обе рамки
                    if (labelBorderUserScissors.BackColor != Color.Green)
                        labelBorderUserScissors.BackColor = Color.Red;
                    break;
                case 1:
                    labelBorderCompRock.BackColor = Color.Red;
                    if (labelBorderUserRock.BackColor != Color.Green)
                        labelBorderUserRock.BackColor = Color.Red;
                    break;
                case 2:
                    labelBorderUserPaper.BackColor = Color.Red;
                    if (labelBorderCompPaper.BackColor != Color.Green)
                        labelBorderCompPaper.BackColor = Color.Red;
                    break;
            }

            return computerChoise;
        }

        // Определение победителя
        // бумага - 2, камень - 1, ножницы -0
        private void WhoIsTheWinner(int userChoise)
        {
            int computerChoise = ComputerChoise();
            int differentCompUser = computerChoise - userChoise;

            if ((differentCompUser == -2) || (differentCompUser == 1))
            {
                labelInfoTable.Text = InfoTable(computerChoise, userChoise) + "       Computer's a winner!";
                _computerCount++;
            }
            else if ((differentCompUser == -1) || (differentCompUser == 2))
            {
                labelInfoTable.Text = InfoTable(computerChoise, userChoise) + $"       {labelUserName.Text}'s a winner!";
                _userCount++;
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
            labelBorderUserPaper.BackColor = backColor;
            labelBorderCompScissors.BackColor = backColor;

            // рамка игрока
            labelBorderUserRock.BackColor = backColor;
            labelBorderCompPaper.BackColor = backColor;
            labelBorderUserScissors.BackColor = backColor;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ImgEnabled(true); // снятие запрета будет только после нажатия кнопки "Еще играть..."
            BorderColor(SystemColors.Info); /* и после этого будут изменяться границы. 
                                                * Передаем цвет, кот. был по умолчанию */
           
            // сделать результирующие картинки снова невидимыми
            rockWin.Visible = false;
            scissorsWin.Visible = false;
            paperWin.Visible = false;
            pictureBoxBalance.Visible = false;
        }

        /* анализирует, что выбрали игроки
         и дает информацию об этом.
         (бумага - 2, камень - 1, ножницы - 0).
        Если сложить оба выбора:
        - Ничья: (выбрали оба бумагу - это 0 + 0 = 0; оба камень 1 + 1 = 2; ножницы 2 + 2 = 4)
        - Бумага-камень (2 + 1 = 3) -> Б
        - Ножницы-бумага (0 + 2 = 2) -> Н
        - Камень-ножницы (1 + 0 = 1) -> К */
        private string InfoTable(int computerChoise, int userChoise)
        {
            int sumOfChoise = computerChoise + userChoise;

            if (computerChoise == userChoise)
            {
                pictureBoxBalance.Visible = true;
                return "No one loses when the game's a draw!!!"; // ничья
            }
            else if (sumOfChoise == 3)
            {
                paperWin.Visible = true;
                return "Paper wrapped a stone."; // Б
            }
            else if (sumOfChoise == 1)
            {
                rockWin.Visible = true;
                return "A rock broke scissors."; // К
            }
            else // сумма равна 2, но не ничья (ножницы-бумага)
            {
                scissorsWin.Visible = true;
                return "Scissors cut paper."; // Н
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _userCount = 0;
            _computerCount = 0;

            labelScore.Text = "0 : 0";

            ImgEnabled(true); // разрешить нажимать на картинки
            BorderColor(SystemColors.Info); // все границы (borders) сделать цветом фона основного
        }
    }
}

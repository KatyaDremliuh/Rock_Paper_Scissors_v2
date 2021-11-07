using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_v2App
{
    public partial class Form1 : Form
    {
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

        private void pictureBox1_Click(object sender, EventArgs e) // ножницы (со странным названием)
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
                    // при ничьей видны будут обе рамки
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

            if ((differentCompUser == 2) || (differentCompUser == 1))
            {
                MessageBox.Show("Ur a winner!");
            }
            else if ((differentCompUser == -1) || (differentCompUser==2))
            {
                MessageBox.Show("The computer is winner!");
            }
            else // то есть differentCompUser = 0
            {
                MessageBox.Show("No one loses when the game's a draw!!!");
            }

            MessageBox.Show($"Ur choise: {userChoise.ToString()}\nComputer choise: {computerChoise.ToString()}");
        }
    }
}

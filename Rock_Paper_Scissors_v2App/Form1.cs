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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            labelBorderCompScissors.BackColor = Color.Green;
            labelBorderUserScissors.BackColor = Color.Green;

            ImgEnabled(false);
        }

        private void imgRock_Click(object sender, EventArgs e)
        {
            labelBorderCompRock.BackColor = Color.Green;
            labelBorderUserRock.BackColor = Color.Green;

            ImgEnabled(false);
        }

        private void imgPaper_Click(object sender, EventArgs e)
        {
            labelBorderCompPaper.BackColor = Color.Green;
            labelBorderUserPaper.BackColor = Color.Green;

            ImgEnabled(false);
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
                    break;
                case 1:
                    labelBorderCompRock.BackColor = Color.Red;
                    break;
                case 2:
                    labelBorderCompScissors.BackColor = Color.Red;
                    break;
            }

            return computerChoise;
        }
    }
}

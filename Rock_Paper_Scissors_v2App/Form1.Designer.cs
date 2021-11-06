
namespace Rock_Paper_Scissors_v2App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBorderComputerRock = new System.Windows.Forms.Label();
            this.labelBorderUserRock = new System.Windows.Forms.Label();
            this.labelBorderUserPaper = new System.Windows.Forms.Label();
            this.labelBorderComputerPaper = new System.Windows.Forms.Label();
            this.labelBorderUserScissors = new System.Windows.Forms.Label();
            this.labelBorderComputerScissors = new System.Windows.Forms.Label();
            this.imgScissors = new System.Windows.Forms.PictureBox();
            this.imgPaper = new System.Windows.Forms.PictureBox();
            this.imgRock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBorderComputerRock
            // 
            this.labelBorderComputerRock.BackColor = System.Drawing.SystemColors.Control;
            this.labelBorderComputerRock.Location = new System.Drawing.Point(18, 60);
            this.labelBorderComputerRock.Name = "labelBorderComputerRock";
            this.labelBorderComputerRock.Size = new System.Drawing.Size(158, 158);
            this.labelBorderComputerRock.TabIndex = 0;
            // 
            // labelBorderUserRock
            // 
            this.labelBorderUserRock.BackColor = System.Drawing.SystemColors.Control;
            this.labelBorderUserRock.Location = new System.Drawing.Point(20, 62);
            this.labelBorderUserRock.Name = "labelBorderUserRock";
            this.labelBorderUserRock.Size = new System.Drawing.Size(154, 154);
            this.labelBorderUserRock.TabIndex = 1;
            // 
            // labelBorderUserPaper
            // 
            this.labelBorderUserPaper.BackColor = System.Drawing.SystemColors.Control;
            this.labelBorderUserPaper.Location = new System.Drawing.Point(200, 62);
            this.labelBorderUserPaper.Name = "labelBorderUserPaper";
            this.labelBorderUserPaper.Size = new System.Drawing.Size(154, 154);
            this.labelBorderUserPaper.TabIndex = 4;
            // 
            // labelBorderComputerPaper
            // 
            this.labelBorderComputerPaper.BackColor = System.Drawing.SystemColors.Control;
            this.labelBorderComputerPaper.Location = new System.Drawing.Point(198, 60);
            this.labelBorderComputerPaper.Name = "labelBorderComputerPaper";
            this.labelBorderComputerPaper.Size = new System.Drawing.Size(158, 158);
            this.labelBorderComputerPaper.TabIndex = 3;
            // 
            // labelBorderUserScissors
            // 
            this.labelBorderUserScissors.BackColor = System.Drawing.SystemColors.Control;
            this.labelBorderUserScissors.Location = new System.Drawing.Point(380, 62);
            this.labelBorderUserScissors.Name = "labelBorderUserScissors";
            this.labelBorderUserScissors.Size = new System.Drawing.Size(154, 154);
            this.labelBorderUserScissors.TabIndex = 7;
            // 
            // labelBorderComputerScissors
            // 
            this.labelBorderComputerScissors.BackColor = System.Drawing.SystemColors.Control;
            this.labelBorderComputerScissors.Location = new System.Drawing.Point(378, 60);
            this.labelBorderComputerScissors.Name = "labelBorderComputerScissors";
            this.labelBorderComputerScissors.Size = new System.Drawing.Size(158, 158);
            this.labelBorderComputerScissors.TabIndex = 6;
            // 
            // imgScissors
            // 
            this.imgScissors.Image = global::Rock_Paper_Scissors_v2App.Properties.Resources.Scissors;
            this.imgScissors.Location = new System.Drawing.Point(382, 64);
            this.imgScissors.Name = "imgScissors";
            this.imgScissors.Size = new System.Drawing.Size(150, 150);
            this.imgScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgScissors.TabIndex = 8;
            this.imgScissors.TabStop = false;
            this.imgScissors.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgPaper
            // 
            this.imgPaper.Image = global::Rock_Paper_Scissors_v2App.Properties.Resources.Paper;
            this.imgPaper.Location = new System.Drawing.Point(202, 64);
            this.imgPaper.Name = "imgPaper";
            this.imgPaper.Size = new System.Drawing.Size(150, 150);
            this.imgPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPaper.TabIndex = 5;
            this.imgPaper.TabStop = false;
            // 
            // imgRock
            // 
            this.imgRock.Image = global::Rock_Paper_Scissors_v2App.Properties.Resources.Rock;
            this.imgRock.Location = new System.Drawing.Point(22, 64);
            this.imgRock.Name = "imgRock";
            this.imgRock.Size = new System.Drawing.Size(150, 150);
            this.imgRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRock.TabIndex = 2;
            this.imgRock.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 353);
            this.Controls.Add(this.imgScissors);
            this.Controls.Add(this.labelBorderUserScissors);
            this.Controls.Add(this.labelBorderComputerScissors);
            this.Controls.Add(this.imgPaper);
            this.Controls.Add(this.labelBorderUserPaper);
            this.Controls.Add(this.labelBorderComputerPaper);
            this.Controls.Add(this.imgRock);
            this.Controls.Add(this.labelBorderUserRock);
            this.Controls.Add(this.labelBorderComputerRock);
            this.Name = "Form1";
            this.Text = "Rock-Paper-Scissors_v2";
            ((System.ComponentModel.ISupportInitialize)(this.imgScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBorderComputerRock;
        private System.Windows.Forms.Label labelBorderUserRock;
        private System.Windows.Forms.PictureBox imgRock;
        private System.Windows.Forms.PictureBox imgPaper;
        private System.Windows.Forms.Label labelBorderUserPaper;
        private System.Windows.Forms.Label labelBorderComputerPaper;
        private System.Windows.Forms.PictureBox imgScissors;
        private System.Windows.Forms.Label labelBorderUserScissors;
        private System.Windows.Forms.Label labelBorderComputerScissors;
    }
}


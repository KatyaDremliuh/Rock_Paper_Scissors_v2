
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
            this.labelBorderCompRock = new System.Windows.Forms.Label();
            this.labelBorderUserRock = new System.Windows.Forms.Label();
            this.labelBorderUserPaper = new System.Windows.Forms.Label();
            this.labelBorderCompPaper = new System.Windows.Forms.Label();
            this.labelBorderUserScissors = new System.Windows.Forms.Label();
            this.labelBorderCompScissors = new System.Windows.Forms.Label();
            this.imgScissor = new System.Windows.Forms.PictureBox();
            this.imgPaper = new System.Windows.Forms.PictureBox();
            this.imgRock = new System.Windows.Forms.PictureBox();
            this.labelComputerName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBorderCompRock
            // 
            this.labelBorderCompRock.BackColor = System.Drawing.SystemColors.Control;
            this.labelBorderCompRock.Location = new System.Drawing.Point(18, 60);
            this.labelBorderCompRock.Name = "labelBorderCompRock";
            this.labelBorderCompRock.Size = new System.Drawing.Size(158, 158);
            this.labelBorderCompRock.TabIndex = 0;
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
            // labelBorderCompPaper
            // 
            this.labelBorderCompPaper.BackColor = System.Drawing.SystemColors.Control;
            this.labelBorderCompPaper.Location = new System.Drawing.Point(198, 60);
            this.labelBorderCompPaper.Name = "labelBorderCompPaper";
            this.labelBorderCompPaper.Size = new System.Drawing.Size(158, 158);
            this.labelBorderCompPaper.TabIndex = 3;
            // 
            // labelBorderUserScissors
            // 
            this.labelBorderUserScissors.BackColor = System.Drawing.SystemColors.Control;
            this.labelBorderUserScissors.Location = new System.Drawing.Point(380, 62);
            this.labelBorderUserScissors.Name = "labelBorderUserScissors";
            this.labelBorderUserScissors.Size = new System.Drawing.Size(154, 154);
            this.labelBorderUserScissors.TabIndex = 7;
            // 
            // labelBorderCompScissors
            // 
            this.labelBorderCompScissors.BackColor = System.Drawing.SystemColors.Control;
            this.labelBorderCompScissors.Location = new System.Drawing.Point(378, 60);
            this.labelBorderCompScissors.Name = "labelBorderCompScissors";
            this.labelBorderCompScissors.Size = new System.Drawing.Size(158, 158);
            this.labelBorderCompScissors.TabIndex = 6;
            // 
            // imgScissor
            // 
            this.imgScissor.Image = global::Rock_Paper_Scissors_v2App.Properties.Resources.Scissors;
            this.imgScissor.Location = new System.Drawing.Point(382, 64);
            this.imgScissor.Name = "imgScissor";
            this.imgScissor.Size = new System.Drawing.Size(150, 150);
            this.imgScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgScissor.TabIndex = 8;
            this.imgScissor.TabStop = false;
            this.imgScissor.Click += new System.EventHandler(this.imgScissors_Click);
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
            this.imgPaper.Click += new System.EventHandler(this.imgPaper_Click);
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
            this.imgRock.Click += new System.EventHandler(this.imgRock_Click);
            // 
            // labelComputerName
            // 
            this.labelComputerName.Font = new System.Drawing.Font("Monotype Corsiva", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerName.Location = new System.Drawing.Point(18, 260);
            this.labelComputerName.Name = "labelComputerName";
            this.labelComputerName.Size = new System.Drawing.Size(150, 45);
            this.labelComputerName.TabIndex = 9;
            this.labelComputerName.Text = "Computer";
            this.labelComputerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserName
            // 
            this.labelUserName.Font = new System.Drawing.Font("Monotype Corsiva", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(378, 260);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(150, 45);
            this.labelUserName.TabIndex = 10;
            this.labelUserName.Text = "User";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.labelScore.Location = new System.Drawing.Point(198, 260);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(158, 45);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "0 : 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 353);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelComputerName);
            this.Controls.Add(this.imgScissor);
            this.Controls.Add(this.labelBorderUserScissors);
            this.Controls.Add(this.labelBorderCompScissors);
            this.Controls.Add(this.imgPaper);
            this.Controls.Add(this.labelBorderUserPaper);
            this.Controls.Add(this.labelBorderCompPaper);
            this.Controls.Add(this.imgRock);
            this.Controls.Add(this.labelBorderUserRock);
            this.Controls.Add(this.labelBorderCompRock);
            this.Name = "Form1";
            this.Text = "Rock-Paper-Scissors_v2";
            ((System.ComponentModel.ISupportInitialize)(this.imgScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBorderCompRock;
        private System.Windows.Forms.Label labelBorderUserRock;
        private System.Windows.Forms.PictureBox imgRock;
        private System.Windows.Forms.PictureBox imgPaper;
        private System.Windows.Forms.Label labelBorderUserPaper;
        private System.Windows.Forms.Label labelBorderCompPaper;
        private System.Windows.Forms.PictureBox imgScissor;
        private System.Windows.Forms.Label labelBorderUserScissors;
        private System.Windows.Forms.Label labelBorderCompScissors;
        private System.Windows.Forms.Label labelComputerName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelScore;
    }
}


﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelBorderCompRock = new System.Windows.Forms.Label();
            this.labelBorderUserRock = new System.Windows.Forms.Label();
            this.labelBorderUserPaper = new System.Windows.Forms.Label();
            this.labelBorderCompPaper = new System.Windows.Forms.Label();
            this.labelBorderUserScissors = new System.Windows.Forms.Label();
            this.labelBorderCompScissors = new System.Windows.Forms.Label();
            this.labelComputerName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelInfoTable = new System.Windows.Forms.Label();
            this.txtReadName = new System.Windows.Forms.TextBox();
            this.imgRock = new System.Windows.Forms.PictureBox();
            this.imgPaper = new System.Windows.Forms.PictureBox();
            this.imgScissor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBorderCompRock
            // 
            this.labelBorderCompRock.BackColor = System.Drawing.SystemColors.Info;
            this.labelBorderCompRock.Location = new System.Drawing.Point(50, 50);
            this.labelBorderCompRock.Name = "labelBorderCompRock";
            this.labelBorderCompRock.Size = new System.Drawing.Size(200, 200);
            this.labelBorderCompRock.TabIndex = 0;
            // 
            // labelBorderUserRock
            // 
            this.labelBorderUserRock.BackColor = System.Drawing.SystemColors.Info;
            this.labelBorderUserRock.Location = new System.Drawing.Point(65, 65);
            this.labelBorderUserRock.Name = "labelBorderUserRock";
            this.labelBorderUserRock.Size = new System.Drawing.Size(170, 170);
            this.labelBorderUserRock.TabIndex = 1;
            // 
            // labelBorderUserPaper
            // 
            this.labelBorderUserPaper.BackColor = System.Drawing.SystemColors.Info;
            this.labelBorderUserPaper.Location = new System.Drawing.Point(365, 65);
            this.labelBorderUserPaper.Name = "labelBorderUserPaper";
            this.labelBorderUserPaper.Size = new System.Drawing.Size(170, 170);
            this.labelBorderUserPaper.TabIndex = 4;
            // 
            // labelBorderCompPaper
            // 
            this.labelBorderCompPaper.BackColor = System.Drawing.SystemColors.Info;
            this.labelBorderCompPaper.Location = new System.Drawing.Point(350, 50);
            this.labelBorderCompPaper.Name = "labelBorderCompPaper";
            this.labelBorderCompPaper.Size = new System.Drawing.Size(200, 200);
            this.labelBorderCompPaper.TabIndex = 3;
            // 
            // labelBorderUserScissors
            // 
            this.labelBorderUserScissors.BackColor = System.Drawing.SystemColors.Info;
            this.labelBorderUserScissors.Location = new System.Drawing.Point(650, 50);
            this.labelBorderUserScissors.Name = "labelBorderUserScissors";
            this.labelBorderUserScissors.Size = new System.Drawing.Size(200, 200);
            this.labelBorderUserScissors.TabIndex = 7;
            // 
            // labelBorderCompScissors
            // 
            this.labelBorderCompScissors.BackColor = System.Drawing.SystemColors.Info;
            this.labelBorderCompScissors.Location = new System.Drawing.Point(665, 65);
            this.labelBorderCompScissors.Name = "labelBorderCompScissors";
            this.labelBorderCompScissors.Size = new System.Drawing.Size(170, 170);
            this.labelBorderCompScissors.TabIndex = 6;
            // 
            // labelComputerName
            // 
            this.labelComputerName.Font = new System.Drawing.Font("Arial Black", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerName.Location = new System.Drawing.Point(35, 400);
            this.labelComputerName.Name = "labelComputerName";
            this.labelComputerName.Size = new System.Drawing.Size(200, 90);
            this.labelComputerName.TabIndex = 9;
            this.labelComputerName.Text = "Computer";
            this.labelComputerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserName
            // 
            this.labelUserName.Font = new System.Drawing.Font("Arial Black", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(660, 400);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(200, 90);
            this.labelUserName.TabIndex = 10;
            this.labelUserName.Text = "User";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUserName.DoubleClick += new System.EventHandler(this.labelUserName_DoubleClick);
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelScore.Location = new System.Drawing.Point(340, 400);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(220, 90);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "0 : 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttonNext.Location = new System.Drawing.Point(390, 495);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(120, 40);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "Play more";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelInfoTable
            // 
            this.labelInfoTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.labelInfoTable.Location = new System.Drawing.Point(53, 20);
            this.labelInfoTable.Name = "labelInfoTable";
            this.labelInfoTable.Size = new System.Drawing.Size(797, 30);
            this.labelInfoTable.TabIndex = 13;
            this.labelInfoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReadName
            // 
            this.txtReadName.BackColor = System.Drawing.SystemColors.Control;
            this.txtReadName.Enabled = false;
            this.txtReadName.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadName.Location = new System.Drawing.Point(645, 419);
            this.txtReadName.Name = "txtReadName";
            this.txtReadName.Size = new System.Drawing.Size(190, 53);
            this.txtReadName.TabIndex = 14;
            this.txtReadName.Text = "Player";
            this.txtReadName.Visible = false;
            this.txtReadName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReadName_KeyDown);
            // 
            // imgRock
            // 
            this.imgRock.Image = ((System.Drawing.Image)(resources.GetObject("imgRock.Image")));
            this.imgRock.Location = new System.Drawing.Point(80, 80);
            this.imgRock.Name = "imgRock";
            this.imgRock.Size = new System.Drawing.Size(140, 140);
            this.imgRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRock.TabIndex = 2;
            this.imgRock.TabStop = false;
            this.imgRock.Click += new System.EventHandler(this.imgRock_Click);
            // 
            // imgPaper
            // 
            this.imgPaper.Image = ((System.Drawing.Image)(resources.GetObject("imgPaper.Image")));
            this.imgPaper.Location = new System.Drawing.Point(680, 80);
            this.imgPaper.Name = "imgPaper";
            this.imgPaper.Size = new System.Drawing.Size(140, 140);
            this.imgPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPaper.TabIndex = 5;
            this.imgPaper.TabStop = false;
            this.imgPaper.Click += new System.EventHandler(this.imgPaper_Click);
            // 
            // imgScissor
            // 
            this.imgScissor.Image = ((System.Drawing.Image)(resources.GetObject("imgScissor.Image")));
            this.imgScissor.Location = new System.Drawing.Point(380, 80);
            this.imgScissor.Name = "imgScissor";
            this.imgScissor.Size = new System.Drawing.Size(140, 140);
            this.imgScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgScissor.TabIndex = 8;
            this.imgScissor.TabStop = false;
            this.imgScissor.Click += new System.EventHandler(this.imgScissors_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.imgPaper);
            this.Controls.Add(this.txtReadName);
            this.Controls.Add(this.labelInfoTable);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelComputerName);
            this.Controls.Add(this.imgScissor);
            this.Controls.Add(this.labelBorderCompScissors);
            this.Controls.Add(this.labelBorderUserPaper);
            this.Controls.Add(this.labelBorderCompPaper);
            this.Controls.Add(this.imgRock);
            this.Controls.Add(this.labelBorderUserRock);
            this.Controls.Add(this.labelBorderCompRock);
            this.Controls.Add(this.labelBorderUserScissors);
            this.Name = "Form1";
            this.Text = "Rock-Paper-Scissors_v2";
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBorderCompRock;
        private System.Windows.Forms.Label labelBorderUserRock;
        private System.Windows.Forms.PictureBox imgRock;
        private System.Windows.Forms.Label labelBorderUserPaper;
        private System.Windows.Forms.Label labelBorderCompPaper;
        private System.Windows.Forms.Label labelBorderUserScissors;
        private System.Windows.Forms.Label labelBorderCompScissors;
        private System.Windows.Forms.Label labelComputerName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelInfoTable;
        private System.Windows.Forms.TextBox txtReadName;
        private System.Windows.Forms.PictureBox imgPaper;
        private System.Windows.Forms.PictureBox imgScissor;
    }
}


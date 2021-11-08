
namespace Rock_Paper_Scissors_v2App
{
    partial class pictBoxPaperWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pictBoxPaperWin));
            this.labelBorderCompRock = new System.Windows.Forms.Label();
            this.labelBorderUserRock = new System.Windows.Forms.Label();
            this.labelBorderUserScissors = new System.Windows.Forms.Label();
            this.labelBorderCompScissors = new System.Windows.Forms.Label();
            this.labelBorderCompPaper = new System.Windows.Forms.Label();
            this.labelBorderUserPaper = new System.Windows.Forms.Label();
            this.labelComputerName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelInfoTable = new System.Windows.Forms.Label();
            this.txtReadName = new System.Windows.Forms.TextBox();
            this.imgRock = new System.Windows.Forms.PictureBox();
            this.imgPaper = new System.Windows.Forms.PictureBox();
            this.imgScissor = new System.Windows.Forms.PictureBox();
            this.PaperWin = new System.Windows.Forms.PictureBox();
            this.ScissorsWin = new System.Windows.Forms.PictureBox();
            this.RockWin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockWin)).BeginInit();
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
            // labelBorderUserScissors
            // 
            this.labelBorderUserScissors.BackColor = System.Drawing.SystemColors.Info;
            this.labelBorderUserScissors.Location = new System.Drawing.Point(365, 65);
            this.labelBorderUserScissors.Name = "labelBorderUserScissors";
            this.labelBorderUserScissors.Size = new System.Drawing.Size(170, 170);
            this.labelBorderUserScissors.TabIndex = 4;
            // 
            // labelBorderCompScissors
            // 
            this.labelBorderCompScissors.BackColor = System.Drawing.SystemColors.Info;
            this.labelBorderCompScissors.Location = new System.Drawing.Point(350, 50);
            this.labelBorderCompScissors.Name = "labelBorderCompScissors";
            this.labelBorderCompScissors.Size = new System.Drawing.Size(200, 200);
            this.labelBorderCompScissors.TabIndex = 3;
            // 
            // labelBorderCompPaper
            // 
            this.labelBorderCompPaper.BackColor = System.Drawing.SystemColors.Info;
            this.labelBorderCompPaper.Location = new System.Drawing.Point(650, 50);
            this.labelBorderCompPaper.Name = "labelBorderCompPaper";
            this.labelBorderCompPaper.Size = new System.Drawing.Size(200, 200);
            this.labelBorderCompPaper.TabIndex = 7;
            // 
            // labelBorderUserPaper
            // 
            this.labelBorderUserPaper.BackColor = System.Drawing.SystemColors.Info;
            this.labelBorderUserPaper.Location = new System.Drawing.Point(665, 65);
            this.labelBorderUserPaper.Name = "labelBorderUserPaper";
            this.labelBorderUserPaper.Size = new System.Drawing.Size(170, 170);
            this.labelBorderUserPaper.TabIndex = 6;
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
            this.imgRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.imgPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.imgScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgScissor.TabIndex = 8;
            this.imgScissor.TabStop = false;
            this.imgScissor.Click += new System.EventHandler(this.imgScissors_Click);
            // 
            // PaperWin
            // 
            this.PaperWin.Image = ((System.Drawing.Image)(resources.GetObject("PaperWin.Image")));
            this.PaperWin.Location = new System.Drawing.Point(653, 250);
            this.PaperWin.Name = "PaperWin";
            this.PaperWin.Size = new System.Drawing.Size(197, 147);
            this.PaperWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PaperWin.TabIndex = 15;
            this.PaperWin.TabStop = false;
            this.PaperWin.Visible = false;
            // 
            // ScissorsWin
            // 
            this.ScissorsWin.Image = ((System.Drawing.Image)(resources.GetObject("ScissorsWin.Image")));
            this.ScissorsWin.Location = new System.Drawing.Point(353, 250);
            this.ScissorsWin.Name = "ScissorsWin";
            this.ScissorsWin.Size = new System.Drawing.Size(197, 152);
            this.ScissorsWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScissorsWin.TabIndex = 16;
            this.ScissorsWin.TabStop = false;
            this.ScissorsWin.Visible = false;
            // 
            // RockWin
            // 
            this.RockWin.Image = ((System.Drawing.Image)(resources.GetObject("RockWin.Image")));
            this.RockWin.Location = new System.Drawing.Point(53, 250);
            this.RockWin.Name = "RockWin";
            this.RockWin.Size = new System.Drawing.Size(197, 147);
            this.RockWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RockWin.TabIndex = 17;
            this.RockWin.TabStop = false;
            this.RockWin.Visible = false;
            // 
            // pictBoxPaperWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.RockWin);
            this.Controls.Add(this.ScissorsWin);
            this.Controls.Add(this.PaperWin);
            this.Controls.Add(this.imgPaper);
            this.Controls.Add(this.txtReadName);
            this.Controls.Add(this.labelInfoTable);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelComputerName);
            this.Controls.Add(this.imgScissor);
            this.Controls.Add(this.labelBorderUserPaper);
            this.Controls.Add(this.labelBorderUserScissors);
            this.Controls.Add(this.labelBorderCompScissors);
            this.Controls.Add(this.imgRock);
            this.Controls.Add(this.labelBorderUserRock);
            this.Controls.Add(this.labelBorderCompRock);
            this.Controls.Add(this.labelBorderCompPaper);
            this.Name = "pictBoxPaperWin";
            this.Text = "Rock-Paper-Scissors_v2";
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBorderCompRock;
        private System.Windows.Forms.Label labelBorderUserRock;
        private System.Windows.Forms.PictureBox imgRock;
        private System.Windows.Forms.Label labelBorderUserScissors;
        private System.Windows.Forms.Label labelBorderCompScissors;
        private System.Windows.Forms.Label labelBorderCompPaper;
        private System.Windows.Forms.Label labelBorderUserPaper;
        private System.Windows.Forms.Label labelComputerName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelInfoTable;
        private System.Windows.Forms.TextBox txtReadName;
        private System.Windows.Forms.PictureBox imgPaper;
        private System.Windows.Forms.PictureBox imgScissor;
        private System.Windows.Forms.PictureBox ScissorsWin;
        private System.Windows.Forms.PictureBox PaperWin;
        private System.Windows.Forms.PictureBox RockWin;
    }
}


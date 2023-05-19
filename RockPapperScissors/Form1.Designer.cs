namespace Rock_Paper_Scissors
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            picPlayer = new PictureBox();
            picCPU = new PictureBox();
            txtMessage = new Label();
            roundsText = new Label();
            button4 = new Button();
            txtTime = new Label();
            countDownTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCPU).BeginInit();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnRock.ForeColor = SystemColors.Window;
            btnRock.Image = (Image)resources.GetObject("btnRock.Image");
            btnRock.Location = new Point(80, 99);
            btnRock.Margin = new Padding(4, 6, 4, 6);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(208, 149);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += BtnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnPaper.Image = (Image)resources.GetObject("btnPaper.Image");
            btnPaper.Location = new Point(80, 260);
            btnPaper.Margin = new Padding(4, 6, 4, 6);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(208, 149);
            btnPaper.TabIndex = 0;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += BtnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnScissors.ForeColor = SystemColors.ScrollBar;
            btnScissors.Image = (Image)resources.GetObject("btnScissors.Image");
            btnScissors.Location = new Point(80, 421);
            btnScissors.Margin = new Padding(4, 6, 4, 6);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(208, 142);
            btnScissors.TabIndex = 0;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += BtnScissors_Click;
            // 
            // picPlayer
            // 
            picPlayer.Image = RockPapperScissors.Properties.Resources.rockscissor;
            picPlayer.Location = new Point(330, 161);
            picPlayer.Margin = new Padding(4, 6, 4, 6);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(277, 321);
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer.TabIndex = 1;
            picPlayer.TabStop = false;
            // 
            // picCPU
            // 
            picCPU.Image = RockPapperScissors.Properties.Resources.rockscissor;
            picCPU.Location = new Point(998, 161);
            picCPU.Margin = new Padding(4, 6, 4, 6);
            picCPU.Name = "picCPU";
            picCPU.Size = new Size(277, 321);
            picCPU.SizeMode = PictureBoxSizeMode.StretchImage;
            picCPU.TabIndex = 1;
            picCPU.TabStop = false;
            picCPU.Click += PicCPU_Click;
            // 
            // txtMessage
            // 
            txtMessage.AutoSize = true;
            txtMessage.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtMessage.Image = (Image)resources.GetObject("txtMessage.Image");
            txtMessage.Location = new Point(612, 188);
            txtMessage.Margin = new Padding(4, 0, 4, 0);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(339, 33);
            txtMessage.TabIndex = 2;
            txtMessage.Text = "Player: 0 - Computer: 0";
            txtMessage.TextAlign = ContentAlignment.MiddleCenter;
            txtMessage.Click += TxtMessage_Click;
            // 
            // roundsText
            // 
            roundsText.AutoSize = true;
            roundsText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            roundsText.Image = RockPapperScissors.Properties.Resources.R__1_;
            roundsText.Location = new Point(704, 598);
            roundsText.Margin = new Padding(4, 0, 4, 0);
            roundsText.Name = "roundsText";
            roundsText.Size = new Size(147, 33);
            roundsText.TabIndex = 2;
            roundsText.Text = "Rounds 3";
            roundsText.Click += RoundsText_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1039, 649);
            button4.Margin = new Padding(4, 6, 4, 6);
            button4.Name = "button4";
            button4.Size = new Size(214, 75);
            button4.TabIndex = 3;
            button4.Text = "Restart";
            button4.UseVisualStyleBackColor = true;
            button4.Click += RestartGame;
            // 
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTime.Image = (Image)resources.GetObject("txtTime.Image");
            txtTime.Location = new Point(750, 358);
            txtTime.Margin = new Padding(4, 0, 4, 0);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(92, 37);
            txtTime.TabIndex = 2;
            txtTime.Text = "Time";
            // 
            // countDownTimer
            // 
            countDownTimer.Interval = 1000;
            countDownTimer.Tick += CountDownTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(363, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 46);
            label1.TabIndex = 4;
            label1.Text = "PLAYER";
            label1.Click += Label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(989, 59);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(249, 46);
            label4.TabIndex = 4;
            label4.Text = "COMPUTER";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1333, 772);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(roundsText);
            Controls.Add(txtTime);
            Controls.Add(txtMessage);
            Controls.Add(picCPU);
            Controls.Add(picPlayer);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Form1";
            ShowIcon = false;
            Text = "Rock Paper Scissors Marius Boncica";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCPU).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Label roundsText;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}


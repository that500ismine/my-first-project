namespace s1131710
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblScore = new Label();
            btnStart = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            picZombie00 = new PictureBox();
            picZombie01 = new PictureBox();
            picZombie02 = new PictureBox();
            picZombie03 = new PictureBox();
            picZombie04 = new PictureBox();
            picZombie05 = new PictureBox();
            picZombie10 = new PictureBox();
            picZombie11 = new PictureBox();
            picZombie12 = new PictureBox();
            picZombie13 = new PictureBox();
            picZombie14 = new PictureBox();
            picZombie15 = new PictureBox();
            picZombie20 = new PictureBox();
            picZombie21 = new PictureBox();
            picZombie22 = new PictureBox();
            picZombie23 = new PictureBox();
            picZombie24 = new PictureBox();
            picZombie25 = new PictureBox();
            picShoot0 = new PictureBox();
            picShoot1 = new PictureBox();
            picShoot2 = new PictureBox();
            progressTime = new ProgressBar();
            lblTime = new Label();
            btnShowScores = new Button();
            ((System.ComponentModel.ISupportInitialize)picZombie00).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie03).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie04).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie05).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picZombie25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShoot0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShoot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShoot2).BeginInit();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(38, 100);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(41, 20);
            lblScore.TabIndex = 0;
            lblScore.Text = "分數";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(38, 137);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "開始";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // picZombie00
            // 
            picZombie00.Image = Properties.Resources.zombie;
            picZombie00.Location = new Point(176, 26);
            picZombie00.Name = "picZombie00";
            picZombie00.Size = new Size(57, 63);
            picZombie00.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie00.TabIndex = 3;
            picZombie00.TabStop = false;
            // 
            // picZombie01
            // 
            picZombie01.Image = Properties.Resources.zombie;
            picZombie01.Location = new Point(176, 95);
            picZombie01.Name = "picZombie01";
            picZombie01.Size = new Size(57, 63);
            picZombie01.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie01.TabIndex = 5;
            picZombie01.TabStop = false;
            // 
            // picZombie02
            // 
            picZombie02.Image = Properties.Resources.zombie;
            picZombie02.Location = new Point(176, 164);
            picZombie02.Name = "picZombie02";
            picZombie02.Size = new Size(57, 63);
            picZombie02.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie02.TabIndex = 6;
            picZombie02.TabStop = false;
            // 
            // picZombie03
            // 
            picZombie03.Image = Properties.Resources.zombie;
            picZombie03.Location = new Point(176, 233);
            picZombie03.Name = "picZombie03";
            picZombie03.Size = new Size(57, 63);
            picZombie03.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie03.TabIndex = 7;
            picZombie03.TabStop = false;
            // 
            // picZombie04
            // 
            picZombie04.Image = Properties.Resources.zombie;
            picZombie04.Location = new Point(176, 302);
            picZombie04.Name = "picZombie04";
            picZombie04.Size = new Size(57, 63);
            picZombie04.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie04.TabIndex = 8;
            picZombie04.TabStop = false;
            // 
            // picZombie05
            // 
            picZombie05.Image = Properties.Resources.zombie;
            picZombie05.Location = new Point(176, 371);
            picZombie05.Name = "picZombie05";
            picZombie05.Size = new Size(57, 63);
            picZombie05.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie05.TabIndex = 9;
            picZombie05.TabStop = false;
            // 
            // picZombie10
            // 
            picZombie10.Image = Properties.Resources.zombie;
            picZombie10.Location = new Point(241, 26);
            picZombie10.Name = "picZombie10";
            picZombie10.Size = new Size(57, 63);
            picZombie10.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie10.TabIndex = 10;
            picZombie10.TabStop = false;
            // 
            // picZombie11
            // 
            picZombie11.Image = Properties.Resources.zombie;
            picZombie11.Location = new Point(241, 95);
            picZombie11.Name = "picZombie11";
            picZombie11.Size = new Size(57, 63);
            picZombie11.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie11.TabIndex = 11;
            picZombie11.TabStop = false;
            // 
            // picZombie12
            // 
            picZombie12.Image = Properties.Resources.zombie;
            picZombie12.Location = new Point(241, 164);
            picZombie12.Name = "picZombie12";
            picZombie12.Size = new Size(57, 63);
            picZombie12.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie12.TabIndex = 12;
            picZombie12.TabStop = false;
            // 
            // picZombie13
            // 
            picZombie13.Image = Properties.Resources.zombie;
            picZombie13.Location = new Point(241, 233);
            picZombie13.Name = "picZombie13";
            picZombie13.Size = new Size(57, 61);
            picZombie13.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie13.TabIndex = 13;
            picZombie13.TabStop = false;
            // 
            // picZombie14
            // 
            picZombie14.Image = Properties.Resources.zombie;
            picZombie14.Location = new Point(241, 302);
            picZombie14.Name = "picZombie14";
            picZombie14.Size = new Size(57, 61);
            picZombie14.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie14.TabIndex = 14;
            picZombie14.TabStop = false;
            // 
            // picZombie15
            // 
            picZombie15.Image = Properties.Resources.zombie;
            picZombie15.Location = new Point(241, 371);
            picZombie15.Name = "picZombie15";
            picZombie15.Size = new Size(57, 61);
            picZombie15.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie15.TabIndex = 15;
            picZombie15.TabStop = false;
            // 
            // picZombie20
            // 
            picZombie20.Image = Properties.Resources.zombie;
            picZombie20.Location = new Point(306, 26);
            picZombie20.Name = "picZombie20";
            picZombie20.Size = new Size(57, 63);
            picZombie20.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie20.TabIndex = 16;
            picZombie20.TabStop = false;
            // 
            // picZombie21
            // 
            picZombie21.Image = Properties.Resources.zombie;
            picZombie21.Location = new Point(306, 95);
            picZombie21.Name = "picZombie21";
            picZombie21.Size = new Size(57, 63);
            picZombie21.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie21.TabIndex = 17;
            picZombie21.TabStop = false;
            // 
            // picZombie22
            // 
            picZombie22.Image = Properties.Resources.zombie;
            picZombie22.Location = new Point(306, 164);
            picZombie22.Name = "picZombie22";
            picZombie22.Size = new Size(57, 63);
            picZombie22.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie22.TabIndex = 18;
            picZombie22.TabStop = false;
            // 
            // picZombie23
            // 
            picZombie23.Image = Properties.Resources.zombie;
            picZombie23.Location = new Point(306, 233);
            picZombie23.Name = "picZombie23";
            picZombie23.Size = new Size(57, 61);
            picZombie23.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie23.TabIndex = 19;
            picZombie23.TabStop = false;
            // 
            // picZombie24
            // 
            picZombie24.Image = Properties.Resources.zombie;
            picZombie24.Location = new Point(306, 302);
            picZombie24.Name = "picZombie24";
            picZombie24.Size = new Size(57, 61);
            picZombie24.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie24.TabIndex = 20;
            picZombie24.TabStop = false;
            // 
            // picZombie25
            // 
            picZombie25.Image = Properties.Resources.zombie;
            picZombie25.Location = new Point(306, 371);
            picZombie25.Name = "picZombie25";
            picZombie25.Size = new Size(57, 61);
            picZombie25.SizeMode = PictureBoxSizeMode.Zoom;
            picZombie25.TabIndex = 21;
            picZombie25.TabStop = false;
            // 
            // picShoot0
            // 
            picShoot0.Image = Properties.Resources.shoot;
            picShoot0.Location = new Point(176, 440);
            picShoot0.Name = "picShoot0";
            picShoot0.Size = new Size(52, 55);
            picShoot0.SizeMode = PictureBoxSizeMode.Zoom;
            picShoot0.TabIndex = 23;
            picShoot0.TabStop = false;
            picShoot0.Click += picShoot0_Click;
            // 
            // picShoot1
            // 
            picShoot1.Image = Properties.Resources.shoot;
            picShoot1.Location = new Point(241, 438);
            picShoot1.Name = "picShoot1";
            picShoot1.Size = new Size(52, 55);
            picShoot1.SizeMode = PictureBoxSizeMode.Zoom;
            picShoot1.TabIndex = 24;
            picShoot1.TabStop = false;
            picShoot1.Click += picShoot1_Click;
            // 
            // picShoot2
            // 
            picShoot2.Image = Properties.Resources.shoot;
            picShoot2.Location = new Point(306, 438);
            picShoot2.Name = "picShoot2";
            picShoot2.Size = new Size(52, 55);
            picShoot2.SizeMode = PictureBoxSizeMode.Zoom;
            picShoot2.TabIndex = 25;
            picShoot2.TabStop = false;
            picShoot2.Click += picShoot2_Click;
            // 
            // progressTime
            // 
            progressTime.Location = new Point(38, 26);
            progressTime.Maximum = 30;
            progressTime.Name = "progressTime";
            progressTime.Size = new Size(100, 23);
            progressTime.TabIndex = 26;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(38, 61);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(41, 20);
            lblTime.TabIndex = 1;
            lblTime.Text = "時間";
            // 
            // btnShowScores
            // 
            btnShowScores.Location = new Point(38, 176);
            btnShowScores.Name = "btnShowScores";
            btnShowScores.Size = new Size(75, 23);
            btnShowScores.TabIndex = 27;
            btnShowScores.Text = "排名";
            btnShowScores.UseVisualStyleBackColor = true;
            btnShowScores.Click += btnShowScores_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 570);
            Controls.Add(btnShowScores);
            Controls.Add(picShoot2);
            Controls.Add(picShoot1);
            Controls.Add(picZombie25);
            Controls.Add(picZombie10);
            Controls.Add(picZombie24);
            Controls.Add(picZombie00);
            Controls.Add(picZombie23);
            Controls.Add(picZombie15);
            Controls.Add(picZombie14);
            Controls.Add(picZombie20);
            Controls.Add(picZombie13);
            Controls.Add(btnStart);
            Controls.Add(progressTime);
            Controls.Add(picZombie12);
            Controls.Add(lblScore);
            Controls.Add(picZombie22);
            Controls.Add(lblTime);
            Controls.Add(picZombie11);
            Controls.Add(picZombie21);
            Controls.Add(picZombie01);
            Controls.Add(picZombie02);
            Controls.Add(picZombie03);
            Controls.Add(picShoot0);
            Controls.Add(picZombie04);
            Controls.Add(picZombie05);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picZombie00).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie01).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie02).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie03).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie04).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie05).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie10).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie11).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie12).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie13).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie14).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie15).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie20).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie21).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie22).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie23).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie24).EndInit();
            ((System.ComponentModel.ISupportInitialize)picZombie25).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShoot0).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShoot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShoot2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private Button btnStart;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox picZombie00;
        private PictureBox picZombie01;
        private PictureBox picZombie02;
        private PictureBox picZombie03;
        private PictureBox picZombie04;
        private PictureBox picZombie05;
        private PictureBox picZombie10;
        private PictureBox picZombie11;
        private PictureBox picZombie12;
        private PictureBox picZombie13;
        private PictureBox picZombie14;
        private PictureBox picZombie15;
        private PictureBox picZombie20;
        private PictureBox picZombie21;
        private PictureBox picZombie22;
        private PictureBox picZombie23;
        private PictureBox picZombie24;
        private PictureBox picZombie25;
        private PictureBox picShoot0;
        private PictureBox picShoot1;
        private PictureBox picShoot2;
        private ProgressBar progressTime;
        private Label lblTime;
        private Button btnShowScores;
    }
}

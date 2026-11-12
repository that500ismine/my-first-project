using System;
using System.Drawing;
using System.Windows.Forms;

namespace s1131710
{
    public partial class Form1 : Form
    {
        PictureBox[,] zombies = new PictureBox[3, 6]; // 3 列 6 行的殭屍陣列
        int score = 0;         // 分數
        int timeLeft = 30;     // 倒數秒數
        Random rand = new Random();
        bool canShoot = true;
        System.Windows.Forms.Timer penaltyTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer bounceTimer = new System.Windows.Forms.Timer();
        PictureBox bouncingZombie = null;
        int originalTop = 0;
        int bounceState = 0;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;   // 讓表單優先接收鍵盤事件
            this.KeyDown += Form1_KeyDown;
            InitZombies(); // 初始化殭屍格子
            penaltyTimer.Interval = 500; // 0.5 秒
            penaltyTimer.Tick += PenaltyTimer_Tick;
            bounceTimer.Interval = 100; // 每50毫秒執行一次
            bounceTimer.Tick += BounceTimer_Tick;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J)
            {
                ShootColumn(0);  // J 鍵射擊第0列
            }
            else if (e.KeyCode == Keys.K)
            {
                ShootColumn(1);  // K 鍵射擊第1列
            }
            else if (e.KeyCode == Keys.L)
            {
                ShootColumn(2);  // L 鍵射擊第2列
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnStart.PerformClick();  // 模擬點擊「開始遊戲」按鈕
            }
        }

        // 初始化殭屍 PictureBox 陣列
        private void InitZombies()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    PictureBox pic = (PictureBox)this.Controls["picZombie" + row + col];
                    pic.Visible = false; // 一開始隱藏
                    pic.Click += Zombie_Click; // 加入點擊事件
                    zombies[row, col] = pic;
                }
            }
        }

        // 點擊殭屍事件
        private void Zombie_Click(object sender, EventArgs e)
        {
            PictureBox clicked = sender as PictureBox;
            if (clicked.Visible)
            {
                clicked.Visible = false;
                score++;
                lblScore.Text = "分數：" + score;
            }
        }

        // 開始遊戲按鈕事件
        private void btnStart_Click(object sender, EventArgs e)
        {
            RegenerateZombies(); // 開始時產生一輪
            score = 0;
            timeLeft = 30;
            lblScore.Text = "分數: 0";
            lblTime.Text = "剩餘時間: 30 秒";
            progressTime.Value = 30;

            btnStart.Enabled = false;
            gameTimer.Start();
        }

        // 控制時間倒數
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTime.Text = $"剩餘時間: {timeLeft} 秒";
            progressTime.Value = timeLeft;

            if (timeLeft <= 0)
            {
                gameTimer.Stop();
                HideAllZombies();
                btnStart.Enabled = true;
                SaveScore(score);
                MessageBox.Show($"遊戲結束！你的分數是：{score}", "結果");
            }
        }

        // 隱藏所有殭屍
        private void HideAllZombies()
        {
            foreach (PictureBox pic in zombies)
            {
                pic.Visible = false;
            }
        }

        private void picShoot0_Click(object sender, EventArgs e) => ShootColumn(0);
        private void picShoot1_Click(object sender, EventArgs e) => ShootColumn(1);
        private void picShoot2_Click(object sender, EventArgs e) => ShootColumn(2);

        // 射擊指定直排（col：第幾列）
        private void ShootColumn(int col)
        {
            if (!canShoot)
                return; // 射擊冷卻中，忽略這次射擊
            int bottomRow = 5; // 第6行（index從0開始是5）
            if (zombies[col, bottomRow].Visible)
            {
                // 射擊成功，隱藏該格殭屍
                zombies[col, bottomRow].Visible = false;
                score++;
                lblScore.Text = "分數：" + score;

                // 射擊成功後，整個陣列殭屍都往下遞補
                ShiftZombiesDown();
            }
            else
            {
                canShoot = false;
                penaltyTimer.Start();
                for (int c = 0; c < 3; c++)
                {
                    if (zombies[c, 5].Visible)
                    {
                        bouncingZombie = zombies[c, 5];
                        originalTop = bouncingZombie.Top;
                        bounceTimer.Start();
                        break; // 只跳第一個找到的殭屍
                    }
                }
            }
        }

        // 每一橫排產生一隻殭屍
        private void RegenerateZombies()
        {
            HideAllZombies(); // 清空

            for (int row = 0; row < 6; row++) // 共 6 行（橫排）
            {
                int col = rand.Next(3); // 隨機 3 列中一個位置
                zombies[col, row].Visible = true;
            }
        }

        private void ShiftZombiesDown()
        {
            for (int col = 0; col < 3; col++)
            {
                // 從倒數第二行往上搬移殭屍到下一行
                for (int row = 4; row >= 0; row--)
                {
                    zombies[col, row + 1].Visible = zombies[col, row].Visible;
                }
                // 先清空第一行
                zombies[col, 0].Visible = false;
            }
            // 隨機選一列產生殭屍
            int randCol = rand.Next(3);
            zombies[randCol, 0].Visible = true;
        }

        private void PenaltyTimer_Tick(object sender, EventArgs e)
        {
            canShoot = true;
            penaltyTimer.Stop();
        }

        private void BounceTimer_Tick(object sender, EventArgs e)
        {
            if (bouncingZombie == null) return;

            if (bounceState == 0)
            {
                // 往上移動
                bouncingZombie.Top -= 50;
                bounceState = 1;
            }
            else if (bounceState == 1)
            {
                // 回原位
                bouncingZombie.Top = originalTop;
                bounceState = 0;
                bouncingZombie = null;
                bounceTimer.Stop();
            }
        }

        private void SaveScore(int score)
        {
            string path = "score.txt";
            using (StreamWriter writer = new StreamWriter(path, true)) // 附加寫入
            {
                writer.WriteLine($"{DateTime.Now:yyyy/MM/dd HH:mm:ss},{score}");
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnShowScores_Click(object sender, EventArgs e)
        {
            FormScore form = new FormScore();
            form.ShowDialog();
        }
    }
}

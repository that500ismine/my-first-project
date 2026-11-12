using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s1131710
{
    public partial class FormScore : Form
    {
        public FormScore()
        {
            InitializeComponent();
            LoadScores();
        }

        private void LoadScores()
        {
            string path = "score.txt";
            if (!File.Exists(path)) return;

            var scores = new List<(DateTime time, int score)>();

            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split(',');
                if (parts.Length == 2 &&
                    DateTime.TryParse(parts[0], out DateTime dt) &&
                    int.TryParse(parts[1], out int sc))
                {
                    scores.Add((dt, sc));
                }
            }

            // 排序（高分在前）
            var sorted = scores.OrderByDescending(s => s.score);

            listScores.Items.Clear();
            foreach (var s in sorted)
            {
                listScores.Items.Add($"{s.time:MM/dd HH:mm} → 分數：{s.score}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

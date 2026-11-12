namespace s1131710
{
    partial class FormScore
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
            listScores = new ListBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // listScores
            // 
            listScores.Dock = DockStyle.Fill;
            listScores.FormattingEnabled = true;
            listScores.ItemHeight = 15;
            listScores.Location = new Point(0, 0);
            listScores.Name = "listScores";
            listScores.Size = new Size(800, 450);
            listScores.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(681, 399);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 39);
            btnBack.TabIndex = 1;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FormScore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(listScores);
            Name = "FormScore";
            Text = "FormScore";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listScores;
        private Button btnBack;
    }
}
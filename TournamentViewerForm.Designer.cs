namespace TrackerUI
{
    partial class TournamentViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewer));
            HeaderLabel = new Label();
            TournamentName = new Label();
            RoundLabel = new Label();
            RoundDropBox = new ComboBox();
            checkBox1 = new CheckBox();
            MatchUpListBox = new ListBox();
            TeamOneName = new Label();
            TeamTwoName = new Label();
            TeamOneScoreLabel = new Label();
            TeamTwoScoreLabel = new Label();
            TeamOneScoreValue = new TextBox();
            TeamTwoScoreValue = new TextBox();
            Versus = new Label();
            ScoreButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = SystemColors.MenuHighlight;
            HeaderLabel.Location = new Point(12, 35);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(191, 40);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Tournament:";
            HeaderLabel.Click += label1_Click_1;
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TournamentName.ForeColor = SystemColors.MenuHighlight;
            TournamentName.Location = new Point(209, 35);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(125, 40);
            TournamentName.TabIndex = 1;
            TournamentName.Text = "<none>";
            TournamentName.Click += TournamentName_Click;
            // 
            // RoundLabel
            // 
            RoundLabel.AutoSize = true;
            RoundLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RoundLabel.ForeColor = SystemColors.MenuHighlight;
            RoundLabel.Location = new Point(12, 104);
            RoundLabel.Name = "RoundLabel";
            RoundLabel.Size = new Size(76, 30);
            RoundLabel.TabIndex = 2;
            RoundLabel.Text = "Round";
            // 
            // RoundDropBox
            // 
            RoundDropBox.FormattingEnabled = true;
            RoundDropBox.Location = new Point(95, 111);
            RoundDropBox.Name = "RoundDropBox";
            RoundDropBox.Size = new Size(239, 23);
            RoundDropBox.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.MenuHighlight;
            checkBox1.Location = new Point(95, 140);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Unplayed Only";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // MatchUpListBox
            // 
            MatchUpListBox.BorderStyle = BorderStyle.FixedSingle;
            MatchUpListBox.FormattingEnabled = true;
            MatchUpListBox.ItemHeight = 15;
            MatchUpListBox.Location = new Point(13, 199);
            MatchUpListBox.Name = "MatchUpListBox";
            MatchUpListBox.Size = new Size(339, 242);
            MatchUpListBox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            TeamOneName.AutoSize = true;
            TeamOneName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TeamOneName.ForeColor = SystemColors.MenuHighlight;
            TeamOneName.Location = new Point(411, 219);
            TeamOneName.Name = "TeamOneName";
            TeamOneName.Size = new Size(143, 30);
            TeamOneName.TabIndex = 6;
            TeamOneName.Text = "<Team One>";
            // 
            // TeamTwoName
            // 
            TeamTwoName.AutoSize = true;
            TeamTwoName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TeamTwoName.ForeColor = SystemColors.MenuHighlight;
            TeamTwoName.Location = new Point(409, 339);
            TeamTwoName.Name = "TeamTwoName";
            TeamTwoName.Size = new Size(144, 30);
            TeamTwoName.TabIndex = 7;
            TeamTwoName.Text = "<Team Two>";
            // 
            // TeamOneScoreLabel
            // 
            TeamOneScoreLabel.AutoSize = true;
            TeamOneScoreLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TeamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            TeamOneScoreLabel.Location = new Point(411, 249);
            TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            TeamOneScoreLabel.Size = new Size(65, 30);
            TeamOneScoreLabel.TabIndex = 8;
            TeamOneScoreLabel.Text = "Score";
            // 
            // TeamTwoScoreLabel
            // 
            TeamTwoScoreLabel.AutoSize = true;
            TeamTwoScoreLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TeamTwoScoreLabel.ForeColor = SystemColors.MenuHighlight;
            TeamTwoScoreLabel.Location = new Point(411, 369);
            TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            TeamTwoScoreLabel.Size = new Size(65, 30);
            TeamTwoScoreLabel.TabIndex = 9;
            TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            TeamOneScoreValue.Location = new Point(509, 256);
            TeamOneScoreValue.Name = "TeamOneScoreValue";
            TeamOneScoreValue.Size = new Size(100, 23);
            TeamOneScoreValue.TabIndex = 10;
            // 
            // TeamTwoScoreValue
            // 
            TeamTwoScoreValue.Location = new Point(509, 376);
            TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            TeamTwoScoreValue.Size = new Size(100, 23);
            TeamTwoScoreValue.TabIndex = 11;
            // 
            // Versus
            // 
            Versus.AutoSize = true;
            Versus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Versus.ForeColor = SystemColors.MenuHighlight;
            Versus.Location = new Point(485, 298);
            Versus.Name = "Versus";
            Versus.Size = new Size(38, 30);
            Versus.TabIndex = 12;
            Versus.Text = "VS";
            // 
            // ScoreButton
            // 
            ScoreButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreButton.ForeColor = SystemColors.MenuHighlight;
            ScoreButton.Location = new Point(628, 298);
            ScoreButton.Name = "ScoreButton";
            ScoreButton.Size = new Size(91, 38);
            ScoreButton.TabIndex = 13;
            ScoreButton.Text = "Score";
            ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ScoreButton);
            Controls.Add(Versus);
            Controls.Add(TeamTwoScoreValue);
            Controls.Add(TeamOneScoreValue);
            Controls.Add(TeamTwoScoreLabel);
            Controls.Add(TeamOneScoreLabel);
            Controls.Add(TeamTwoName);
            Controls.Add(TeamOneName);
            Controls.Add(MatchUpListBox);
            Controls.Add(checkBox1);
            Controls.Add(RoundDropBox);
            Controls.Add(RoundLabel);
            Controls.Add(TournamentName);
            Controls.Add(HeaderLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TournamentViewer";
            Text = "Tournament View";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label TournamentName;
        private Label RoundLabel;
        private ComboBox RoundDropBox;
        private CheckBox checkBox1;
        private ListBox MatchUpListBox;
        private Label TeamOneName;
        private Label TeamTwoName;
        private Label TeamOneScoreLabel;
        private Label TeamTwoScoreLabel;
        private TextBox TeamOneScoreValue;
        private TextBox TeamTwoScoreValue;
        private Label Versus;
        private Button ScoreButton;
    }
}

namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            HeaderLabel = new Label();
            TeamNameValue = new TextBox();
            EntreFeeValue = new TextBox();
            EntryFeeLabel = new Label();
            SelectTeamDropDown = new ComboBox();
            SelectTeamLabel = new Label();
            CreateNewTeamLink = new LinkLabel();
            AddTeamButton = new Button();
            CreatePrizeButton = new Button();
            TournamentTeamListBox = new ListBox();
            TournamentPlayersLabel = new Label();
            RemoveSelectedPlayersButton = new Button();
            RemoveSelectedPrizeButton = new Button();
            PrizesLabel = new Label();
            prizesListBox = new ListBox();
            CreateTournamentButton = new Button();
            TournamentName = new Label();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = SystemColors.MenuHighlight;
            HeaderLabel.Location = new Point(12, 24);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(287, 40);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Create Tournament:";
            // 
            // TeamNameValue
            // 
            TeamNameValue.Location = new Point(47, 138);
            TeamNameValue.Name = "TeamNameValue";
            TeamNameValue.Size = new Size(315, 35);
            TeamNameValue.TabIndex = 12;
            TeamNameValue.TextChanged += TeamOneScoreValue_TextChanged;
            // 
            // EntreFeeValue
            // 
            EntreFeeValue.Location = new Point(156, 212);
            EntreFeeValue.Name = "EntreFeeValue";
            EntreFeeValue.Size = new Size(111, 35);
            EntreFeeValue.TabIndex = 14;
            EntreFeeValue.Text = "0";
            EntreFeeValue.TextChanged += textBox1_TextChanged;
            // 
            // EntryFeeLabel
            // 
            EntryFeeLabel.AutoSize = true;
            EntryFeeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            EntryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            EntryFeeLabel.Location = new Point(47, 212);
            EntryFeeLabel.Name = "EntryFeeLabel";
            EntryFeeLabel.Size = new Size(103, 30);
            EntryFeeLabel.TabIndex = 13;
            EntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamDropDown
            // 
            SelectTeamDropDown.FormattingEnabled = true;
            SelectTeamDropDown.Location = new Point(47, 342);
            SelectTeamDropDown.Name = "SelectTeamDropDown";
            SelectTeamDropDown.Size = new Size(315, 38);
            SelectTeamDropDown.TabIndex = 16;
            SelectTeamDropDown.SelectedIndexChanged += SelectTeamDropDown_SelectedIndexChanged;
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SelectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            SelectTeamLabel.Location = new Point(47, 309);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(131, 30);
            SelectTeamLabel.TabIndex = 15;
            SelectTeamLabel.Text = "Select Team";
            // 
            // CreateNewTeamLink
            // 
            CreateNewTeamLink.AutoSize = true;
            CreateNewTeamLink.Location = new Point(185, 309);
            CreateNewTeamLink.Name = "CreateNewTeamLink";
            CreateNewTeamLink.Size = new Size(122, 30);
            CreateNewTeamLink.TabIndex = 17;
            CreateNewTeamLink.TabStop = true;
            CreateNewTeamLink.Text = "Create new";
            CreateNewTeamLink.LinkClicked += CreateNewTeamLink_LinkClicked;
            // 
            // AddTeamButton
            // 
            AddTeamButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddTeamButton.ForeColor = SystemColors.MenuHighlight;
            AddTeamButton.Location = new Point(131, 398);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(168, 38);
            AddTeamButton.TabIndex = 18;
            AddTeamButton.Text = "ADD Team";
            AddTeamButton.UseVisualStyleBackColor = true;
            AddTeamButton.Click += AddTeamButton_Click;
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePrizeButton.ForeColor = SystemColors.MenuHighlight;
            CreatePrizeButton.Location = new Point(131, 442);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(168, 42);
            CreatePrizeButton.TabIndex = 19;
            CreatePrizeButton.Text = "Create  Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            CreatePrizeButton.Click += CreatePrizeButton_Click;
            // 
            // TournamentTeamListBox
            // 
            TournamentTeamListBox.BorderStyle = BorderStyle.FixedSingle;
            TournamentTeamListBox.FormattingEnabled = true;
            TournamentTeamListBox.ItemHeight = 30;
            TournamentTeamListBox.Location = new Point(378, 138);
            TournamentTeamListBox.Name = "TournamentTeamListBox";
            TournamentTeamListBox.Size = new Size(288, 92);
            TournamentTeamListBox.TabIndex = 20;
            TournamentTeamListBox.SelectedIndexChanged += TournamentPlayersListBox_SelectedIndexChanged;
            // 
            // TournamentPlayersLabel
            // 
            TournamentPlayersLabel.AutoSize = true;
            TournamentPlayersLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TournamentPlayersLabel.ForeColor = SystemColors.MenuHighlight;
            TournamentPlayersLabel.Location = new Point(378, 92);
            TournamentPlayersLabel.Name = "TournamentPlayersLabel";
            TournamentPlayersLabel.Size = new Size(159, 30);
            TournamentPlayersLabel.TabIndex = 21;
            TournamentPlayersLabel.Text = "Team / Players";
            // 
            // RemoveSelectedPlayersButton
            // 
            RemoveSelectedPlayersButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveSelectedPlayersButton.ForeColor = SystemColors.MenuHighlight;
            RemoveSelectedPlayersButton.Location = new Point(543, 96);
            RemoveSelectedPlayersButton.Name = "RemoveSelectedPlayersButton";
            RemoveSelectedPlayersButton.Size = new Size(123, 36);
            RemoveSelectedPlayersButton.TabIndex = 22;
            RemoveSelectedPlayersButton.Text = "Remove Selected";
            RemoveSelectedPlayersButton.UseVisualStyleBackColor = true;
            RemoveSelectedPlayersButton.Click += RemoveSelectedPlayersButton_Click;
            // 
            // RemoveSelectedPrizeButton
            // 
            RemoveSelectedPrizeButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveSelectedPrizeButton.ForeColor = SystemColors.MenuHighlight;
            RemoveSelectedPrizeButton.Location = new Point(543, 339);
            RemoveSelectedPrizeButton.Name = "RemoveSelectedPrizeButton";
            RemoveSelectedPrizeButton.Size = new Size(123, 36);
            RemoveSelectedPrizeButton.TabIndex = 25;
            RemoveSelectedPrizeButton.Text = "Remove Selected";
            RemoveSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            PrizesLabel.AutoSize = true;
            PrizesLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PrizesLabel.ForeColor = SystemColors.MenuHighlight;
            PrizesLabel.Location = new Point(378, 335);
            PrizesLabel.Name = "PrizesLabel";
            PrizesLabel.Size = new Size(63, 30);
            PrizesLabel.TabIndex = 24;
            PrizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 30;
            prizesListBox.Location = new Point(378, 381);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(288, 92);
            prizesListBox.TabIndex = 23;
            prizesListBox.SelectedIndexChanged += prizesListBox_SelectedIndexChanged;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentButton.ForeColor = SystemColors.MenuHighlight;
            CreateTournamentButton.Location = new Point(234, 517);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(227, 42);
            CreateTournamentButton.TabIndex = 26;
            CreateTournamentButton.Text = "Create  Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            CreateTournamentButton.Click += CreateTournamentButton_Click;
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TournamentName.ForeColor = SystemColors.MenuHighlight;
            TournamentName.Location = new Point(47, 96);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(199, 30);
            TournamentName.TabIndex = 27;
            TournamentName.Text = "Tournament Name";
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 571);
            Controls.Add(TournamentName);
            Controls.Add(CreateTournamentButton);
            Controls.Add(RemoveSelectedPrizeButton);
            Controls.Add(PrizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(RemoveSelectedPlayersButton);
            Controls.Add(TournamentPlayersLabel);
            Controls.Add(TournamentTeamListBox);
            Controls.Add(CreatePrizeButton);
            Controls.Add(AddTeamButton);
            Controls.Add(CreateNewTeamLink);
            Controls.Add(SelectTeamDropDown);
            Controls.Add(SelectTeamLabel);
            Controls.Add(EntreFeeValue);
            Controls.Add(EntryFeeLabel);
            Controls.Add(TeamNameValue);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private TextBox TeamNameValue;
        private TextBox EntreFeeValue;
        private Label EntryFeeLabel;
        private ComboBox SelectTeamDropDown;
        private Label SelectTeamLabel;
        private LinkLabel CreateNewTeamLink;
        private Button AddTeamButton;
        private Button CreatePrizeButton;
        private ListBox TournamentTeamListBox;
        private Label TournamentPlayersLabel;
        private Button RemoveSelectedPlayersButton;
        private Button RemoveSelectedPrizeButton;
        private Label PrizesLabel;
        private ListBox prizesListBox;
        private Button CreateTournamentButton;
        private Label TournamentName;
    }
}
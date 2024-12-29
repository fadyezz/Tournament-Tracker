namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            HeaderLabel = new Label();
            TeamNameLabel = new Label();
            TeamNameValue = new TextBox();
            AddMemberButton = new Button();
            SelectTeamMemberDropDown = new ComboBox();
            SelectTeamMemberLabel = new Label();
            groupBox1 = new GroupBox();
            FirstNameValue = new TextBox();
            CreateMemberButton = new Button();
            CellPhoneLabel = new Label();
            CellPhoneValue = new TextBox();
            EmailLabel = new Label();
            EmailValue = new TextBox();
            LastNameLabel = new Label();
            LastNameTextValue = new TextBox();
            FirstNameLabel = new Label();
            TeamMemberListBox = new ListBox();
            RemoveSelectedMemberButton = new Button();
            CreateTeamButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = SystemColors.MenuHighlight;
            HeaderLabel.Location = new Point(31, 34);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(196, 40);
            HeaderLabel.TabIndex = 2;
            HeaderLabel.Text = "Create Team:";
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TeamNameLabel.ForeColor = SystemColors.MenuHighlight;
            TeamNameLabel.Location = new Point(42, 93);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(132, 30);
            TeamNameLabel.TabIndex = 28;
            TeamNameLabel.Text = "Team Name";
            // 
            // TeamNameValue
            // 
            TeamNameValue.Location = new Point(42, 143);
            TeamNameValue.Name = "TeamNameValue";
            TeamNameValue.Size = new Size(315, 23);
            TeamNameValue.TabIndex = 29;
            TeamNameValue.TextChanged += TeamNameValue_TextChanged;
            // 
            // AddMemberButton
            // 
            AddMemberButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMemberButton.ForeColor = SystemColors.MenuHighlight;
            AddMemberButton.Location = new Point(90, 287);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(168, 38);
            AddMemberButton.TabIndex = 32;
            AddMemberButton.Text = "ADD Member";
            AddMemberButton.UseVisualStyleBackColor = true;
            AddMemberButton.Click += AddMemberButton_Click;
            // 
            // SelectTeamMemberDropDown
            // 
            SelectTeamMemberDropDown.FormattingEnabled = true;
            SelectTeamMemberDropDown.Location = new Point(42, 247);
            SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            SelectTeamMemberDropDown.Size = new Size(315, 23);
            SelectTeamMemberDropDown.TabIndex = 31;
            SelectTeamMemberDropDown.SelectedIndexChanged += SelectTeamMemberDropDown_SelectedIndexChanged;
            // 
            // SelectTeamMemberLabel
            // 
            SelectTeamMemberLabel.AutoSize = true;
            SelectTeamMemberLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SelectTeamMemberLabel.ForeColor = SystemColors.MenuHighlight;
            SelectTeamMemberLabel.Location = new Point(42, 200);
            SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            SelectTeamMemberLabel.Size = new Size(216, 30);
            SelectTeamMemberLabel.TabIndex = 30;
            SelectTeamMemberLabel.Text = "Select Team Member";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FirstNameValue);
            groupBox1.Controls.Add(CreateMemberButton);
            groupBox1.Controls.Add(CellPhoneLabel);
            groupBox1.Controls.Add(CellPhoneValue);
            groupBox1.Controls.Add(EmailLabel);
            groupBox1.Controls.Add(EmailValue);
            groupBox1.Controls.Add(LastNameLabel);
            groupBox1.Controls.Add(LastNameTextValue);
            groupBox1.Controls.Add(FirstNameLabel);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(42, 331);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 232);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // FirstNameValue
            // 
            FirstNameValue.Location = new Point(133, 22);
            FirstNameValue.Name = "FirstNameValue";
            FirstNameValue.Size = new Size(167, 23);
            FirstNameValue.TabIndex = 34;
            // 
            // CreateMemberButton
            // 
            CreateMemberButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateMemberButton.ForeColor = SystemColors.MenuHighlight;
            CreateMemberButton.Location = new Point(65, 168);
            CreateMemberButton.Name = "CreateMemberButton";
            CreateMemberButton.Size = new Size(137, 31);
            CreateMemberButton.TabIndex = 33;
            CreateMemberButton.Text = "Create Member";
            CreateMemberButton.UseVisualStyleBackColor = true;
            CreateMemberButton.Click += CreateMemberButton_Click;
            // 
            // CellPhoneLabel
            // 
            CellPhoneLabel.AutoSize = true;
            CellPhoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            CellPhoneLabel.ForeColor = SystemColors.MenuHighlight;
            CellPhoneLabel.Location = new Point(28, 112);
            CellPhoneLabel.Name = "CellPhoneLabel";
            CellPhoneLabel.Size = new Size(60, 21);
            CellPhoneLabel.TabIndex = 18;
            CellPhoneLabel.Text = "Mobile";
            // 
            // CellPhoneValue
            // 
            CellPhoneValue.Location = new Point(133, 110);
            CellPhoneValue.Name = "CellPhoneValue";
            CellPhoneValue.Size = new Size(167, 23);
            CellPhoneValue.TabIndex = 17;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            EmailLabel.ForeColor = SystemColors.MenuHighlight;
            EmailLabel.Location = new Point(28, 81);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(52, 21);
            EmailLabel.TabIndex = 16;
            EmailLabel.Text = "Email";
            // 
            // EmailValue
            // 
            EmailValue.Location = new Point(133, 81);
            EmailValue.Name = "EmailValue";
            EmailValue.Size = new Size(167, 23);
            EmailValue.TabIndex = 15;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            LastNameLabel.ForeColor = SystemColors.MenuHighlight;
            LastNameLabel.Location = new Point(28, 51);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(89, 21);
            LastNameLabel.TabIndex = 14;
            LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextValue
            // 
            LastNameTextValue.Location = new Point(133, 51);
            LastNameTextValue.Name = "LastNameTextValue";
            LastNameTextValue.Size = new Size(167, 23);
            LastNameTextValue.TabIndex = 13;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            FirstNameLabel.ForeColor = SystemColors.MenuHighlight;
            FirstNameLabel.Location = new Point(28, 21);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(91, 21);
            FirstNameLabel.TabIndex = 11;
            FirstNameLabel.Text = "First Name";
            // 
            // TeamMemberListBox
            // 
            TeamMemberListBox.FormattingEnabled = true;
            TeamMemberListBox.ItemHeight = 15;
            TeamMemberListBox.Location = new Point(447, 93);
            TeamMemberListBox.Name = "TeamMemberListBox";
            TeamMemberListBox.Size = new Size(301, 319);
            TeamMemberListBox.TabIndex = 34;
            TeamMemberListBox.SelectedIndexChanged += TeamMemberListBox_SelectedIndexChanged;
            // 
            // RemoveSelectedMemberButton
            // 
            RemoveSelectedMemberButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveSelectedMemberButton.ForeColor = SystemColors.MenuHighlight;
            RemoveSelectedMemberButton.Location = new Point(528, 418);
            RemoveSelectedMemberButton.Name = "RemoveSelectedMemberButton";
            RemoveSelectedMemberButton.Size = new Size(123, 36);
            RemoveSelectedMemberButton.TabIndex = 35;
            RemoveSelectedMemberButton.Text = "Remove Selected";
            RemoveSelectedMemberButton.UseVisualStyleBackColor = true;
            RemoveSelectedMemberButton.Click += RemoveSelectedMemberButton_Click;
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTeamButton.ForeColor = SystemColors.MenuHighlight;
            CreateTeamButton.Location = new Point(363, 512);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.Size = new Size(245, 51);
            CreateTeamButton.TabIndex = 36;
            CreateTeamButton.Text = "Create Team";
            CreateTeamButton.UseVisualStyleBackColor = true;
            CreateTeamButton.Click += CreateTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 582);
            Controls.Add(CreateTeamButton);
            Controls.Add(RemoveSelectedMemberButton);
            Controls.Add(TeamMemberListBox);
            Controls.Add(groupBox1);
            Controls.Add(AddMemberButton);
            Controls.Add(SelectTeamMemberDropDown);
            Controls.Add(SelectTeamMemberLabel);
            Controls.Add(TeamNameValue);
            Controls.Add(TeamNameLabel);
            Controls.Add(HeaderLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTeamForm";
            Text = "Create Team Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label TeamNameLabel;
        private TextBox TeamNameValue;
        private Button AddMemberButton;
        private ComboBox SelectTeamMemberDropDown;
        private Label SelectTeamMemberLabel;
        private GroupBox groupBox1;
        private Label FirstNameLabel;
        private Label CellPhoneLabel;
        private TextBox CellPhoneValue;
        private Label EmailLabel;
        private TextBox EmailValue;
        private Label LastNameLabel;
        private TextBox LastNameTextValue;
        private Button CreateMemberButton;
        private ListBox TeamMemberListBox;
        private Button RemoveSelectedMemberButton;
        private Button CreateTeamButton;
        private TextBox FirstNameValue;
    }
}
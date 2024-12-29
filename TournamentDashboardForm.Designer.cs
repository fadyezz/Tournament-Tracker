namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            HeaderLabel = new Label();
            LoadExistingTournamentLabel = new Label();
            LoadExistingTournamentDropDown = new ComboBox();
            LoadTournamentButton = new Button();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = SystemColors.MenuHighlight;
            HeaderLabel.Location = new Point(122, 56);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(342, 40);
            HeaderLabel.TabIndex = 3;
            HeaderLabel.Text = "Tournament DashBoard";
            HeaderLabel.Click += HeaderLabel_Click;
            // 
            // LoadExistingTournamentLabel
            // 
            LoadExistingTournamentLabel.AutoSize = true;
            LoadExistingTournamentLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LoadExistingTournamentLabel.ForeColor = SystemColors.MenuHighlight;
            LoadExistingTournamentLabel.Location = new Point(107, 160);
            LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            LoadExistingTournamentLabel.Size = new Size(372, 40);
            LoadExistingTournamentLabel.TabIndex = 4;
            LoadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // LoadExistingTournamentDropDown
            // 
            LoadExistingTournamentDropDown.FormattingEnabled = true;
            LoadExistingTournamentDropDown.Location = new Point(136, 219);
            LoadExistingTournamentDropDown.Name = "LoadExistingTournamentDropDown";
            LoadExistingTournamentDropDown.Size = new Size(315, 38);
            LoadExistingTournamentDropDown.TabIndex = 32;
            // 
            // LoadTournamentButton
            // 
            LoadTournamentButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadTournamentButton.ForeColor = SystemColors.MenuHighlight;
            LoadTournamentButton.Location = new Point(209, 369);
            LoadTournamentButton.Name = "LoadTournamentButton";
            LoadTournamentButton.Size = new Size(168, 38);
            LoadTournamentButton.TabIndex = 33;
            LoadTournamentButton.Text = "Load Tournament";
            LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentButton.ForeColor = SystemColors.MenuHighlight;
            CreateTournamentButton.Location = new Point(171, 462);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(245, 51);
            CreateTournamentButton.TabIndex = 38;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 569);
            Controls.Add(CreateTournamentButton);
            Controls.Add(LoadTournamentButton);
            Controls.Add(LoadExistingTournamentDropDown);
            Controls.Add(LoadExistingTournamentLabel);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label LoadExistingTournamentLabel;
        private ComboBox LoadExistingTournamentDropDown;
        private Button LoadTournamentButton;
        private Button CreateTournamentButton;
    }
}
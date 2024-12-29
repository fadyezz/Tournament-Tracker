namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            HeaderLabel = new Label();
            PlaceNumberLabel = new Label();
            PlaceNumberValue = new TextBox();
            PrizeAmountLabel = new Label();
            PrizeAmoutValue = new TextBox();
            PlaceNameLabel = new Label();
            PlaceNameValue = new TextBox();
            PrizePercentageLabel = new Label();
            PrizePercentageValue = new TextBox();
            OrLabel = new Label();
            CreatePrizeButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = SystemColors.MenuHighlight;
            HeaderLabel.Location = new Point(12, 20);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(189, 40);
            HeaderLabel.TabIndex = 3;
            HeaderLabel.Text = "Create Prize:";
            // 
            // PlaceNumberLabel
            // 
            PlaceNumberLabel.AutoSize = true;
            PlaceNumberLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PlaceNumberLabel.ForeColor = SystemColors.MenuHighlight;
            PlaceNumberLabel.Location = new Point(15, 106);
            PlaceNumberLabel.Name = "PlaceNumberLabel";
            PlaceNumberLabel.Size = new Size(158, 30);
            PlaceNumberLabel.TabIndex = 16;
            PlaceNumberLabel.Text = "Place Number ";
            // 
            // PlaceNumberValue
            // 
            PlaceNumberValue.Location = new Point(190, 106);
            PlaceNumberValue.Name = "PlaceNumberValue";
            PlaceNumberValue.Size = new Size(167, 39);
            PlaceNumberValue.TabIndex = 15;
            PlaceNumberValue.TextChanged += LastNameTextValue_TextChanged;
            // 
            // PrizeAmountLabel
            // 
            PrizeAmountLabel.AutoSize = true;
            PrizeAmountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PrizeAmountLabel.ForeColor = SystemColors.MenuHighlight;
            PrizeAmountLabel.Location = new Point(15, 196);
            PrizeAmountLabel.Name = "PrizeAmountLabel";
            PrizeAmountLabel.Size = new Size(158, 30);
            PrizeAmountLabel.TabIndex = 18;
            PrizeAmountLabel.Text = "Place Amount ";
            // 
            // PrizeAmoutValue
            // 
            PrizeAmoutValue.Location = new Point(190, 196);
            PrizeAmoutValue.Name = "PrizeAmoutValue";
            PrizeAmoutValue.Size = new Size(167, 39);
            PrizeAmoutValue.TabIndex = 17;
            PrizeAmoutValue.Text = "0";
            // 
            // PlaceNameLabel
            // 
            PlaceNameLabel.AutoSize = true;
            PlaceNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PlaceNameLabel.ForeColor = SystemColors.MenuHighlight;
            PlaceNameLabel.Location = new Point(15, 151);
            PlaceNameLabel.Name = "PlaceNameLabel";
            PlaceNameLabel.Size = new Size(131, 30);
            PlaceNameLabel.TabIndex = 20;
            PlaceNameLabel.Text = "Place Name";
            // 
            // PlaceNameValue
            // 
            PlaceNameValue.Location = new Point(190, 151);
            PlaceNameValue.Name = "PlaceNameValue";
            PlaceNameValue.Size = new Size(167, 39);
            PlaceNameValue.TabIndex = 19;
            // 
            // PrizePercentageLabel
            // 
            PrizePercentageLabel.AutoSize = true;
            PrizePercentageLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PrizePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            PrizePercentageLabel.Location = new Point(12, 362);
            PrizePercentageLabel.Name = "PrizePercentageLabel";
            PrizePercentageLabel.Size = new Size(177, 30);
            PrizePercentageLabel.TabIndex = 22;
            PrizePercentageLabel.Text = "Prize Percentage";
            // 
            // PrizePercentageValue
            // 
            PrizePercentageValue.Location = new Point(195, 362);
            PrizePercentageValue.Name = "PrizePercentageValue";
            PrizePercentageValue.Size = new Size(167, 39);
            PrizePercentageValue.TabIndex = 21;
            PrizePercentageValue.Text = "0";
            PrizePercentageValue.TextChanged += PrizePercentageValue_TextChanged;
            // 
            // OrLabel
            // 
            OrLabel.AutoSize = true;
            OrLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            OrLabel.ForeColor = SystemColors.MenuHighlight;
            OrLabel.Location = new Point(190, 285);
            OrLabel.Name = "OrLabel";
            OrLabel.Size = new Size(42, 30);
            OrLabel.TabIndex = 23;
            OrLabel.Text = "OR";
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePrizeButton.ForeColor = SystemColors.MenuHighlight;
            CreatePrizeButton.Location = new Point(239, 535);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(245, 51);
            CreatePrizeButton.TabIndex = 37;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            CreatePrizeButton.Click += CreatePrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 633);
            Controls.Add(CreatePrizeButton);
            Controls.Add(OrLabel);
            Controls.Add(PrizePercentageLabel);
            Controls.Add(PrizePercentageValue);
            Controls.Add(PlaceNameLabel);
            Controls.Add(PlaceNameValue);
            Controls.Add(PrizeAmountLabel);
            Controls.Add(PrizeAmoutValue);
            Controls.Add(PlaceNumberLabel);
            Controls.Add(PlaceNumberValue);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label PlaceNumberLabel;
        private TextBox PlaceNumberValue;
        private Label PrizeAmountLabel;
        private TextBox PrizeAmoutValue;
        private Label PlaceNameLabel;
        private TextBox PlaceNameValue;
        private Label PrizePercentageLabel;
        private TextBox PrizePercentageValue;
        private Label OrLabel;
        private Button CreatePrizeButton;
    }
}
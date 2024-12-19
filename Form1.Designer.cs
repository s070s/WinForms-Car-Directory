namespace WinFormsApp
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
            CarGrid = new DataGridView();
            BrandEntryTextBox = new TextBox();
            BrandEntryLabel = new Label();
            ModelEntryTextBox = new TextBox();
            ModelEntryLabel = new Label();
            YearEntryTextBox = new TextBox();
            YearEntryLabel = new Label();
            SubmitEntryButton = new Button();
            DeleteEntryButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CarGrid).BeginInit();
            SuspendLayout();
            // 
            // CarGrid
            // 
            CarGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarGrid.Location = new Point(12, 278);
            CarGrid.MultiSelect = false;
            CarGrid.Name = "CarGrid";
            CarGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarGrid.Size = new Size(541, 150);
            CarGrid.TabIndex = 0;
            CarGrid.SelectionChanged += CarGrid_SelectionChanged;
            // 
            // BrandEntryTextBox
            // 
            BrandEntryTextBox.Location = new Point(232, 55);
            BrandEntryTextBox.Name = "BrandEntryTextBox";
            BrandEntryTextBox.Size = new Size(100, 23);
            BrandEntryTextBox.TabIndex = 1;
            // 
            // BrandEntryLabel
            // 
            BrandEntryLabel.AutoSize = true;
            BrandEntryLabel.Location = new Point(232, 37);
            BrandEntryLabel.Name = "BrandEntryLabel";
            BrandEntryLabel.Size = new Size(38, 15);
            BrandEntryLabel.TabIndex = 2;
            BrandEntryLabel.Text = "Brand";
            // 
            // ModelEntryTextBox
            // 
            ModelEntryTextBox.Location = new Point(232, 99);
            ModelEntryTextBox.Name = "ModelEntryTextBox";
            ModelEntryTextBox.Size = new Size(100, 23);
            ModelEntryTextBox.TabIndex = 1;
            // 
            // ModelEntryLabel
            // 
            ModelEntryLabel.AutoSize = true;
            ModelEntryLabel.Location = new Point(232, 81);
            ModelEntryLabel.Name = "ModelEntryLabel";
            ModelEntryLabel.Size = new Size(41, 15);
            ModelEntryLabel.TabIndex = 2;
            ModelEntryLabel.Text = "Model";
            // 
            // YearEntryTextBox
            // 
            YearEntryTextBox.Location = new Point(232, 143);
            YearEntryTextBox.Name = "YearEntryTextBox";
            YearEntryTextBox.Size = new Size(100, 23);
            YearEntryTextBox.TabIndex = 1;
            // 
            // YearEntryLabel
            // 
            YearEntryLabel.AutoSize = true;
            YearEntryLabel.Location = new Point(232, 125);
            YearEntryLabel.Name = "YearEntryLabel";
            YearEntryLabel.Size = new Size(29, 15);
            YearEntryLabel.TabIndex = 2;
            YearEntryLabel.Text = "Year";
            // 
            // SubmitEntryButton
            // 
            SubmitEntryButton.Location = new Point(249, 185);
            SubmitEntryButton.Name = "SubmitEntryButton";
            SubmitEntryButton.Size = new Size(75, 33);
            SubmitEntryButton.TabIndex = 3;
            SubmitEntryButton.Text = "Submit";
            SubmitEntryButton.UseVisualStyleBackColor = true;
            SubmitEntryButton.Click += SubmitEntryButton_Click;
            // 
            // DeleteEntryButton
            // 
            DeleteEntryButton.Location = new Point(446, 229);
            DeleteEntryButton.Name = "DeleteEntryButton";
            DeleteEntryButton.Size = new Size(107, 43);
            DeleteEntryButton.TabIndex = 4;
            DeleteEntryButton.Text = "Delete Selected";
            DeleteEntryButton.UseVisualStyleBackColor = true;
            DeleteEntryButton.Click += DeleteEntryButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 435);
            Controls.Add(DeleteEntryButton);
            Controls.Add(SubmitEntryButton);
            Controls.Add(YearEntryLabel);
            Controls.Add(YearEntryTextBox);
            Controls.Add(ModelEntryLabel);
            Controls.Add(ModelEntryTextBox);
            Controls.Add(BrandEntryLabel);
            Controls.Add(BrandEntryTextBox);
            Controls.Add(CarGrid);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)CarGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CarGrid;
        private TextBox BrandEntryTextBox;
        private Label BrandEntryLabel;
        private TextBox ModelEntryTextBox;
        private Label ModelEntryLabel;
        private TextBox YearEntryTextBox;
        private Label YearEntryLabel;
        private Button SubmitEntryButton;
        private Button DeleteEntryButton;
    }
}

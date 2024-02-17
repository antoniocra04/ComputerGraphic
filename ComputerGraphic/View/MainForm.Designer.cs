namespace ComputerGraphic
{
    partial class MainForm
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
            MainTableLayoutPanel = new TableLayoutPanel();
            RightLowerPanel = new Panel();
            LeftLowerPanel = new Panel();
            RightMiddlePanel = new Panel();
            LeftMiddlePanel = new Panel();
            LeftTopPanel = new Panel();
            RightTopPanel = new Panel();
            ButtonPanel = new TableLayoutPanel();
            Lab4Button = new Button();
            Lab1Button = new Button();
            Lab3Button = new Button();
            Lab2Button = new Button();
            CGLabel = new Label();
            label1 = new Label();
            MainTableLayoutPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 3;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            MainTableLayoutPanel.Controls.Add(CGLabel, 1, 0);
            MainTableLayoutPanel.Controls.Add(RightLowerPanel, 2, 2);
            MainTableLayoutPanel.Controls.Add(LeftLowerPanel, 0, 2);
            MainTableLayoutPanel.Controls.Add(RightMiddlePanel, 2, 1);
            MainTableLayoutPanel.Controls.Add(LeftMiddlePanel, 0, 1);
            MainTableLayoutPanel.Controls.Add(LeftTopPanel, 0, 0);
            MainTableLayoutPanel.Controls.Add(RightTopPanel, 2, 0);
            MainTableLayoutPanel.Controls.Add(ButtonPanel, 1, 2);
            MainTableLayoutPanel.Controls.Add(label1, 1, 1);
            MainTableLayoutPanel.Dock = DockStyle.Fill;
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 3;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            MainTableLayoutPanel.Size = new Size(1084, 661);
            MainTableLayoutPanel.TabIndex = 2;
            // 
            // RightLowerPanel
            // 
            RightLowerPanel.Dock = DockStyle.Fill;
            RightLowerPanel.Location = new Point(725, 443);
            RightLowerPanel.Name = "RightLowerPanel";
            RightLowerPanel.Size = new Size(356, 215);
            RightLowerPanel.TabIndex = 12;
            // 
            // LeftLowerPanel
            // 
            LeftLowerPanel.Dock = DockStyle.Fill;
            LeftLowerPanel.Location = new Point(3, 443);
            LeftLowerPanel.Name = "LeftLowerPanel";
            LeftLowerPanel.Size = new Size(355, 215);
            LeftLowerPanel.TabIndex = 11;
            // 
            // RightMiddlePanel
            // 
            RightMiddlePanel.Dock = DockStyle.Fill;
            RightMiddlePanel.Location = new Point(725, 223);
            RightMiddlePanel.Name = "RightMiddlePanel";
            RightMiddlePanel.Size = new Size(356, 214);
            RightMiddlePanel.TabIndex = 10;
            // 
            // LeftMiddlePanel
            // 
            LeftMiddlePanel.Dock = DockStyle.Fill;
            LeftMiddlePanel.Location = new Point(3, 223);
            LeftMiddlePanel.Name = "LeftMiddlePanel";
            LeftMiddlePanel.Size = new Size(355, 214);
            LeftMiddlePanel.TabIndex = 8;
            // 
            // LeftTopPanel
            // 
            LeftTopPanel.Dock = DockStyle.Fill;
            LeftTopPanel.Location = new Point(3, 3);
            LeftTopPanel.Name = "LeftTopPanel";
            LeftTopPanel.Size = new Size(355, 214);
            LeftTopPanel.TabIndex = 4;
            // 
            // RightTopPanel
            // 
            RightTopPanel.Dock = DockStyle.Fill;
            RightTopPanel.Location = new Point(725, 3);
            RightTopPanel.Name = "RightTopPanel";
            RightTopPanel.Size = new Size(356, 214);
            RightTopPanel.TabIndex = 5;
            // 
            // ButtonPanel
            // 
            ButtonPanel.ColumnCount = 1;
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            ButtonPanel.Controls.Add(Lab4Button, 0, 3);
            ButtonPanel.Controls.Add(Lab1Button, 0, 0);
            ButtonPanel.Controls.Add(Lab3Button, 0, 2);
            ButtonPanel.Controls.Add(Lab2Button, 0, 1);
            ButtonPanel.Dock = DockStyle.Fill;
            ButtonPanel.Location = new Point(364, 443);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.RowCount = 4;
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ButtonPanel.Size = new Size(355, 215);
            ButtonPanel.TabIndex = 6;
            // 
            // Lab4Button
            // 
            Lab4Button.Dock = DockStyle.Fill;
            Lab4Button.Enabled = false;
            Lab4Button.Location = new Point(3, 162);
            Lab4Button.Name = "Lab4Button";
            Lab4Button.Size = new Size(349, 50);
            Lab4Button.TabIndex = 7;
            Lab4Button.Text = "Лаба 4";
            Lab4Button.UseVisualStyleBackColor = true;
            // 
            // Lab1Button
            // 
            Lab1Button.Dock = DockStyle.Fill;
            Lab1Button.Location = new Point(3, 3);
            Lab1Button.Name = "Lab1Button";
            Lab1Button.Size = new Size(349, 47);
            Lab1Button.TabIndex = 4;
            Lab1Button.Text = "Лаба 1";
            Lab1Button.UseVisualStyleBackColor = true;
            // 
            // Lab3Button
            // 
            Lab3Button.Dock = DockStyle.Fill;
            Lab3Button.Enabled = false;
            Lab3Button.Location = new Point(3, 109);
            Lab3Button.Name = "Lab3Button";
            Lab3Button.Size = new Size(349, 47);
            Lab3Button.TabIndex = 6;
            Lab3Button.Text = "Лаба 3";
            Lab3Button.UseVisualStyleBackColor = true;
            // 
            // Lab2Button
            // 
            Lab2Button.Dock = DockStyle.Fill;
            Lab2Button.Enabled = false;
            Lab2Button.Location = new Point(3, 56);
            Lab2Button.Name = "Lab2Button";
            Lab2Button.Size = new Size(349, 47);
            Lab2Button.TabIndex = 5;
            Lab2Button.Text = "Лаба 2";
            Lab2Button.UseVisualStyleBackColor = true;
            // 
            // CGLabel
            // 
            CGLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CGLabel.AutoSize = true;
            CGLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            CGLabel.Location = new Point(364, 0);
            CGLabel.Name = "CGLabel";
            CGLabel.Size = new Size(355, 220);
            CGLabel.TabIndex = 0;
            CGLabel.Text = "Компьютерная графика";
            CGLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(364, 220);
            label1.Name = "label1";
            label1.Size = new Size(355, 220);
            label1.TabIndex = 1;
            label1.Text = "Подготовили студенты группы 582-1:\r\nПолушвайко Константин\r\nРязанов Антон\r\nЮрьев  Алексей";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(MainTableLayoutPanel);
            MaximizeBox = false;
            MaximumSize = new Size(1100, 700);
            MinimumSize = new Size(750, 450);
            Name = "MainForm";
            Text = "Computer Graphic";
            MainTableLayoutPanel.ResumeLayout(false);
            MainTableLayoutPanel.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel MainTableLayoutPanel;
        private Panel LeftTopPanel;
        private Panel RightTopPanel;
        private Button Lab4Button;
        private Button Lab1Button;
        private Button Lab3Button;
        private Button Lab2Button;
        private TableLayoutPanel ButtonPanel;
        private Panel RightLowerPanel;
        private Panel LeftLowerPanel;
        private Panel RightMiddlePanel;
        private Panel LeftMiddlePanel;
        private Label CGLabel;
        private Label label1;
    }
}
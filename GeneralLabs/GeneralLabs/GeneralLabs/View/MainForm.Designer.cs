namespace GeneralLabs
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
            Lab2Button = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            Lab4Button = new Button();
            panel1 = new Panel();
            label1 = new Label();
            Lab3Button = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Lab2Button
            // 
            Lab2Button.Dock = DockStyle.Fill;
            Lab2Button.Location = new Point(3, 134);
            Lab2Button.Name = "Lab2Button";
            Lab2Button.Size = new Size(491, 59);
            Lab2Button.TabIndex = 0;
            Lab2Button.Text = "Lab 2";
            Lab2Button.UseVisualStyleBackColor = true;
            Lab2Button.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Lab4Button, 0, 3);
            tableLayoutPanel1.Controls.Add(Lab2Button, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(Lab3Button, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(497, 328);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Lab4Button
            // 
            Lab4Button.Dock = DockStyle.Fill;
            Lab4Button.Location = new Point(3, 264);
            Lab4Button.Name = "Lab4Button";
            Lab4Button.Size = new Size(491, 61);
            Lab4Button.TabIndex = 3;
            Lab4Button.Text = "Lab 4";
            Lab4Button.UseVisualStyleBackColor = true;
            Lab4Button.Click += Lab4Button_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 125);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(491, 125);
            label1.TabIndex = 0;
            label1.Text = "Выберите лабораторную:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lab3Button
            // 
            Lab3Button.Dock = DockStyle.Fill;
            Lab3Button.Location = new Point(3, 199);
            Lab3Button.Name = "Lab3Button";
            Lab3Button.Size = new Size(491, 59);
            Lab3Button.TabIndex = 2;
            Lab3Button.Text = "Lab 3";
            Lab3Button.UseVisualStyleBackColor = true;
            Lab3Button.Click += Lab3Button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 328);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(344, 248);
            Name = "MainForm";
            Text = "MainForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Lab2Button;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Button Lab3Button;
        private Button Lab4Button;
    }
}

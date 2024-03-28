namespace ComputerGraphic.View.Labs.Lab2.Tabs
{
    partial class PolygonColoringAlgorithm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TableLayoutPanel = new TableLayoutPanel();
            PictureBox = new PictureBox();
            ContolPanel = new Panel();
            EdgeCountLabel = new Label();
            NumericUpDown = new NumericUpDown();
            ButtonTableLayoutPanel = new TableLayoutPanel();
            StartButton = new Button();
            CancelButton = new Button();
            ClearButton = new Button();
            AnimationModeСheckBox = new CheckBox();
            TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            ContolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown).BeginInit();
            ButtonTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 2;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            TableLayoutPanel.Controls.Add(PictureBox, 0, 0);
            TableLayoutPanel.Controls.Add(ContolPanel, 1, 0);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 1;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel.Size = new Size(797, 496);
            TableLayoutPanel.TabIndex = 0;
            // 
            // PictureBox
            // 
            PictureBox.Dock = DockStyle.Fill;
            PictureBox.Location = new Point(3, 3);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(472, 490);
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.MouseDown += PictureBox_MouseDown;
            // 
            // ContolPanel
            // 
            ContolPanel.BorderStyle = BorderStyle.FixedSingle;
            ContolPanel.Controls.Add(EdgeCountLabel);
            ContolPanel.Controls.Add(NumericUpDown);
            ContolPanel.Controls.Add(ButtonTableLayoutPanel);
            ContolPanel.Controls.Add(AnimationModeСheckBox);
            ContolPanel.Dock = DockStyle.Fill;
            ContolPanel.Location = new Point(481, 3);
            ContolPanel.Name = "ContolPanel";
            ContolPanel.Size = new Size(313, 490);
            ContolPanel.TabIndex = 1;
            // 
            // EdgeCountLabel
            // 
            EdgeCountLabel.AutoSize = true;
            EdgeCountLabel.Location = new Point(3, 0);
            EdgeCountLabel.Name = "EdgeCountLabel";
            EdgeCountLabel.Size = new Size(117, 15);
            EdgeCountLabel.TabIndex = 4;
            EdgeCountLabel.Text = "Количество сторон:";
            // 
            // NumericUpDown
            // 
            NumericUpDown.Location = new Point(3, 18);
            NumericUpDown.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            NumericUpDown.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            NumericUpDown.Name = "NumericUpDown";
            NumericUpDown.Size = new Size(305, 23);
            NumericUpDown.TabIndex = 3;
            NumericUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            NumericUpDown.ValueChanged += NumericUpDown_ValueChanged;
            // 
            // ButtonTableLayoutPanel
            // 
            ButtonTableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonTableLayoutPanel.ColumnCount = 2;
            ButtonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonTableLayoutPanel.Controls.Add(StartButton, 0, 1);
            ButtonTableLayoutPanel.Controls.Add(CancelButton, 1, 1);
            ButtonTableLayoutPanel.Controls.Add(ClearButton, 0, 0);
            ButtonTableLayoutPanel.Location = new Point(3, 385);
            ButtonTableLayoutPanel.Name = "ButtonTableLayoutPanel";
            ButtonTableLayoutPanel.RowCount = 2;
            ButtonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonTableLayoutPanel.Size = new Size(305, 100);
            ButtonTableLayoutPanel.TabIndex = 2;
            // 
            // StartButton
            // 
            StartButton.Dock = DockStyle.Fill;
            StartButton.Location = new Point(3, 53);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(146, 44);
            StartButton.TabIndex = 5;
            StartButton.Text = "Начать закраску";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.Enabled = false;
            CancelButton.Location = new Point(155, 53);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(147, 44);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Dock = DockStyle.Fill;
            ClearButton.Location = new Point(3, 3);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(146, 44);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // AnimationModeСheckBox
            // 
            AnimationModeСheckBox.AutoSize = true;
            AnimationModeСheckBox.Location = new Point(3, 47);
            AnimationModeСheckBox.Name = "AnimationModeСheckBox";
            AnimationModeСheckBox.Size = new Size(125, 19);
            AnimationModeСheckBox.TabIndex = 0;
            AnimationModeСheckBox.Text = "Режим Анимации";
            AnimationModeСheckBox.UseVisualStyleBackColor = true;
            // 
            // PolygonColoringAlgorithm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel);
            Name = "PolygonColoringAlgorithm";
            Size = new Size(797, 496);
            Load += PolygonColoringAlgorithm_Load;
            Resize += PolygonColoringAlgorithm_Resize;
            TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ContolPanel.ResumeLayout(false);
            ContolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown).EndInit();
            ButtonTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private PictureBox PictureBox;
        private Panel ContolPanel;
        private TableLayoutPanel ButtonTableLayoutPanel;
        private Button CancelButton;
        private CheckBox AnimationModeСheckBox;
        private Button ClearButton;
        private Label EdgeCountLabel;
        private NumericUpDown NumericUpDown;
        private Button StartButton;
    }
}

namespace GeneralLabs.View.Labs
{
    partial class Lab2
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
            MainTableLayoutPanel = new TableLayoutPanel();
            ControlPanel = new Panel();
            BrushSizeLabel = new Label();
            BrushSizeComboBox = new ComboBox();
            ModeGroupBox = new GroupBox();
            AfterTimeRadioButton = new RadioButton();
            InTimeRadioButton = new RadioButton();
            ButtonTableLayoutPanel = new TableLayoutPanel();
            FillColorButton = new Button();
            ExecuteButton = new Button();
            PickColorButton = new Button();
            ClearButton = new Button();
            AlgorithmGroupBox = new GroupBox();
            FillRadioButton = new RadioButton();
            CDARadioButton = new RadioButton();
            PictureBox = new PictureBox();
            BorderColorDialog = new ColorDialog();
            FillColorDialog = new ColorDialog();
            MainTableLayoutPanel.SuspendLayout();
            ControlPanel.SuspendLayout();
            ModeGroupBox.SuspendLayout();
            ButtonTableLayoutPanel.SuspendLayout();
            AlgorithmGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 2;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            MainTableLayoutPanel.Controls.Add(ControlPanel, 1, 0);
            MainTableLayoutPanel.Controls.Add(PictureBox, 0, 0);
            MainTableLayoutPanel.Dock = DockStyle.Fill;
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 1;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainTableLayoutPanel.Size = new Size(871, 441);
            MainTableLayoutPanel.TabIndex = 0;
            // 
            // ControlPanel
            // 
            ControlPanel.BorderStyle = BorderStyle.FixedSingle;
            ControlPanel.Controls.Add(BrushSizeLabel);
            ControlPanel.Controls.Add(BrushSizeComboBox);
            ControlPanel.Controls.Add(ModeGroupBox);
            ControlPanel.Controls.Add(ButtonTableLayoutPanel);
            ControlPanel.Controls.Add(AlgorithmGroupBox);
            ControlPanel.Dock = DockStyle.Fill;
            ControlPanel.Location = new Point(525, 3);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(343, 435);
            ControlPanel.TabIndex = 0;
            // 
            // BrushSizeLabel
            // 
            BrushSizeLabel.AutoSize = true;
            BrushSizeLabel.Location = new Point(3, 185);
            BrushSizeLabel.Name = "BrushSizeLabel";
            BrushSizeLabel.Size = new Size(84, 15);
            BrushSizeLabel.TabIndex = 4;
            BrushSizeLabel.Text = "Размер кисти:";
            // 
            // BrushSizeComboBox
            // 
            BrushSizeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BrushSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BrushSizeComboBox.FormattingEnabled = true;
            BrushSizeComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            BrushSizeComboBox.Location = new Point(93, 182);
            BrushSizeComboBox.Name = "BrushSizeComboBox";
            BrushSizeComboBox.Size = new Size(245, 23);
            BrushSizeComboBox.TabIndex = 3;
            BrushSizeComboBox.SelectedIndexChanged += BrushSizeComboBox_SelectedIndexChanged;
            // 
            // ModeGroupBox
            // 
            ModeGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ModeGroupBox.Controls.Add(AfterTimeRadioButton);
            ModeGroupBox.Controls.Add(InTimeRadioButton);
            ModeGroupBox.Location = new Point(3, 98);
            ModeGroupBox.Name = "ModeGroupBox";
            ModeGroupBox.Size = new Size(335, 84);
            ModeGroupBox.TabIndex = 2;
            ModeGroupBox.TabStop = false;
            ModeGroupBox.Text = "Выберите режим";
            // 
            // AfterTimeRadioButton
            // 
            AfterTimeRadioButton.AutoSize = true;
            AfterTimeRadioButton.Checked = true;
            AfterTimeRadioButton.Location = new Point(6, 47);
            AfterTimeRadioButton.Name = "AfterTimeRadioButton";
            AfterTimeRadioButton.Size = new Size(109, 19);
            AfterTimeRadioButton.TabIndex = 1;
            AfterTimeRadioButton.TabStop = true;
            AfterTimeRadioButton.Text = "После нажатия";
            AfterTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // InTimeRadioButton
            // 
            InTimeRadioButton.AutoSize = true;
            InTimeRadioButton.Location = new Point(6, 22);
            InTimeRadioButton.Name = "InTimeRadioButton";
            InTimeRadioButton.Size = new Size(94, 19);
            InTimeRadioButton.TabIndex = 0;
            InTimeRadioButton.TabStop = true;
            InTimeRadioButton.Text = "По нажатию";
            InTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ButtonTableLayoutPanel
            // 
            ButtonTableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonTableLayoutPanel.ColumnCount = 2;
            ButtonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonTableLayoutPanel.Controls.Add(FillColorButton, 1, 0);
            ButtonTableLayoutPanel.Controls.Add(ExecuteButton, 0, 1);
            ButtonTableLayoutPanel.Controls.Add(PickColorButton, 0, 0);
            ButtonTableLayoutPanel.Controls.Add(ClearButton, 1, 1);
            ButtonTableLayoutPanel.Location = new Point(9, 295);
            ButtonTableLayoutPanel.Name = "ButtonTableLayoutPanel";
            ButtonTableLayoutPanel.RowCount = 2;
            ButtonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ButtonTableLayoutPanel.Size = new Size(324, 130);
            ButtonTableLayoutPanel.TabIndex = 1;
            // 
            // FillColorButton
            // 
            FillColorButton.Location = new Point(165, 3);
            FillColorButton.Name = "FillColorButton";
            FillColorButton.Size = new Size(156, 59);
            FillColorButton.TabIndex = 5;
            FillColorButton.Text = "Цвет заливки";
            FillColorButton.UseVisualStyleBackColor = true;
            FillColorButton.Click += FillColorButton_Click;
            // 
            // ExecuteButton
            // 
            ExecuteButton.Dock = DockStyle.Fill;
            ExecuteButton.Location = new Point(3, 68);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(156, 59);
            ExecuteButton.TabIndex = 3;
            ExecuteButton.Text = "Выполнить";
            ExecuteButton.UseVisualStyleBackColor = true;
            ExecuteButton.Click += ExecuteButton_Click;
            // 
            // PickColorButton
            // 
            PickColorButton.Location = new Point(3, 3);
            PickColorButton.Name = "PickColorButton";
            PickColorButton.Size = new Size(156, 59);
            PickColorButton.TabIndex = 2;
            PickColorButton.Text = "Цвет линии";
            PickColorButton.UseVisualStyleBackColor = true;
            PickColorButton.Click += PickColorButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Dock = DockStyle.Fill;
            ClearButton.Location = new Point(165, 68);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(156, 59);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // AlgorithmGroupBox
            // 
            AlgorithmGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AlgorithmGroupBox.Controls.Add(FillRadioButton);
            AlgorithmGroupBox.Controls.Add(CDARadioButton);
            AlgorithmGroupBox.Location = new Point(3, 8);
            AlgorithmGroupBox.Name = "AlgorithmGroupBox";
            AlgorithmGroupBox.Size = new Size(335, 84);
            AlgorithmGroupBox.TabIndex = 0;
            AlgorithmGroupBox.TabStop = false;
            AlgorithmGroupBox.Text = "Выберите алгоритм";
            // 
            // FillRadioButton
            // 
            FillRadioButton.AutoSize = true;
            FillRadioButton.Location = new Point(6, 47);
            FillRadioButton.Name = "FillRadioButton";
            FillRadioButton.Size = new Size(70, 19);
            FillRadioButton.TabIndex = 1;
            FillRadioButton.TabStop = true;
            FillRadioButton.Text = "Заливка";
            FillRadioButton.UseVisualStyleBackColor = true;
            // 
            // CDARadioButton
            // 
            CDARadioButton.AutoSize = true;
            CDARadioButton.Checked = true;
            CDARadioButton.Location = new Point(6, 22);
            CDARadioButton.Name = "CDARadioButton";
            CDARadioButton.Size = new Size(108, 19);
            CDARadioButton.TabIndex = 0;
            CDARadioButton.TabStop = true;
            CDARadioButton.Text = "Обычный ЦДА";
            CDARadioButton.UseVisualStyleBackColor = true;
            // 
            // PictureBox
            // 
            PictureBox.Dock = DockStyle.Fill;
            PictureBox.Location = new Point(3, 3);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(516, 435);
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            PictureBox.MouseDown += PictureBox_MouseDown;
            PictureBox.MouseMove += PictureBox_MouseMove;
            PictureBox.MouseUp += PictureBox_MouseUp;
            // 
            // Lab2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 441);
            Controls.Add(MainTableLayoutPanel);
            MinimumSize = new Size(754, 395);
            Name = "Lab2";
            Text = "Растровые алгоритмы";
            Resize += Lab2_Resize;
            MainTableLayoutPanel.ResumeLayout(false);
            ControlPanel.ResumeLayout(false);
            ControlPanel.PerformLayout();
            ModeGroupBox.ResumeLayout(false);
            ModeGroupBox.PerformLayout();
            ButtonTableLayoutPanel.ResumeLayout(false);
            AlgorithmGroupBox.ResumeLayout(false);
            AlgorithmGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainTableLayoutPanel;
        private Panel ControlPanel;
        private PictureBox PictureBox;
        private GroupBox AlgorithmGroupBox;
        private RadioButton FillRadioButton;
        private RadioButton CDARadioButton;
        private TableLayoutPanel ButtonTableLayoutPanel;
        private Button PickColorButton;
        private Button ExecuteButton;
        private Button ClearButton;
        private GroupBox ModeGroupBox;
        private RadioButton AfterTimeRadioButton;
        private RadioButton InTimeRadioButton;
        private ColorDialog BorderColorDialog;
        private ComboBox BrushSizeComboBox;
        private Label BrushSizeLabel;
        private Button FillColorButton;
        private ColorDialog FillColorDialog;
    }
}
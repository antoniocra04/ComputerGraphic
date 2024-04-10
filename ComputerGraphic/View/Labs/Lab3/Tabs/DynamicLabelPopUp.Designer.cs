namespace ComputerGraphic.View.Labs.Lab3.Tabs
{
    partial class DynamicLabelPopUp
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
            TableLayoutPanel = new TableLayoutPanel();
            LeftPanel = new Panel();
            Label = new Label();
            TextBox = new TextBox();
            RightPanel = new Panel();
            ButtonsTableLayoutPanel = new TableLayoutPanel();
            OkButton = new Button();
            CancelButton = new Button();
            TrackBar = new TrackBar();
            SpeedLabel = new Label();
            GroupBox = new GroupBox();
            ColorButton = new Button();
            OneColorRadioButton = new RadioButton();
            RandomRadioButton = new RadioButton();
            NumericUpDown = new NumericUpDown();
            FontSizeLabel = new Label();
            ColorDialog = new ColorDialog();
            TableLayoutPanel.SuspendLayout();
            LeftPanel.SuspendLayout();
            RightPanel.SuspendLayout();
            ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrackBar).BeginInit();
            GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 2;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            TableLayoutPanel.Controls.Add(LeftPanel, 0, 0);
            TableLayoutPanel.Controls.Add(RightPanel, 1, 0);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 1;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel.Size = new Size(578, 235);
            TableLayoutPanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(Label);
            LeftPanel.Controls.Add(TextBox);
            LeftPanel.Dock = DockStyle.Fill;
            LeftPanel.Location = new Point(3, 3);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(340, 229);
            LeftPanel.TabIndex = 0;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Label.Location = new Point(9, 6);
            Label.Name = "Label";
            Label.Size = new Size(292, 28);
            Label.TabIndex = 0;
            Label.Text = "Введите/отредактируйте текст:";
            Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBox
            // 
            TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBox.Location = new Point(3, 37);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(334, 189);
            TextBox.TabIndex = 1;
            TextBox.TextChanged += TextBox_TextChanged;
            // 
            // RightPanel
            // 
            RightPanel.Controls.Add(ButtonsTableLayoutPanel);
            RightPanel.Controls.Add(TrackBar);
            RightPanel.Controls.Add(SpeedLabel);
            RightPanel.Controls.Add(GroupBox);
            RightPanel.Controls.Add(NumericUpDown);
            RightPanel.Controls.Add(FontSizeLabel);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(349, 3);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(226, 229);
            RightPanel.TabIndex = 1;
            // 
            // ButtonsTableLayoutPanel
            // 
            ButtonsTableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonsTableLayoutPanel.ColumnCount = 2;
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonsTableLayoutPanel.Controls.Add(OkButton, 0, 0);
            ButtonsTableLayoutPanel.Controls.Add(CancelButton, 1, 0);
            ButtonsTableLayoutPanel.Location = new Point(3, 185);
            ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            ButtonsTableLayoutPanel.RowCount = 1;
            ButtonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonsTableLayoutPanel.Size = new Size(220, 41);
            ButtonsTableLayoutPanel.TabIndex = 9;
            // 
            // OkButton
            // 
            OkButton.Dock = DockStyle.Fill;
            OkButton.Location = new Point(3, 3);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(104, 35);
            OkButton.TabIndex = 7;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.Location = new Point(113, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(104, 35);
            CancelButton.TabIndex = 8;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // TrackBar
            // 
            TrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TrackBar.Location = new Point(130, 33);
            TrackBar.Maximum = 5;
            TrackBar.Minimum = 1;
            TrackBar.Name = "TrackBar";
            TrackBar.Size = new Size(93, 45);
            TrackBar.TabIndex = 6;
            TrackBar.Value = 1;
            TrackBar.Scroll += TrackBar_Scroll;
            // 
            // SpeedLabel
            // 
            SpeedLabel.AutoSize = true;
            SpeedLabel.Location = new Point(3, 40);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new Size(121, 15);
            SpeedLabel.TabIndex = 5;
            SpeedLabel.Text = "Скорость вращения:";
            // 
            // GroupBox
            // 
            GroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBox.Controls.Add(ColorButton);
            GroupBox.Controls.Add(OneColorRadioButton);
            GroupBox.Controls.Add(RandomRadioButton);
            GroupBox.Location = new Point(3, 70);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(220, 109);
            GroupBox.TabIndex = 4;
            GroupBox.TabStop = false;
            GroupBox.Text = "Выбор цвета:";
            // 
            // ColorButton
            // 
            ColorButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ColorButton.Location = new Point(3, 72);
            ColorButton.Name = "ColorButton";
            ColorButton.Size = new Size(214, 29);
            ColorButton.TabIndex = 2;
            ColorButton.Text = "Выбрать цвет...";
            ColorButton.UseVisualStyleBackColor = true;
            ColorButton.Click += ColorButton_Click;
            // 
            // OneColorRadioButton
            // 
            OneColorRadioButton.AutoSize = true;
            OneColorRadioButton.Location = new Point(6, 47);
            OneColorRadioButton.Name = "OneColorRadioButton";
            OneColorRadioButton.Size = new Size(163, 19);
            OneColorRadioButton.TabIndex = 1;
            OneColorRadioButton.TabStop = true;
            OneColorRadioButton.Text = "Монотонный цвет текста";
            OneColorRadioButton.UseVisualStyleBackColor = true;
            OneColorRadioButton.CheckedChanged += OneColorRadioButton_CheckedChanged;
            // 
            // RandomRadioButton
            // 
            RandomRadioButton.AutoSize = true;
            RandomRadioButton.Location = new Point(6, 22);
            RandomRadioButton.Name = "RandomRadioButton";
            RandomRadioButton.Size = new Size(219, 19);
            RandomRadioButton.TabIndex = 0;
            RandomRadioButton.Text = "Случайный цвет для каждой буквы";
            RandomRadioButton.UseVisualStyleBackColor = true;
            // 
            // NumericUpDown
            // 
            NumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NumericUpDown.Location = new Point(116, 4);
            NumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericUpDown.Name = "NumericUpDown";
            NumericUpDown.Size = new Size(101, 23);
            NumericUpDown.TabIndex = 3;
            NumericUpDown.Value = new decimal(new int[] { 12, 0, 0, 0 });
            NumericUpDown.ValueChanged += NumericUpDown_ValueChanged;
            // 
            // FontSizeLabel
            // 
            FontSizeLabel.AutoSize = true;
            FontSizeLabel.Location = new Point(3, 6);
            FontSizeLabel.Name = "FontSizeLabel";
            FontSizeLabel.Size = new Size(98, 15);
            FontSizeLabel.TabIndex = 0;
            FontSizeLabel.Text = "Размер шрифта:";
            // 
            // DynamicLabelPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 235);
            Controls.Add(TableLayoutPanel);
            MinimumSize = new Size(594, 274);
            Name = "DynamicLabelPopUp";
            Text = "DynamicLabelPopUp";
            Load += DynamicLabelPopUp_Load;
            TableLayoutPanel.ResumeLayout(false);
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TrackBar).EndInit();
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private Label Label;
        private TextBox TextBox;
        private Panel LeftPanel;
        private Panel RightPanel;
        private Label FontSizeLabel;
        private GroupBox GroupBox;
        private RadioButton OneColorRadioButton;
        private RadioButton RandomRadioButton;
        private NumericUpDown NumericUpDown;
        private Button ColorButton;
        private TrackBar TrackBar;
        private Label SpeedLabel;
        private TableLayoutPanel ButtonsTableLayoutPanel;
        private Button OkButton;
        private Button CancelButton;
        private ColorDialog ColorDialog;
    }
}
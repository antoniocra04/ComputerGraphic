namespace GeneralLabs.View.Labs
{
    partial class Lab3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab3));
            TableLayoutPanel = new TableLayoutPanel();
            PictureBox = new PictureBox();
            Panel = new Panel();
            label2 = new Label();
            trackBar1 = new TrackBar();
            tableLayoutPanel1 = new TableLayoutPanel();
            button9 = new Button();
            button8 = new Button();
            button6 = new Button();
            button5 = new Button();
            button7 = new Button();
            button4 = new Button();
            button10 = new Button();
            button11 = new Button();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            ButtonTableLayoutPanel = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ButtonTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 2;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            TableLayoutPanel.Controls.Add(PictureBox, 0, 0);
            TableLayoutPanel.Controls.Add(Panel, 1, 0);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 1;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel.Size = new Size(794, 501);
            TableLayoutPanel.TabIndex = 0;
            // 
            // PictureBox
            // 
            PictureBox.Dock = DockStyle.Fill;
            PictureBox.Location = new Point(3, 3);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(549, 495);
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Panel
            // 
            Panel.BorderStyle = BorderStyle.FixedSingle;
            Panel.Controls.Add(label2);
            Panel.Controls.Add(trackBar1);
            Panel.Controls.Add(tableLayoutPanel1);
            Panel.Controls.Add(ButtonTableLayoutPanel);
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(558, 3);
            Panel.Name = "Panel";
            Panel.Size = new Size(233, 495);
            Panel.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 399);
            label2.Name = "label2";
            label2.Size = new Size(225, 43);
            label2.TabIndex = 10;
            label2.Text = "Интервал анимации";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackBar1.Location = new Point(3, 445);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(225, 45);
            trackBar1.TabIndex = 9;
            trackBar1.Value = 50;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(button9, 2, 0);
            tableLayoutPanel1.Controls.Add(button8, 0, 0);
            tableLayoutPanel1.Controls.Add(button6, 1, 2);
            tableLayoutPanel1.Controls.Add(button5, 0, 1);
            tableLayoutPanel1.Controls.Add(button7, 1, 0);
            tableLayoutPanel1.Controls.Add(button4, 2, 1);
            tableLayoutPanel1.Controls.Add(button10, 0, 2);
            tableLayoutPanel1.Controls.Add(button11, 2, 2);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Location = new Point(3, 201);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(225, 195);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(152, 3);
            button9.Name = "button9";
            button9.Size = new Size(70, 58);
            button9.TabIndex = 10;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            button9.MouseDown += button9_MouseDown;
            button9.MouseUp += button9_MouseUp;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(3, 3);
            button8.Name = "button8";
            button8.Size = new Size(68, 58);
            button8.TabIndex = 9;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            button8.MouseDown += button8_MouseDown;
            button8.MouseUp += button8_MouseUp;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.Location = new Point(77, 131);
            button6.Name = "button6";
            button6.Size = new Size(69, 61);
            button6.TabIndex = 5;
            button6.Text = "↓";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            button6.MouseDown += button6_MouseDown;
            button6.MouseUp += button6_MouseUp;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(3, 67);
            button5.Name = "button5";
            button5.Size = new Size(68, 58);
            button5.TabIndex = 4;
            button5.Text = "←";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            button5.MouseDown += button5_MouseDown;
            button5.MouseUp += button5_MouseUp;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(77, 3);
            button7.Name = "button7";
            button7.Size = new Size(69, 58);
            button7.TabIndex = 6;
            button7.Text = "↑";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            button7.MouseDown += button7_MouseDown;
            button7.MouseUp += button7_MouseUp;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(152, 67);
            button4.Name = "button4";
            button4.Size = new Size(70, 58);
            button4.TabIndex = 3;
            button4.Text = "→";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            button4.MouseDown += button4_MouseDown;
            button4.MouseUp += button4_MouseUp;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(3, 131);
            button10.Name = "button10";
            button10.Size = new Size(68, 61);
            button10.TabIndex = 11;
            button10.Text = "OX";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(152, 131);
            button11.Name = "button11";
            button11.Size = new Size(70, 61);
            button11.TabIndex = 12;
            button11.Text = "OY";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(77, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(69, 58);
            panel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button15, 1, 1);
            tableLayoutPanel2.Controls.Add(button14, 0, 1);
            tableLayoutPanel2.Controls.Add(button13, 1, 0);
            tableLayoutPanel2.Controls.Add(button12, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(69, 58);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button15
            // 
            button15.Dock = DockStyle.Fill;
            button15.Location = new Point(37, 32);
            button15.Name = "button15";
            button15.Size = new Size(29, 23);
            button15.TabIndex = 3;
            button15.Text = "y";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button14
            // 
            button14.Dock = DockStyle.Fill;
            button14.Location = new Point(3, 32);
            button14.Name = "button14";
            button14.Size = new Size(28, 23);
            button14.TabIndex = 2;
            button14.Text = "x";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.Dock = DockStyle.Fill;
            button13.Location = new Point(37, 3);
            button13.Name = "button13";
            button13.Size = new Size(29, 23);
            button13.TabIndex = 1;
            button13.Text = "Y";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(3, 3);
            button12.Name = "button12";
            button12.Size = new Size(28, 23);
            button12.TabIndex = 0;
            button12.Text = "X";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // ButtonTableLayoutPanel
            // 
            ButtonTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonTableLayoutPanel.ColumnCount = 1;
            ButtonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ButtonTableLayoutPanel.Controls.Add(button1, 0, 0);
            ButtonTableLayoutPanel.Controls.Add(button2, 0, 1);
            ButtonTableLayoutPanel.Controls.Add(button3, 0, 2);
            ButtonTableLayoutPanel.Controls.Add(label1, 0, 3);
            ButtonTableLayoutPanel.Location = new Point(3, 3);
            ButtonTableLayoutPanel.Name = "ButtonTableLayoutPanel";
            ButtonTableLayoutPanel.RowCount = 4;
            ButtonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            ButtonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            ButtonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            ButtonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            ButtonTableLayoutPanel.Size = new Size(245, 192);
            ButtonTableLayoutPanel.TabIndex = 7;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(239, 42);
            button1.TabIndex = 0;
            button1.Text = "Нарисовать Оси";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(3, 51);
            button2.Name = "button2";
            button2.Size = new Size(239, 42);
            button2.TabIndex = 1;
            button2.Text = "Нарисовать Фигуру";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(3, 99);
            button3.Name = "button3";
            button3.Size = new Size(239, 42);
            button3.TabIndex = 2;
            button3.Text = "Очистить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 144);
            label1.Name = "label1";
            label1.Size = new Size(239, 48);
            label1.TabIndex = 7;
            label1.Text = "Контроль";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Lab3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 501);
            Controls.Add(TableLayoutPanel);
            MinimumSize = new Size(810, 540);
            Name = "Lab3";
            Text = "Lab3";
            Load += Lab3_Load;
            Resize += Lab3_Resize;
            TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ButtonTableLayoutPanel.ResumeLayout(false);
            ButtonTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private PictureBox PictureBox;
        private Panel Panel;
        private TableLayoutPanel ButtonTableLayoutPanel;
        private Button button1;
        private Button button7;
        private Button button2;
        private Button button6;
        private Button button3;
        private Button button5;
        private Button button4;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button8;
        private Button button9;
        private Label label2;
        private TrackBar trackBar1;
        private Button button11;
        private Button button10;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
    }
}
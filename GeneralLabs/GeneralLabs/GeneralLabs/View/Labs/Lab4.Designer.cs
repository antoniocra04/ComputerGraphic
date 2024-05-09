namespace GeneralLabs.View.Labs
{
    partial class Lab4
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
            PictureBox = new PictureBox();
            Timer = new System.Windows.Forms.Timer(components);
            TableLayoutPanel = new TableLayoutPanel();
            TransformGroupBox = new GroupBox();
            DisplayGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            OZButton = new Button();
            OYButton = new Button();
            OXButton = new Button();
            ScaleGroupBox = new GroupBox();
            decreaseSizeZ = new Button();
            decreaseSizeY = new Button();
            decreaseSizeX = new Button();
            increaseSizeZ = new Button();
            increaseSizeY = new Button();
            increaseSizeX = new Button();
            textBox3 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            ZScaleTextBox = new TextBox();
            YScaleTextBox = new TextBox();
            XScaleTextBox = new TextBox();
            RotationGroupBox = new GroupBox();
            decreaseRotateZ = new Button();
            decreaseRotateY = new Button();
            decreaseRotateX = new Button();
            increaseRotateZ = new Button();
            increaseRotateY = new Button();
            increaseRotateX = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ZRotationTextBox = new TextBox();
            YRotationTextBox = new TextBox();
            XRotationTextBox = new TextBox();
            LocationGroupBox = new GroupBox();
            decreasePositionZ = new Button();
            decreasePositionY = new Button();
            decreasePositionX = new Button();
            increasePositionZ = new Button();
            increasePositionY = new Button();
            increasePositionX = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ZLocationTextBox = new TextBox();
            YLocationTextBox = new TextBox();
            XLocationTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            TableLayoutPanel.SuspendLayout();
            TransformGroupBox.SuspendLayout();
            DisplayGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ScaleGroupBox.SuspendLayout();
            RotationGroupBox.SuspendLayout();
            LocationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // PictureBox
            // 
            PictureBox.Dock = DockStyle.Fill;
            PictureBox.Location = new Point(3, 3);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(554, 444);
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 2;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            TableLayoutPanel.Controls.Add(PictureBox, 0, 0);
            TableLayoutPanel.Controls.Add(TransformGroupBox, 1, 0);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 1;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel.Size = new Size(800, 450);
            TableLayoutPanel.TabIndex = 1;
            // 
            // TransformGroupBox
            // 
            TransformGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TransformGroupBox.Controls.Add(DisplayGroupBox);
            TransformGroupBox.Controls.Add(ScaleGroupBox);
            TransformGroupBox.Controls.Add(RotationGroupBox);
            TransformGroupBox.Controls.Add(LocationGroupBox);
            TransformGroupBox.Location = new Point(563, 3);
            TransformGroupBox.Name = "TransformGroupBox";
            TransformGroupBox.Size = new Size(234, 444);
            TransformGroupBox.TabIndex = 1;
            TransformGroupBox.TabStop = false;
            TransformGroupBox.Text = "Преобразовать";
            // 
            // DisplayGroupBox
            // 
            DisplayGroupBox.Controls.Add(tableLayoutPanel1);
            DisplayGroupBox.Location = new Point(6, 367);
            DisplayGroupBox.Name = "DisplayGroupBox";
            DisplayGroupBox.Size = new Size(222, 71);
            DisplayGroupBox.TabIndex = 3;
            DisplayGroupBox.TabStop = false;
            DisplayGroupBox.Text = "Отображение";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(OZButton, 2, 0);
            tableLayoutPanel1.Controls.Add(OYButton, 1, 0);
            tableLayoutPanel1.Controls.Add(OXButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(216, 49);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // OZButton
            // 
            OZButton.Dock = DockStyle.Fill;
            OZButton.Location = new Point(145, 3);
            OZButton.Name = "OZButton";
            OZButton.Size = new Size(68, 43);
            OZButton.TabIndex = 2;
            OZButton.Text = "XOZ";
            OZButton.UseVisualStyleBackColor = true;
            OZButton.Click += OZButton_Click;
            // 
            // OYButton
            // 
            OYButton.Dock = DockStyle.Fill;
            OYButton.Location = new Point(74, 3);
            OYButton.Name = "OYButton";
            OYButton.Size = new Size(65, 43);
            OYButton.TabIndex = 1;
            OYButton.Text = "YOZ";
            OYButton.UseVisualStyleBackColor = true;
            OYButton.Click += OYButton_Click;
            // 
            // OXButton
            // 
            OXButton.Dock = DockStyle.Fill;
            OXButton.Location = new Point(3, 3);
            OXButton.Name = "OXButton";
            OXButton.Size = new Size(65, 43);
            OXButton.TabIndex = 0;
            OXButton.Text = "XOY";
            OXButton.UseVisualStyleBackColor = true;
            OXButton.Click += OXButton_Click;
            // 
            // ScaleGroupBox
            // 
            ScaleGroupBox.Controls.Add(decreaseSizeZ);
            ScaleGroupBox.Controls.Add(decreaseSizeY);
            ScaleGroupBox.Controls.Add(decreaseSizeX);
            ScaleGroupBox.Controls.Add(increaseSizeZ);
            ScaleGroupBox.Controls.Add(increaseSizeY);
            ScaleGroupBox.Controls.Add(increaseSizeX);
            ScaleGroupBox.Controls.Add(textBox3);
            ScaleGroupBox.Controls.Add(label9);
            ScaleGroupBox.Controls.Add(label8);
            ScaleGroupBox.Controls.Add(label7);
            ScaleGroupBox.Controls.Add(ZScaleTextBox);
            ScaleGroupBox.Controls.Add(YScaleTextBox);
            ScaleGroupBox.Controls.Add(XScaleTextBox);
            ScaleGroupBox.Location = new Point(6, 252);
            ScaleGroupBox.Name = "ScaleGroupBox";
            ScaleGroupBox.Size = new Size(222, 109);
            ScaleGroupBox.TabIndex = 2;
            ScaleGroupBox.TabStop = false;
            ScaleGroupBox.Text = "Масштаб";
            // 
            // decreaseSizeZ
            // 
            decreaseSizeZ.Location = new Point(80, 75);
            decreaseSizeZ.Name = "decreaseSizeZ";
            decreaseSizeZ.Size = new Size(28, 23);
            decreaseSizeZ.TabIndex = 21;
            decreaseSizeZ.Text = "<";
            decreaseSizeZ.UseVisualStyleBackColor = true;
            decreaseSizeZ.Click += decreaseSizeZ_Click;
            // 
            // decreaseSizeY
            // 
            decreaseSizeY.Location = new Point(80, 51);
            decreaseSizeY.Name = "decreaseSizeY";
            decreaseSizeY.Size = new Size(28, 23);
            decreaseSizeY.TabIndex = 20;
            decreaseSizeY.Text = "<";
            decreaseSizeY.UseVisualStyleBackColor = true;
            decreaseSizeY.Click += decreaseSizeY_Click;
            // 
            // decreaseSizeX
            // 
            decreaseSizeX.Location = new Point(80, 26);
            decreaseSizeX.Name = "decreaseSizeX";
            decreaseSizeX.Size = new Size(28, 23);
            decreaseSizeX.TabIndex = 19;
            decreaseSizeX.Text = "<";
            decreaseSizeX.UseVisualStyleBackColor = true;
            decreaseSizeX.Click += decreaseSizeX_Click;
            // 
            // increaseSizeZ
            // 
            increaseSizeZ.Location = new Point(114, 75);
            increaseSizeZ.Name = "increaseSizeZ";
            increaseSizeZ.Size = new Size(28, 23);
            increaseSizeZ.TabIndex = 18;
            increaseSizeZ.Text = ">";
            increaseSizeZ.UseVisualStyleBackColor = true;
            increaseSizeZ.Click += increaseSizeZ_Click;
            // 
            // increaseSizeY
            // 
            increaseSizeY.Location = new Point(114, 51);
            increaseSizeY.Name = "increaseSizeY";
            increaseSizeY.Size = new Size(28, 23);
            increaseSizeY.TabIndex = 17;
            increaseSizeY.Text = ">";
            increaseSizeY.UseVisualStyleBackColor = true;
            increaseSizeY.Click += increaseSizeY_Click;
            // 
            // increaseSizeX
            // 
            increaseSizeX.Location = new Point(114, 26);
            increaseSizeX.Name = "increaseSizeX";
            increaseSizeX.Size = new Size(28, 23);
            increaseSizeX.TabIndex = 16;
            increaseSizeX.Text = ">";
            increaseSizeX.UseVisualStyleBackColor = true;
            increaseSizeX.Click += increaseSizeX_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(75, -3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(67, 23);
            textBox3.TabIndex = 15;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 83);
            label9.Name = "label9";
            label9.Size = new Size(14, 15);
            label9.TabIndex = 11;
            label9.Text = "Z";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 54);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 10;
            label8.Text = "Y";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 25);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 9;
            label7.Text = "X";
            // 
            // ZScaleTextBox
            // 
            ZScaleTextBox.Location = new Point(148, 80);
            ZScaleTextBox.Name = "ZScaleTextBox";
            ZScaleTextBox.Size = new Size(68, 23);
            ZScaleTextBox.TabIndex = 8;
            ZScaleTextBox.TextChanged += ZScaleTextBox_TextChanged;
            // 
            // YScaleTextBox
            // 
            YScaleTextBox.Location = new Point(148, 51);
            YScaleTextBox.Name = "YScaleTextBox";
            YScaleTextBox.Size = new Size(68, 23);
            YScaleTextBox.TabIndex = 7;
            YScaleTextBox.TextChanged += YScaleTextBox_TextChanged;
            // 
            // XScaleTextBox
            // 
            XScaleTextBox.Location = new Point(148, 22);
            XScaleTextBox.Name = "XScaleTextBox";
            XScaleTextBox.Size = new Size(68, 23);
            XScaleTextBox.TabIndex = 6;
            XScaleTextBox.TextChanged += XScaleTextBox_TextChanged;
            // 
            // RotationGroupBox
            // 
            RotationGroupBox.Controls.Add(decreaseRotateZ);
            RotationGroupBox.Controls.Add(decreaseRotateY);
            RotationGroupBox.Controls.Add(decreaseRotateX);
            RotationGroupBox.Controls.Add(increaseRotateZ);
            RotationGroupBox.Controls.Add(increaseRotateY);
            RotationGroupBox.Controls.Add(increaseRotateX);
            RotationGroupBox.Controls.Add(textBox1);
            RotationGroupBox.Controls.Add(label6);
            RotationGroupBox.Controls.Add(label5);
            RotationGroupBox.Controls.Add(label4);
            RotationGroupBox.Controls.Add(ZRotationTextBox);
            RotationGroupBox.Controls.Add(YRotationTextBox);
            RotationGroupBox.Controls.Add(XRotationTextBox);
            RotationGroupBox.Location = new Point(6, 137);
            RotationGroupBox.Name = "RotationGroupBox";
            RotationGroupBox.Size = new Size(222, 109);
            RotationGroupBox.TabIndex = 1;
            RotationGroupBox.TabStop = false;
            RotationGroupBox.Text = "Поворот";
            // 
            // decreaseRotateZ
            // 
            decreaseRotateZ.Location = new Point(80, 75);
            decreaseRotateZ.Name = "decreaseRotateZ";
            decreaseRotateZ.Size = new Size(28, 23);
            decreaseRotateZ.TabIndex = 27;
            decreaseRotateZ.Text = "<";
            decreaseRotateZ.UseVisualStyleBackColor = true;
            decreaseRotateZ.Click += decreaseRotateZ_Click;
            // 
            // decreaseRotateY
            // 
            decreaseRotateY.Location = new Point(80, 51);
            decreaseRotateY.Name = "decreaseRotateY";
            decreaseRotateY.Size = new Size(28, 23);
            decreaseRotateY.TabIndex = 26;
            decreaseRotateY.Text = "<";
            decreaseRotateY.UseVisualStyleBackColor = true;
            decreaseRotateY.Click += decreaseRotateY_Click;
            // 
            // decreaseRotateX
            // 
            decreaseRotateX.Location = new Point(80, 26);
            decreaseRotateX.Name = "decreaseRotateX";
            decreaseRotateX.Size = new Size(28, 23);
            decreaseRotateX.TabIndex = 25;
            decreaseRotateX.Text = "<";
            decreaseRotateX.UseVisualStyleBackColor = true;
            decreaseRotateX.Click += decreaseRotateX_Click;
            // 
            // increaseRotateZ
            // 
            increaseRotateZ.Location = new Point(114, 75);
            increaseRotateZ.Name = "increaseRotateZ";
            increaseRotateZ.Size = new Size(28, 23);
            increaseRotateZ.TabIndex = 24;
            increaseRotateZ.Text = ">";
            increaseRotateZ.UseVisualStyleBackColor = true;
            increaseRotateZ.Click += increaseRotateZ_Click;
            // 
            // increaseRotateY
            // 
            increaseRotateY.Location = new Point(114, 51);
            increaseRotateY.Name = "increaseRotateY";
            increaseRotateY.Size = new Size(28, 23);
            increaseRotateY.TabIndex = 23;
            increaseRotateY.Text = ">";
            increaseRotateY.UseVisualStyleBackColor = true;
            increaseRotateY.Click += increaseRotateY_Click;
            // 
            // increaseRotateX
            // 
            increaseRotateX.Location = new Point(114, 26);
            increaseRotateX.Name = "increaseRotateX";
            increaseRotateX.Size = new Size(28, 23);
            increaseRotateX.TabIndex = 22;
            increaseRotateX.Text = ">";
            increaseRotateX.UseVisualStyleBackColor = true;
            increaseRotateX.Click += increaseRotateX_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, -5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(67, 23);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 83);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 8;
            label6.Text = "Z";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 54);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 7;
            label5.Text = "Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 25);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 6;
            label4.Text = "X";
            // 
            // ZRotationTextBox
            // 
            ZRotationTextBox.Location = new Point(148, 80);
            ZRotationTextBox.Name = "ZRotationTextBox";
            ZRotationTextBox.Size = new Size(68, 23);
            ZRotationTextBox.TabIndex = 5;
            ZRotationTextBox.TextChanged += ZRotationTextBox_TextChanged;
            // 
            // YRotationTextBox
            // 
            YRotationTextBox.Location = new Point(148, 51);
            YRotationTextBox.Name = "YRotationTextBox";
            YRotationTextBox.Size = new Size(68, 23);
            YRotationTextBox.TabIndex = 4;
            YRotationTextBox.TextChanged += YRotationTextBox_TextChanged;
            // 
            // XRotationTextBox
            // 
            XRotationTextBox.Location = new Point(148, 22);
            XRotationTextBox.Name = "XRotationTextBox";
            XRotationTextBox.Size = new Size(68, 23);
            XRotationTextBox.TabIndex = 3;
            XRotationTextBox.TextChanged += XRotationTextBox_TextChanged;
            // 
            // LocationGroupBox
            // 
            LocationGroupBox.Controls.Add(decreasePositionZ);
            LocationGroupBox.Controls.Add(decreasePositionY);
            LocationGroupBox.Controls.Add(decreasePositionX);
            LocationGroupBox.Controls.Add(increasePositionZ);
            LocationGroupBox.Controls.Add(increasePositionY);
            LocationGroupBox.Controls.Add(increasePositionX);
            LocationGroupBox.Controls.Add(textBox2);
            LocationGroupBox.Controls.Add(label3);
            LocationGroupBox.Controls.Add(label2);
            LocationGroupBox.Controls.Add(label1);
            LocationGroupBox.Controls.Add(ZLocationTextBox);
            LocationGroupBox.Controls.Add(YLocationTextBox);
            LocationGroupBox.Controls.Add(XLocationTextBox);
            LocationGroupBox.Location = new Point(6, 22);
            LocationGroupBox.Name = "LocationGroupBox";
            LocationGroupBox.Size = new Size(222, 109);
            LocationGroupBox.TabIndex = 0;
            LocationGroupBox.TabStop = false;
            LocationGroupBox.Text = "Местоположение";
            // 
            // decreasePositionZ
            // 
            decreasePositionZ.Location = new Point(80, 78);
            decreasePositionZ.Name = "decreasePositionZ";
            decreasePositionZ.Size = new Size(28, 23);
            decreasePositionZ.TabIndex = 33;
            decreasePositionZ.Text = "<";
            decreasePositionZ.UseVisualStyleBackColor = true;
            decreasePositionZ.Click += decreasePositionZ_Click;
            // 
            // decreasePositionY
            // 
            decreasePositionY.Location = new Point(80, 54);
            decreasePositionY.Name = "decreasePositionY";
            decreasePositionY.Size = new Size(28, 23);
            decreasePositionY.TabIndex = 32;
            decreasePositionY.Text = "<";
            decreasePositionY.UseVisualStyleBackColor = true;
            decreasePositionY.Click += decreasePositionY_Click;
            // 
            // decreasePositionX
            // 
            decreasePositionX.Location = new Point(80, 29);
            decreasePositionX.Name = "decreasePositionX";
            decreasePositionX.Size = new Size(28, 23);
            decreasePositionX.TabIndex = 31;
            decreasePositionX.Text = "<";
            decreasePositionX.UseVisualStyleBackColor = true;
            decreasePositionX.Click += decreasePositionX_Click;
            // 
            // increasePositionZ
            // 
            increasePositionZ.Location = new Point(114, 78);
            increasePositionZ.Name = "increasePositionZ";
            increasePositionZ.Size = new Size(28, 23);
            increasePositionZ.TabIndex = 30;
            increasePositionZ.Text = ">";
            increasePositionZ.UseVisualStyleBackColor = true;
            increasePositionZ.Click += increasePositionZ_Click;
            // 
            // increasePositionY
            // 
            increasePositionY.Location = new Point(114, 54);
            increasePositionY.Name = "increasePositionY";
            increasePositionY.Size = new Size(28, 23);
            increasePositionY.TabIndex = 29;
            increasePositionY.Text = ">";
            increasePositionY.UseVisualStyleBackColor = true;
            increasePositionY.Click += increasePositionY_Click;
            // 
            // increasePositionX
            // 
            increasePositionX.Location = new Point(114, 29);
            increasePositionX.Name = "increasePositionX";
            increasePositionX.Size = new Size(28, 23);
            increasePositionX.TabIndex = 28;
            increasePositionX.Text = ">";
            increasePositionX.UseVisualStyleBackColor = true;
            increasePositionX.Click += increasePositionX_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, -7);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(67, 23);
            textBox2.TabIndex = 14;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 5;
            label3.Text = "Z";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 4;
            label2.Text = "Y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 3;
            label1.Text = "X";
            // 
            // ZLocationTextBox
            // 
            ZLocationTextBox.Location = new Point(148, 80);
            ZLocationTextBox.Name = "ZLocationTextBox";
            ZLocationTextBox.Size = new Size(68, 23);
            ZLocationTextBox.TabIndex = 2;
            ZLocationTextBox.TextChanged += ZLocationTextBox_TextChanged;
            // 
            // YLocationTextBox
            // 
            YLocationTextBox.Location = new Point(148, 51);
            YLocationTextBox.Name = "YLocationTextBox";
            YLocationTextBox.Size = new Size(68, 23);
            YLocationTextBox.TabIndex = 1;
            YLocationTextBox.TextChanged += YLocationTextBox_TextChanged;
            // 
            // XLocationTextBox
            // 
            XLocationTextBox.Location = new Point(148, 22);
            XLocationTextBox.Name = "XLocationTextBox";
            XLocationTextBox.Size = new Size(68, 23);
            XLocationTextBox.TabIndex = 0;
            XLocationTextBox.TextChanged += XLocationTextBox_TextChanged;
            // 
            // Lab4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TableLayoutPanel);
            Name = "Lab4";
            Text = "Lab4";
            Load += Lab4_Load;
            Resize += Lab4_Resize;
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            TableLayoutPanel.ResumeLayout(false);
            TransformGroupBox.ResumeLayout(false);
            DisplayGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ScaleGroupBox.ResumeLayout(false);
            ScaleGroupBox.PerformLayout();
            RotationGroupBox.ResumeLayout(false);
            RotationGroupBox.PerformLayout();
            LocationGroupBox.ResumeLayout(false);
            LocationGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureBox;
        private System.Windows.Forms.Timer Timer;
        private TableLayoutPanel TableLayoutPanel;
        private GroupBox TransformGroupBox;
        private GroupBox LocationGroupBox;
        private GroupBox ScaleGroupBox;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox ZScaleTextBox;
        private TextBox YScaleTextBox;
        private TextBox XScaleTextBox;
        private GroupBox RotationGroupBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox ZRotationTextBox;
        private TextBox YRotationTextBox;
        private TextBox XRotationTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox ZLocationTextBox;
        private TextBox YLocationTextBox;
        private TextBox XLocationTextBox;
        private GroupBox DisplayGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button OZButton;
        private Button OYButton;
        private Button OXButton;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button increaseSizeX;
        private Button decreaseSizeZ;
        private Button decreaseSizeY;
        private Button decreaseSizeX;
        private Button increaseSizeZ;
        private Button increaseSizeY;
        private Button decreaseRotateZ;
        private Button decreaseRotateY;
        private Button decreaseRotateX;
        private Button increaseRotateZ;
        private Button increaseRotateY;
        private Button increaseRotateX;
        private Button decreasePositionZ;
        private Button decreasePositionY;
        private Button decreasePositionX;
        private Button increasePositionZ;
        private Button increasePositionY;
        private Button increasePositionX;
    }
}
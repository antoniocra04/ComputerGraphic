namespace ComputerGraphic.View.Labs.Lab4.Tabs
{
    partial class OpenGLPrimitives
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
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button12 = new Button();
            button11 = new Button();
            button6 = new Button();
            button10 = new Button();
            button7 = new Button();
            button9 = new Button();
            button8 = new Button();
            button15 = new Button();
            button13 = new Button();
            button14 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            colorDialog1 = new ColorDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(button15);
            panel2.Controls.Add(button13);
            panel2.Controls.Add(button14);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 550);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(numericUpDown4);
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Location = new Point(6, 332);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(720, 148);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Перемещение точки освещения";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(54, 80);
            numericUpDown4.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 23);
            numericUpDown4.TabIndex = 29;
            numericUpDown4.Value = new decimal(new int[] { 30, 0, 0, int.MinValue });
            numericUpDown4.ValueChanged += radioButton1_CheckedChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(54, 51);
            numericUpDown3.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 28;
            numericUpDown3.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown3.ValueChanged += radioButton1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 82);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 27;
            label4.Text = "Z:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 53);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 26;
            label3.Text = "Y:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 24);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 25;
            label2.Text = "X:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(54, 22);
            numericUpDown2.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 24;
            numericUpDown2.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.ValueChanged += radioButton1_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(541, 267);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(33, 19);
            checkBox3.TabIndex = 23;
            checkBox3.Text = "Z";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(541, 242);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(33, 19);
            checkBox2.TabIndex = 22;
            checkBox2.Text = "Y";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(541, 217);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(33, 19);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "X";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 221);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 20;
            label1.Text = "Скорость:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(331, 217);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 19;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Controls.Add(button4, 0, 3);
            tableLayoutPanel1.Controls.Add(button5, 0, 4);
            tableLayoutPanel1.Controls.Add(button12, 0, 5);
            tableLayoutPanel1.Controls.Add(button11, 1, 5);
            tableLayoutPanel1.Controls.Add(button6, 1, 0);
            tableLayoutPanel1.Controls.Add(button10, 1, 4);
            tableLayoutPanel1.Controls.Add(button7, 1, 1);
            tableLayoutPanel1.Controls.Add(button9, 1, 3);
            tableLayoutPanel1.Controls.Add(button8, 1, 2);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6688919F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6688881F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66222F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66222F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6688919F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6688881F));
            tableLayoutPanel1.Size = new Size(723, 196);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(355, 26);
            button1.TabIndex = 0;
            button1.Text = "Cone";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(3, 35);
            button2.Name = "button2";
            button2.Size = new Size(355, 26);
            button2.TabIndex = 1;
            button2.Text = "Cube";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(3, 67);
            button3.Name = "button3";
            button3.Size = new Size(355, 26);
            button3.TabIndex = 2;
            button3.Text = "Cylinder";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(3, 99);
            button4.Name = "button4";
            button4.Size = new Size(355, 26);
            button4.TabIndex = 3;
            button4.Text = "Dodecahedron";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(3, 131);
            button5.Name = "button5";
            button5.Size = new Size(355, 26);
            button5.TabIndex = 4;
            button5.Text = "Icosahedron";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(3, 163);
            button12.Name = "button12";
            button12.Size = new Size(355, 30);
            button12.TabIndex = 11;
            button12.Text = "Torus";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(364, 163);
            button11.Name = "button11";
            button11.Size = new Size(356, 30);
            button11.TabIndex = 10;
            button11.Text = "Tetrahedron";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(364, 3);
            button6.Name = "button6";
            button6.Size = new Size(356, 26);
            button6.TabIndex = 5;
            button6.Text = "Octahedron";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(364, 131);
            button10.Name = "button10";
            button10.Size = new Size(356, 26);
            button10.TabIndex = 9;
            button10.Text = "Teapot";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(364, 35);
            button7.Name = "button7";
            button7.Size = new Size(356, 26);
            button7.TabIndex = 6;
            button7.Text = "Rhombic Dodecahedron";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(364, 99);
            button9.Name = "button9";
            button9.Size = new Size(356, 26);
            button9.TabIndex = 8;
            button9.Text = "Sphere";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(364, 67);
            button8.Name = "button8";
            button8.Size = new Size(356, 26);
            button8.TabIndex = 7;
            button8.Text = "Sierpinski Sponge";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button15
            // 
            button15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button15.Location = new Point(3, 302);
            button15.Name = "button15";
            button15.Size = new Size(723, 23);
            button15.TabIndex = 17;
            button15.Text = "Выбрать цвет фигуры";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button13
            // 
            button13.Location = new Point(129, 246);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 16;
            button13.Text = "Стоп";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(129, 217);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 15;
            button14.Text = "Старт";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 246);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(51, 19);
            radioButton2.TabIndex = 14;
            radioButton2.Text = "Solid";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(3, 221);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 19);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Wire";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // timer1
            // 
            timer1.Interval = 16;
            timer1.Tick += timer1_Tick;
            // 
            // OpenGLPrimitives
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "OpenGLPrimitives";
            Size = new Size(735, 556);
            Load += Primitives_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button button14;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button15;
        private Button button13;
        private ColorDialog colorDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDown2;
    }
}

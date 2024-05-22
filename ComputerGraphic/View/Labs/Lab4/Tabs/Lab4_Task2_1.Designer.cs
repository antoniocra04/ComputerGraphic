namespace ComputerGraphic.View.Labs.Lab4.Tabs
{
    partial class Lab4_Task2_1
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
            PictureBox = new PictureBox();
            TableLayoutPanel = new TableLayoutPanel();
            Timer = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            NumericUpDownX = new NumericUpDown();
            NumericUpDownZ = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            TableLayoutPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownZ).BeginInit();
            SuspendLayout();
            // 
            // PictureBox
            // 
            PictureBox.Dock = DockStyle.Fill;
            PictureBox.Location = new Point(3, 3);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(601, 631);
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 2;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            TableLayoutPanel.Controls.Add(PictureBox, 0, 0);
            TableLayoutPanel.Controls.Add(groupBox1, 1, 0);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 1;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel.Size = new Size(868, 637);
            TableLayoutPanel.TabIndex = 1;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(NumericUpDownZ);
            groupBox1.Controls.Add(NumericUpDownX);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(610, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 92);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Настройка оси";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "X: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 55);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 1;
            label2.Text = "Z: ";
            // 
            // NumericUpDownX
            // 
            NumericUpDownX.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NumericUpDownX.Location = new Point(32, 20);
            NumericUpDownX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NumericUpDownX.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            NumericUpDownX.Name = "NumericUpDownX";
            NumericUpDownX.Size = new Size(120, 23);
            NumericUpDownX.TabIndex = 2;
            // 
            // NumericUpDownZ
            // 
            NumericUpDownZ.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NumericUpDownZ.Location = new Point(32, 53);
            NumericUpDownZ.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NumericUpDownZ.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            NumericUpDownZ.Name = "NumericUpDownZ";
            NumericUpDownZ.Size = new Size(120, 23);
            NumericUpDownZ.TabIndex = 3;
            // 
            // Lab4_Task2_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel);
            Name = "Lab4_Task2_1";
            Size = new Size(868, 637);
            Load += Lab4_Load;
            Resize += Lab4_Resize;
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            TableLayoutPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownX).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownZ).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureBox;
        private TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Timer Timer;
        private GroupBox groupBox1;
        private NumericUpDown NumericUpDownZ;
        private NumericUpDown NumericUpDownX;
        private Label label2;
        private Label label1;
    }
}

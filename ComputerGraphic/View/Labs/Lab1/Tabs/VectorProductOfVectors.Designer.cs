namespace ComputerGraphic.View.Labs.Lab1.Tabs
{
    partial class VectorProductOfVectors
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
            AVectorLabel = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            BVectorLabel = new Label();
            CVectorLabel = new Label();
            XLabel = new Label();
            YLabel = new Label();
            ZLabel = new Label();
            AXTextBox = new TextBox();
            AYTextBox = new TextBox();
            BXTextBox = new TextBox();
            BYTextBox = new TextBox();
            AZTextBox = new TextBox();
            BZTextBox = new TextBox();
            CXTextBox = new TextBox();
            CYTextBox = new TextBox();
            CZTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // AVectorLabel
            // 
            AVectorLabel.AutoSize = true;
            AVectorLabel.Dock = DockStyle.Fill;
            AVectorLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            AVectorLabel.Location = new Point(3, 151);
            AVectorLabel.Name = "AVectorLabel";
            AVectorLabel.Size = new Size(200, 151);
            AVectorLabel.TabIndex = 0;
            AVectorLabel.Text = "Вектор A: ";
            AVectorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(344, 25);
            label1.TabIndex = 1;
            label1.Text = "Векторное произведение векторов";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(AVectorLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(BVectorLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(CVectorLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(XLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(YLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(ZLabel, 3, 0);
            tableLayoutPanel1.Controls.Add(AXTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(AYTextBox, 2, 1);
            tableLayoutPanel1.Controls.Add(BXTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(BYTextBox, 2, 2);
            tableLayoutPanel1.Controls.Add(AZTextBox, 3, 1);
            tableLayoutPanel1.Controls.Add(BZTextBox, 3, 2);
            tableLayoutPanel1.Controls.Add(CXTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(CYTextBox, 2, 3);
            tableLayoutPanel1.Controls.Add(CZTextBox, 3, 3);
            tableLayoutPanel1.Location = new Point(8, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(826, 607);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // BVectorLabel
            // 
            BVectorLabel.AutoSize = true;
            BVectorLabel.Dock = DockStyle.Fill;
            BVectorLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BVectorLabel.Location = new Point(3, 302);
            BVectorLabel.Name = "BVectorLabel";
            BVectorLabel.Size = new Size(200, 151);
            BVectorLabel.TabIndex = 1;
            BVectorLabel.Text = "Вектор B: ";
            BVectorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CVectorLabel
            // 
            CVectorLabel.AutoSize = true;
            CVectorLabel.Dock = DockStyle.Fill;
            CVectorLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            CVectorLabel.Location = new Point(3, 453);
            CVectorLabel.Name = "CVectorLabel";
            CVectorLabel.Size = new Size(200, 154);
            CVectorLabel.TabIndex = 2;
            CVectorLabel.Text = "Вектор C: ";
            CVectorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // XLabel
            // 
            XLabel.AutoSize = true;
            XLabel.Dock = DockStyle.Fill;
            XLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            XLabel.Location = new Point(209, 0);
            XLabel.Name = "XLabel";
            XLabel.Size = new Size(200, 151);
            XLabel.TabIndex = 3;
            XLabel.Text = "X";
            XLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // YLabel
            // 
            YLabel.AutoSize = true;
            YLabel.Dock = DockStyle.Fill;
            YLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            YLabel.Location = new Point(415, 0);
            YLabel.Name = "YLabel";
            YLabel.Size = new Size(200, 151);
            YLabel.TabIndex = 4;
            YLabel.Text = "Y";
            YLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ZLabel
            // 
            ZLabel.AutoSize = true;
            ZLabel.Dock = DockStyle.Fill;
            ZLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ZLabel.Location = new Point(621, 0);
            ZLabel.Name = "ZLabel";
            ZLabel.Size = new Size(202, 151);
            ZLabel.TabIndex = 5;
            ZLabel.Text = "Z";
            ZLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AXTextBox
            // 
            AXTextBox.Dock = DockStyle.Fill;
            AXTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AXTextBox.Location = new Point(209, 154);
            AXTextBox.Multiline = true;
            AXTextBox.Name = "AXTextBox";
            AXTextBox.Size = new Size(200, 145);
            AXTextBox.TabIndex = 6;
            AXTextBox.TextChanged += AXTextBox_TextChanged;
            AXTextBox.Leave += AXTextBox_Leave;
            // 
            // AYTextBox
            // 
            AYTextBox.Dock = DockStyle.Fill;
            AYTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AYTextBox.Location = new Point(415, 154);
            AYTextBox.Multiline = true;
            AYTextBox.Name = "AYTextBox";
            AYTextBox.Size = new Size(200, 145);
            AYTextBox.TabIndex = 7;
            AYTextBox.TextChanged += AYTextBox_TextChanged;
            AYTextBox.Leave += AYTextBox_Leave;
            // 
            // BXTextBox
            // 
            BXTextBox.Dock = DockStyle.Fill;
            BXTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BXTextBox.Location = new Point(209, 305);
            BXTextBox.Multiline = true;
            BXTextBox.Name = "BXTextBox";
            BXTextBox.Size = new Size(200, 145);
            BXTextBox.TabIndex = 8;
            BXTextBox.TextChanged += BXTextBox_TextChanged;
            BXTextBox.Leave += BXTextBox_Leave;
            // 
            // BYTextBox
            // 
            BYTextBox.Dock = DockStyle.Fill;
            BYTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BYTextBox.Location = new Point(415, 305);
            BYTextBox.Multiline = true;
            BYTextBox.Name = "BYTextBox";
            BYTextBox.Size = new Size(200, 145);
            BYTextBox.TabIndex = 9;
            BYTextBox.TextChanged += BYTextBox_TextChanged;
            BYTextBox.Leave += BYTextBox_Leave;
            // 
            // AZTextBox
            // 
            AZTextBox.Dock = DockStyle.Fill;
            AZTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AZTextBox.Location = new Point(621, 154);
            AZTextBox.Multiline = true;
            AZTextBox.Name = "AZTextBox";
            AZTextBox.Size = new Size(202, 145);
            AZTextBox.TabIndex = 10;
            AZTextBox.TextChanged += AZTextBox_TextChanged;
            AZTextBox.Leave += AZTextBox_Leave;
            // 
            // BZTextBox
            // 
            BZTextBox.Dock = DockStyle.Fill;
            BZTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BZTextBox.Location = new Point(621, 305);
            BZTextBox.Multiline = true;
            BZTextBox.Name = "BZTextBox";
            BZTextBox.Size = new Size(202, 145);
            BZTextBox.TabIndex = 11;
            BZTextBox.TextChanged += BZTextBox_TextChanged;
            BZTextBox.Leave += BZTextBox_Leave;
            // 
            // CXTextBox
            // 
            CXTextBox.Dock = DockStyle.Fill;
            CXTextBox.Enabled = false;
            CXTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CXTextBox.Location = new Point(209, 456);
            CXTextBox.Multiline = true;
            CXTextBox.Name = "CXTextBox";
            CXTextBox.Size = new Size(200, 148);
            CXTextBox.TabIndex = 12;
            // 
            // CYTextBox
            // 
            CYTextBox.Dock = DockStyle.Fill;
            CYTextBox.Enabled = false;
            CYTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CYTextBox.Location = new Point(415, 456);
            CYTextBox.Multiline = true;
            CYTextBox.Name = "CYTextBox";
            CYTextBox.Size = new Size(200, 148);
            CYTextBox.TabIndex = 13;
            // 
            // CZTextBox
            // 
            CZTextBox.Dock = DockStyle.Fill;
            CZTextBox.Enabled = false;
            CZTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CZTextBox.Location = new Point(621, 456);
            CZTextBox.Multiline = true;
            CZTextBox.Name = "CZTextBox";
            CZTextBox.Size = new Size(202, 148);
            CZTextBox.TabIndex = 14;
            // 
            // VectorProductOfVectors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            MaximumSize = new Size(1000, 1000);
            MinimumSize = new Size(400, 400);
            Name = "VectorProductOfVectors";
            Size = new Size(840, 656);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AVectorLabel;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label BVectorLabel;
        private Label CVectorLabel;
        private Label XLabel;
        private Label YLabel;
        private Label ZLabel;
        private TextBox AXTextBox;
        private TextBox AYTextBox;
        private TextBox BXTextBox;
        private TextBox BYTextBox;
        private TextBox AZTextBox;
        private TextBox BZTextBox;
        private TextBox CXTextBox;
        private TextBox CYTextBox;
        private TextBox CZTextBox;
    }
}

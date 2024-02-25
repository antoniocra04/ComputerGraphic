namespace ComputerGraphic.View.Labs.Lab1.Tabs
{
    partial class SM
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            aXTextBox = new TextBox();
            aYTextBox = new TextBox();
            aZTextBox = new TextBox();
            bZTextBox = new TextBox();
            bYTextBox = new TextBox();
            bXTextBox = new TextBox();
            labelX = new Label();
            labelY = new Label();
            labelZ = new Label();
            labelVectorA = new Label();
            labelVectorB = new Label();
            resultTextBox = new TextBox();
            labelResult = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tableLayoutPanel1.Controls.Add(aXTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(aYTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(aZTextBox, 2, 0);
            tableLayoutPanel1.Controls.Add(bZTextBox, 2, 1);
            tableLayoutPanel1.Controls.Add(bYTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(bXTextBox, 0, 1);
            tableLayoutPanel1.Location = new Point(207, 182);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(403, 151);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // aXTextBox
            // 
            aXTextBox.Location = new Point(3, 3);
            aXTextBox.Multiline = true;
            aXTextBox.Name = "aXTextBox";
            aXTextBox.Size = new Size(128, 69);
            aXTextBox.TabIndex = 0;
            aXTextBox.TextChanged += AXTextBox_TextChanged;
            aXTextBox.Leave += AXTextBox_Leave;
            // 
            // aYTextBox
            // 
            aYTextBox.Location = new Point(137, 3);
            aYTextBox.Multiline = true;
            aYTextBox.Name = "aYTextBox";
            aYTextBox.Size = new Size(128, 69);
            aYTextBox.TabIndex = 0;
            aYTextBox.TextChanged += AYTextBox_TextChanged;
            aYTextBox.Leave += AYTextBox_Leave;
            // 
            // aZTextBox
            // 
            aZTextBox.Location = new Point(271, 3);
            aZTextBox.Multiline = true;
            aZTextBox.Name = "aZTextBox";
            aZTextBox.Size = new Size(128, 69);
            aZTextBox.TabIndex = 0;
            aZTextBox.TextChanged += AZTextBox_TextChanged;
            aZTextBox.Leave += AZTextBox_Leave;
            // 
            // bZTextBox
            // 
            bZTextBox.Location = new Point(271, 78);
            bZTextBox.Multiline = true;
            bZTextBox.Name = "bZTextBox";
            bZTextBox.Size = new Size(128, 69);
            bZTextBox.TabIndex = 0;
            bZTextBox.TextChanged += BZTextBox_TextChanged;
            bZTextBox.Leave += BZTextBox_Leave;
            // 
            // bYTextBox
            // 
            bYTextBox.Location = new Point(137, 78);
            bYTextBox.Multiline = true;
            bYTextBox.Name = "bYTextBox";
            bYTextBox.Size = new Size(128, 69);
            bYTextBox.TabIndex = 0;
            bYTextBox.TextChanged += BYTextBox_TextChanged;
            bYTextBox.Leave += BYTextBox_Leave;
            // 
            // bXTextBox
            // 
            bXTextBox.Location = new Point(3, 78);
            bXTextBox.Multiline = true;
            bXTextBox.Name = "bXTextBox";
            bXTextBox.Size = new Size(128, 69);
            bXTextBox.TabIndex = 0;
            bXTextBox.TextChanged += BXTextBox_TextChanged;
            bXTextBox.Leave += BXTextBox_Leave;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelX.Location = new Point(261, 130);
            labelX.Name = "labelX";
            labelX.Size = new Size(28, 32);
            labelX.TabIndex = 1;
            labelX.Text = "X";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelY.Location = new Point(395, 130);
            labelY.Name = "labelY";
            labelY.Size = new Size(27, 32);
            labelY.TabIndex = 1;
            labelY.Text = "Y";
            // 
            // labelZ
            // 
            labelZ.AutoSize = true;
            labelZ.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelZ.Location = new Point(524, 130);
            labelZ.Name = "labelZ";
            labelZ.Size = new Size(28, 32);
            labelZ.TabIndex = 1;
            labelZ.Text = "Z";
            // 
            // labelVectorA
            // 
            labelVectorA.AutoSize = true;
            labelVectorA.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelVectorA.Location = new Point(95, 204);
            labelVectorA.Name = "labelVectorA";
            labelVectorA.Size = new Size(106, 30);
            labelVectorA.TabIndex = 2;
            labelVectorA.Text = "Вектор А";
            // 
            // labelVectorB
            // 
            labelVectorB.AutoSize = true;
            labelVectorB.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelVectorB.Location = new Point(95, 277);
            labelVectorB.Name = "labelVectorB";
            labelVectorB.Size = new Size(104, 30);
            labelVectorB.TabIndex = 2;
            labelVectorB.Text = "Вектор Б";
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(344, 366);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(128, 69);
            resultTextBox.TabIndex = 3;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelResult.Location = new Point(212, 386);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(126, 32);
            labelResult.TabIndex = 4;
            labelResult.Text = "Результат";
            // 
            // SM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelResult);
            Controls.Add(resultTextBox);
            Controls.Add(labelVectorB);
            Controls.Add(labelVectorA);
            Controls.Add(labelZ);
            Controls.Add(labelY);
            Controls.Add(labelX);
            Controls.Add(tableLayoutPanel1);
            Name = "SM";
            Size = new Size(915, 601);
            Load += SM_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox aXTextBox;
        private TextBox aYTextBox;
        private TextBox aZTextBox;
        private TextBox bZTextBox;
        private TextBox bYTextBox;
        private TextBox bXTextBox;
        private Label labelX;
        private Label labelY;
        private Label labelZ;
        private Label labelVectorA;
        private Label labelVectorB;
        private TextBox resultTextBox;
        private Label labelResult;
    }
}

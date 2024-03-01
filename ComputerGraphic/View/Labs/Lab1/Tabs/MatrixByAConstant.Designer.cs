namespace ComputerGraphic.View.Labs.Lab1.Tabs
{
    partial class MatrixByAConstant
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
            CreateMatrixButton = new Button();
            nTextBox = new TextBox();
            Labeln = new Label();
            Labelconst = new Label();
            constTextBox = new TextBox();
            ResultButton = new Button();
            LabelError1 = new Label();
            LabelError2 = new Label();
            SuspendLayout();
            // 
            // CreateMatrixButton
            // 
            CreateMatrixButton.Location = new Point(104, 104);
            CreateMatrixButton.Name = "CreateMatrixButton";
            CreateMatrixButton.Size = new Size(91, 35);
            CreateMatrixButton.TabIndex = 0;
            CreateMatrixButton.Text = "Create Matrix";
            CreateMatrixButton.UseVisualStyleBackColor = true;
            CreateMatrixButton.Click += CreateMatrixButton_Click;
            // 
            // nTextBox
            // 
            nTextBox.Location = new Point(159, 63);
            nTextBox.Name = "nTextBox";
            nTextBox.Size = new Size(100, 23);
            nTextBox.TabIndex = 1;
            nTextBox.TextChanged += nTextBox_TextChanged;
            nTextBox.Leave += nTextBox_Leave;
            // 
            // Labeln
            // 
            Labeln.AutoSize = true;
            Labeln.Location = new Point(106, 66);
            Labeln.Name = "Labeln";
            Labeln.Size = new Size(28, 15);
            Labeln.TabIndex = 2;
            Labeln.Text = "n = ";
            // 
            // Labelconst
            // 
            Labelconst.AutoSize = true;
            Labelconst.Location = new Point(106, 161);
            Labelconst.Name = "Labelconst";
            Labelconst.Size = new Size(47, 15);
            Labelconst.TabIndex = 3;
            Labelconst.Text = "const =";
            // 
            // constTextBox
            // 
            constTextBox.Location = new Point(159, 158);
            constTextBox.Name = "constTextBox";
            constTextBox.Size = new Size(100, 23);
            constTextBox.TabIndex = 4;
            constTextBox.TextChanged += constTextBox_Leave;
            // 
            // ResultButton
            // 
            ResultButton.Location = new Point(106, 204);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(89, 35);
            ResultButton.TabIndex = 5;
            ResultButton.Text = "Result";
            ResultButton.UseVisualStyleBackColor = true;
            ResultButton.Click += ResultButton_Click;
            // 
            // LabelError1
            // 
            LabelError1.AutoSize = true;
            LabelError1.Location = new Point(259, 114);
            LabelError1.Name = "LabelError1";
            LabelError1.Size = new Size(0, 15);
            LabelError1.TabIndex = 6;
            // 
            // LabelError2
            // 
            LabelError2.AutoSize = true;
            LabelError2.Location = new Point(259, 214);
            LabelError2.Name = "LabelError2";
            LabelError2.Size = new Size(0, 15);
            LabelError2.TabIndex = 6;
            // 
            // MatrixByAConstant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LabelError2);
            Controls.Add(LabelError1);
            Controls.Add(ResultButton);
            Controls.Add(constTextBox);
            Controls.Add(Labelconst);
            Controls.Add(Labeln);
            Controls.Add(nTextBox);
            Controls.Add(CreateMatrixButton);
            Name = "MatrixByAConstant";
            Size = new Size(761, 359);
            Load += MatrixByAConstant_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateMatrixButton;
        private TextBox nTextBox;
        private Label Labeln;
        private Label Labelconst;
        private TextBox constTextBox;
        private Button ResultButton;
        private Label LabelError1;
        private Label LabelError2;
    }
}

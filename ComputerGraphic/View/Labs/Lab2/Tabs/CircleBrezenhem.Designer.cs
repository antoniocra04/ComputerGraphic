namespace ComputerGraphic.View.Labs.Lab2.Tabs
{
    partial class UserControl1
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            GroupBox = new GroupBox();
            RadiusTextBox = new TextBox();
            ClearButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 434);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(519, 434);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(RadiusTextBox);
            GroupBox.Controls.Add(ClearButton);
            GroupBox.Location = new Point(528, 3);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(229, 428);
            GroupBox.TabIndex = 1;
            GroupBox.TabStop = false;
            GroupBox.Text = "Окружность Брезенхема";
            // 
            // RadiusTextBox
            // 
            RadiusTextBox.Location = new Point(61, 203);
            RadiusTextBox.Name = "RadiusTextBox";
            RadiusTextBox.Size = new Size(100, 23);
            RadiusTextBox.TabIndex = 2;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(58, 362);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(103, 41);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GroupBox);
            Controls.Add(panel1);
            Name = "UserControl1";
            Size = new Size(760, 434);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox GroupBox;
        private PictureBox pictureBox1;
        private Button ClearButton;
        private TextBox RadiusTextBox;
    }
}

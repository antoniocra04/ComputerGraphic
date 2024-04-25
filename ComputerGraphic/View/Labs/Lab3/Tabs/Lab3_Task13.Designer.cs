using System.Security.Cryptography.Xml;

namespace ComputerGraphic.View.Labs.Lab3.Tabs
{
    partial class Lab3_Task13
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
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(4, 3, 4, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(933, 462);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            pictureBox.Paint += pictureBox_Paint;
            // Создание и настройка таймера
            this.AnimationTimer = new System.Windows.Forms.Timer();
            this.AnimationTimer.Interval = 50; // Интервал в миллисекундах
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            this.AnimationTimer.Start();
            // 
            // Lab3_Task13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Lab3_Task13";
            Size = new Size(933, 462);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private System.Windows.Forms.Timer AnimationTimer;
        private TableLayoutPanel TableLayoutPanel;
        private Panel Panel;
        private Label SpeedLabel;
        private TrackBar IntervalTrackBar;
    }
}

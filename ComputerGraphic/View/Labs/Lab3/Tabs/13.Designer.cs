namespace ComputerGraphic.View.Labs.Lab3.Tabs
{
    partial class _13
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
            components = new System.ComponentModel.Container();
            PictureBox = new PictureBox();
            Panel = new Panel();
            TableLayoutPanel = new TableLayoutPanel();
            Timer = new System.Windows.Forms.Timer(components);
            TUSUR = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            Panel.SuspendLayout();
            TableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PictureBox
            // 
            PictureBox.Dock = DockStyle.Fill;
            PictureBox.Location = new Point(3, 3);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(588, 479);
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Panel
            // 
            Panel.BorderStyle = BorderStyle.FixedSingle;
            Panel.Controls.Add(TUSUR);
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(597, 3);
            Panel.Name = "Panel";
            Panel.Size = new Size(249, 479);
            Panel.TabIndex = 1;
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
            TableLayoutPanel.Size = new Size(849, 485);
            TableLayoutPanel.TabIndex = 2;
            // 
            // Timer
            // 
            Timer.Interval = 2;
            Timer.Tick += Timer_Tick;
            // 
            // TUSUR
            // 
            TUSUR.Location = new Point(74, 220);
            TUSUR.Name = "TUSUR";
            TUSUR.Size = new Size(103, 41);
            TUSUR.TabIndex = 2;
            TUSUR.Text = "ТУСУР";
            TUSUR.UseVisualStyleBackColor = true;
            TUSUR.Click += TUSUR_Click;
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel);
            Name = "_13";
            Size = new Size(849, 485);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            Panel.ResumeLayout(false);
            TableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureBox;
        private Panel Panel;
        private TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Timer Timer;
        private Button TUSUR;
    }
}

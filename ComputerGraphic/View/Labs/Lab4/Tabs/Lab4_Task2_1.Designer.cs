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
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            TableLayoutPanel.SuspendLayout();
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
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureBox;
        private TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Timer Timer;
    }
}

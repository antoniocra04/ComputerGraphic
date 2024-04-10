namespace ComputerGraphic.View.Labs.Lab3.Tabs
{
    partial class Lab3_Task14
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
            Timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // PictureBox
            // 
            PictureBox.Dock = DockStyle.Fill;
            PictureBox.Location = new Point(0, 0);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(719, 535);
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.Click += PictureBox_Click;
            PictureBox.DoubleClick += PictureBox_DoubleClick;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // Lab3_Task14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PictureBox);
            Name = "Lab3_Task14";
            Size = new Size(719, 535);
            Load += Lab3_Task14_Load;
            Resize += Lab3_Task14_Resize;
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox PictureBox;
        private System.Windows.Forms.Timer Timer;
    }
}

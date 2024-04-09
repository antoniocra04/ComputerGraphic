namespace ComputerGraphic.View.Labs.Lab3.Tabs
{
    partial class Lab3_Task10
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
            Panel = new Panel();
            SpeedLabel = new Label();
            IntervalTrackBar = new TrackBar();
            Timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            TableLayoutPanel.SuspendLayout();
            Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IntervalTrackBar).BeginInit();
            SuspendLayout();
            // 
            // PictureBox
            // 
            PictureBox.Dock = DockStyle.Fill;
            PictureBox.Location = new Point(3, 3);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(596, 513);
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
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
            TableLayoutPanel.Size = new Size(861, 519);
            TableLayoutPanel.TabIndex = 1;
            // 
            // Panel
            // 
            Panel.BorderStyle = BorderStyle.FixedSingle;
            Panel.Controls.Add(SpeedLabel);
            Panel.Controls.Add(IntervalTrackBar);
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(605, 3);
            Panel.Name = "Panel";
            Panel.Size = new Size(253, 513);
            Panel.TabIndex = 1;
            // 
            // SpeedLabel
            // 
            SpeedLabel.AutoSize = true;
            SpeedLabel.Location = new Point(3, 0);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new Size(121, 15);
            SpeedLabel.TabIndex = 1;
            SpeedLabel.Text = "Скорость анимации:";
            // 
            // IntervalTrackBar
            // 
            IntervalTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IntervalTrackBar.Location = new Point(3, 18);
            IntervalTrackBar.Maximum = 200;
            IntervalTrackBar.Name = "IntervalTrackBar";
            IntervalTrackBar.Size = new Size(245, 45);
            IntervalTrackBar.TabIndex = 0;
            IntervalTrackBar.Value = 100;
            IntervalTrackBar.Scroll += IntervalTrackBar_Scroll;
            // 
            // Timer
            // 
            Timer.Interval = 2;
            Timer.Tick += Timer_Tick;
            // 
            // Lab3_Task10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel);
            Name = "Lab3_Task10";
            Size = new Size(861, 519);
            Load += Lab3_Task10_Load;
            Resize += Lab3_Task10_Resize;
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            TableLayoutPanel.ResumeLayout(false);
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IntervalTrackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureBox;
        private TableLayoutPanel TableLayoutPanel;
        private Panel Panel;
        private Label SpeedLabel;
        private TrackBar IntervalTrackBar;
        private System.Windows.Forms.Timer Timer;
    }
}

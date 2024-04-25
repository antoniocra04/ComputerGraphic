namespace ComputerGraphic.View.Labs.Lab3
{
    partial class Lab3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lab3_Task10 = new Tabs.Lab3_Task10();
            TabControl = new TabControl();
            Task10 = new TabPage();
            Task14 = new TabPage();
            lab3_Task141 = new Tabs.Lab3_Task14();
            Task13 = new TabPage();
            _131 = new Tabs._13();
            TabControl.SuspendLayout();
            Task10.SuspendLayout();
            Task14.SuspendLayout();
            Task13.SuspendLayout();
            SuspendLayout();
            // 
            // lab3_Task10
            // 
            lab3_Task10.Dock = DockStyle.Fill;
            lab3_Task10.Location = new Point(3, 3);
            lab3_Task10.Name = "lab3_Task10";
            lab3_Task10.Size = new Size(898, 520);
            lab3_Task10.TabIndex = 0;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(Task10);
            TabControl.Controls.Add(Task14);
            TabControl.Controls.Add(Task13);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(912, 554);
            TabControl.TabIndex = 1;
            // 
            // Task10
            // 
            Task10.Controls.Add(lab3_Task10);
            Task10.Location = new Point(4, 24);
            Task10.Name = "Task10";
            Task10.Padding = new Padding(3);
            Task10.Size = new Size(904, 526);
            Task10.TabIndex = 0;
            Task10.Text = "Задание 10";
            Task10.UseVisualStyleBackColor = true;
            // 
            // Task14
            // 
            Task14.Controls.Add(lab3_Task141);
            Task14.Location = new Point(4, 24);
            Task14.Name = "Task14";
            Task14.Padding = new Padding(3);
            Task14.Size = new Size(904, 526);
            Task14.TabIndex = 1;
            Task14.Text = "Задание 14";
            Task14.UseVisualStyleBackColor = true;
            // 
            // lab3_Task141
            // 
            lab3_Task141.Dock = DockStyle.Fill;
            lab3_Task141.Location = new Point(3, 3);
            lab3_Task141.Name = "lab3_Task141";
            lab3_Task141.Size = new Size(898, 520);
            lab3_Task141.TabIndex = 0;
            // 
            // Task13
            // 
            Task13.Controls.Add(_131);
            Task13.Location = new Point(4, 24);
            Task13.Name = "Task13";
            Task13.Size = new Size(904, 526);
            Task13.TabIndex = 2;
            Task13.Text = "Task13";
            Task13.UseVisualStyleBackColor = true;
            // 
            // _131
            // 
            _131.Location = new Point(-4, 3);
            _131.Name = "_131";
            _131.Size = new Size(908, 526);
            _131.TabIndex = 0;
            _131.Load += _131_Load;
            // 
            // Lab3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 554);
            Controls.Add(TabControl);
            Name = "Lab3";
            Text = "Lab3";
            TabControl.ResumeLayout(false);
            Task10.ResumeLayout(false);
            Task14.ResumeLayout(false);
            Task13.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Tabs.Lab3_Task10 lab3_Task10;
        private TabControl TabControl;
        private TabPage Task10;
        private TabPage Task14;
        private Tabs.Lab3_Task14 lab3_Task141;
        private TabPage Task13;
        private Tabs._13 _131;
    }
}
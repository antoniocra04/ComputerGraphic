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
            tabPage2 = new TabPage();
            TabControl.SuspendLayout();
            Task10.SuspendLayout();
            SuspendLayout();
            // 
            // lab3_Task10
            // 
            lab3_Task10.Dock = DockStyle.Fill;
            lab3_Task10.Location = new Point(3, 3);
            lab3_Task10.Name = "lab3_Task10";
            lab3_Task10.Size = new Size(786, 416);
            lab3_Task10.TabIndex = 0;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(Task10);
            TabControl.Controls.Add(tabPage2);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(800, 450);
            TabControl.TabIndex = 1;
            // 
            // Task10
            // 
            Task10.Controls.Add(lab3_Task10);
            Task10.Location = new Point(4, 24);
            Task10.Name = "Task10";
            Task10.Padding = new Padding(3);
            Task10.Size = new Size(792, 422);
            Task10.TabIndex = 0;
            Task10.Text = "Задание 10";
            Task10.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Lab3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabControl);
            Name = "Lab3";
            Text = "Lab3";
            TabControl.ResumeLayout(false);
            Task10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Tabs.Lab3_Task10 lab3_Task10;
        private TabControl TabControl;
        private TabPage Task10;
        private TabPage tabPage2;
    }
}
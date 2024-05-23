namespace ComputerGraphic.View.Labs.Lab4
{
    partial class Lab4
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
            tabPage3 = new TabPage();
            tabPage1 = new TabPage();
            graphic1 = new Tabs.Graphic();
            tabPage2 = new TabPage();
            tabControl1 = new TabControl();
            lab4_Task2_12 = new Tabs.Lab4_Task2_1();
            openglPrimitives2 = new Tabs.OpenGLPrimitives();
            tabPage3.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(openglPrimitives2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "OpenGL";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(graphic1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Graphic";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // graphic1
            // 
            graphic1.Location = new Point(0, 0);
            graphic1.Name = "graphic1";
            graphic1.Size = new Size(792, 422);
            graphic1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lab4_Task2_12);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Алгоритм Робертса";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // lab4_Task2_12
            // 
            lab4_Task2_12.Dock = DockStyle.Fill;
            lab4_Task2_12.Location = new Point(3, 3);
            lab4_Task2_12.Name = "lab4_Task2_12";
            lab4_Task2_12.Size = new Size(786, 416);
            lab4_Task2_12.TabIndex = 0;
            // 
            // openglPrimitives2
            // 
            openglPrimitives2.AngleX = 307F;
            openglPrimitives2.AngleY = 307F;
            openglPrimitives2.AngleZ = 307F;
            openglPrimitives2.CurrentObject = 1;
            openglPrimitives2.Dock = DockStyle.Fill;
            openglPrimitives2.Location = new Point(3, 3);
            openglPrimitives2.MaterialColor = Color.White;
            openglPrimitives2.Name = "openglPrimitives2";
            openglPrimitives2.Size = new Size(786, 416);
            openglPrimitives2.Speed = 1F;
            openglPrimitives2.TabIndex = 0;
            // 
            // Lab4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Lab4";
            Text = "Lab4";
            tabPage3.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Tabs.Lab4_Task2_1 lab4_Task2_11;
        private Tabs.OpenGLPrimitives openglPrimitives1;
        private TabPage tabPage3;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControl1;
        private Tabs.Graphic graphic1;
        private Tabs.OpenGLPrimitives openglPrimitives2;
        private Tabs.Lab4_Task2_1 lab4_Task2_12;
    }
}
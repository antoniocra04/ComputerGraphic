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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            lab4_Task2_11 = new Tabs.Lab4_Task2_1();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            openglPrimitives1 = new Tabs.OpenGLPrimitives();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
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
            // tabPage2
            // 
            tabPage2.Controls.Add(lab4_Task2_11);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Алгоритм Робертса";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lab4_Task2_11
            // 
            lab4_Task2_11.Dock = DockStyle.Fill;
            lab4_Task2_11.Location = new Point(3, 3);
            lab4_Task2_11.Name = "lab4_Task2_11";
            lab4_Task2_11.Size = new Size(786, 416);
            lab4_Task2_11.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(openglPrimitives1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "OpenGL";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // openglPrimitives1
            // 
            openglPrimitives1.AngleX = 117F;
            openglPrimitives1.AngleY = 117F;
            openglPrimitives1.AngleZ = 117F;
            openglPrimitives1.CurrentObject = 1;
            openglPrimitives1.Dock = DockStyle.Fill;
            openglPrimitives1.Location = new Point(3, 3);
            openglPrimitives1.MaterialColor = Color.White;
            openglPrimitives1.Name = "openglPrimitives1";
            openglPrimitives1.Size = new Size(786, 416);
            openglPrimitives1.Speed = 1F;
            openglPrimitives1.TabIndex = 0;
            // 
            // Lab4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Lab4";
            Text = "Lab4";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private Tabs.Lab4_Task2_1 lab4_Task2_11;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private Tabs.OpenGLPrimitives openglPrimitives1;
    }
}
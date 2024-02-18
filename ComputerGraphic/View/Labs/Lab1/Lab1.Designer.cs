namespace ComputerGraphic.View.Labs.Lab1
{
    partial class Lab1
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
            this.VPOVTab = new System.Windows.Forms.TabPage();
            this.vectorProductOfVectors1 = new ComputerGraphic.View.Labs.Lab1.Tabs.VectorProductOfVectors();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MMVTab = new System.Windows.Forms.TabPage();
            this.multiplyingMatricesByVector1 = new ComputerGraphic.View.Labs.Lab1.Tabs.MultiplyingMatricesByVector();
            this.VPOVTab.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.MMVTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // VPOVTab
            // 
            this.VPOVTab.Controls.Add(this.vectorProductOfVectors1);
            this.VPOVTab.Location = new System.Drawing.Point(4, 24);
            this.VPOVTab.Name = "VPOVTab";
            this.VPOVTab.Padding = new System.Windows.Forms.Padding(3);
            this.VPOVTab.Size = new System.Drawing.Size(603, 604);
            this.VPOVTab.TabIndex = 0;
            this.VPOVTab.Text = "Векторное произведение векторов";
            this.VPOVTab.UseVisualStyleBackColor = true;
            // 
            // vectorProductOfVectors1
            // 
            this.vectorProductOfVectors1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vectorProductOfVectors1.Location = new System.Drawing.Point(3, 3);
            this.vectorProductOfVectors1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.vectorProductOfVectors1.MinimumSize = new System.Drawing.Size(500, 500);
            this.vectorProductOfVectors1.Name = "vectorProductOfVectors1";
            this.vectorProductOfVectors1.Size = new System.Drawing.Size(597, 598);
            this.vectorProductOfVectors1.TabIndex = 0;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.VPOVTab);
            this.MainTabControl.Controls.Add(this.MMVTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(611, 632);
            this.MainTabControl.TabIndex = 0;
            // 
            // MMVTab
            // 
            this.MMVTab.Controls.Add(this.multiplyingMatricesByVector1);
            this.MMVTab.Location = new System.Drawing.Point(4, 24);
            this.MMVTab.Name = "MMVTab";
            this.MMVTab.Size = new System.Drawing.Size(603, 604);
            this.MMVTab.TabIndex = 1;
            this.MMVTab.Text = "Умножение матриц на вектор";
            this.MMVTab.UseVisualStyleBackColor = true;
            this.MMVTab.Click += new System.EventHandler(this.MMVTab_Click);
            // 
            // multiplyingMatricesByVector1
            // 
            this.multiplyingMatricesByVector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplyingMatricesByVector1.Location = new System.Drawing.Point(0, 0);
            this.multiplyingMatricesByVector1.Name = "multiplyingMatricesByVector1";
            this.multiplyingMatricesByVector1.Size = new System.Drawing.Size(603, 604);
            this.multiplyingMatricesByVector1.TabIndex = 0;
            this.multiplyingMatricesByVector1.Load += new System.EventHandler(this.multiplyingMatricesByVector1_Load);
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 632);
            this.Controls.Add(this.MainTabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1031, 1071);
            this.MinimumSize = new System.Drawing.Size(527, 567);
            this.Name = "Lab1";
            this.Text = "Lab1";
            this.VPOVTab.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.MMVTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage VPOVTab;
        private Tabs.VectorProductOfVectors vectorProductOfVectors1;
        private TabControl MainTabControl;
        private TabPage MMVTab;
        private Tabs.MultiplyingMatricesByVector multiplyingMatricesByVector1;
    }
}
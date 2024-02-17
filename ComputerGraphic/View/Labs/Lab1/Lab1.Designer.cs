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
            VPOVTab = new TabPage();
            MainTabControl = new TabControl();
            vectorProductOfVectors1 = new Tabs.VectorProductOfVectors();
            VPOVTab.SuspendLayout();
            MainTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // VPOVTab
            // 
            VPOVTab.Controls.Add(vectorProductOfVectors1);
            VPOVTab.Location = new Point(4, 24);
            VPOVTab.Name = "VPOVTab";
            VPOVTab.Padding = new Padding(3);
            VPOVTab.Size = new Size(603, 604);
            VPOVTab.TabIndex = 0;
            VPOVTab.Text = "Векторное произведение векторов";
            VPOVTab.UseVisualStyleBackColor = true;
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(VPOVTab);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(611, 632);
            MainTabControl.TabIndex = 0;
            // 
            // vectorProductOfVectors1
            // 
            vectorProductOfVectors1.Dock = DockStyle.Fill;
            vectorProductOfVectors1.Location = new Point(3, 3);
            vectorProductOfVectors1.MaximumSize = new Size(1000, 1000);
            vectorProductOfVectors1.MinimumSize = new Size(500, 500);
            vectorProductOfVectors1.Name = "vectorProductOfVectors1";
            vectorProductOfVectors1.Size = new Size(597, 598);
            vectorProductOfVectors1.TabIndex = 0;
            // 
            // Lab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 632);
            Controls.Add(MainTabControl);
            MaximizeBox = false;
            MaximumSize = new Size(1031, 1071);
            MinimumSize = new Size(527, 567);
            Name = "Lab1";
            Text = "Lab1";
            VPOVTab.ResumeLayout(false);
            MainTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage VPOVTab;
        private Tabs.VectorProductOfVectors vectorProductOfVectors1;
        private TabControl MainTabControl;
    }
}
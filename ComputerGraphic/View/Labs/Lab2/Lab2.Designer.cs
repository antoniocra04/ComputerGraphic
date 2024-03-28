namespace ComputerGraphic.View.Labs.Lab2
{
    partial class Lab2
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
            BorderColorDialog = new ColorDialog();
            FillColorDialog = new ColorDialog();
            cohenSutherlandAlgorithmTab1 = new Tabs.CohenSutherlandAlgorithmTab();
            CSATabControl = new TabControl();
            CSATabPage = new TabPage();
            PCATabPage = new TabPage();
            BrazenhemTabPage = new TabPage();
            polygonColoringAlgorithm2 = new Tabs.PolygonColoringAlgorithm();
            userControl11 = new Tabs.UserControl1();
            CSATabControl.SuspendLayout();
            CSATabPage.SuspendLayout();
            PCATabPage.SuspendLayout();
            BrazenhemTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // cohenSutherlandAlgorithmTab1
            // 
            cohenSutherlandAlgorithmTab1.Dock = DockStyle.Fill;
            cohenSutherlandAlgorithmTab1.Location = new Point(3, 3);
            cohenSutherlandAlgorithmTab1.Name = "cohenSutherlandAlgorithmTab1";
            cohenSutherlandAlgorithmTab1.Size = new Size(756, 432);
            cohenSutherlandAlgorithmTab1.TabIndex = 0;
            // 
            // CSATabControl
            // 
            CSATabControl.Controls.Add(CSATabPage);
            CSATabControl.Controls.Add(PCATabPage);
            CSATabControl.Controls.Add(BrazenhemTabPage);
            CSATabControl.Dock = DockStyle.Fill;
            CSATabControl.Location = new Point(0, 0);
            CSATabControl.Name = "CSATabControl";
            CSATabControl.SelectedIndex = 0;
            CSATabControl.Size = new Size(770, 466);
            CSATabControl.TabIndex = 1;
            // 
            // CSATabPage
            // 
            CSATabPage.Controls.Add(cohenSutherlandAlgorithmTab1);
            CSATabPage.Location = new Point(4, 24);
            CSATabPage.Name = "CSATabPage";
            CSATabPage.Padding = new Padding(3);
            CSATabPage.Size = new Size(762, 438);
            CSATabPage.TabIndex = 0;
            CSATabPage.Text = "Алгоритм Коэна-Сазерленда";
            CSATabPage.UseVisualStyleBackColor = true;
            // 
            // PCATabPage
            // 
            PCATabPage.Controls.Add(polygonColoringAlgorithm2);
            PCATabPage.Location = new Point(4, 24);
            PCATabPage.Name = "PCATabPage";
            PCATabPage.Padding = new Padding(3);
            PCATabPage.Size = new Size(762, 438);
            PCATabPage.TabIndex = 1;
            PCATabPage.Text = "Алгоритм закраски многоугольника";
            PCATabPage.UseVisualStyleBackColor = true;
            // 
            // BrazenhemTabPage
            // 
            BrazenhemTabPage.Controls.Add(userControl11);
            BrazenhemTabPage.Location = new Point(4, 24);
            BrazenhemTabPage.Name = "BrazenhemTabPage";
            BrazenhemTabPage.Padding = new Padding(3);
            BrazenhemTabPage.Size = new Size(762, 438);
            BrazenhemTabPage.TabIndex = 2;
            BrazenhemTabPage.Text = "Алгортим Брезенхема";
            BrazenhemTabPage.UseVisualStyleBackColor = true;
            // 
            // polygonColoringAlgorithm2
            // 
            polygonColoringAlgorithm2.BorderColor = Color.Black;
            polygonColoringAlgorithm2.BrushSize = 3;
            polygonColoringAlgorithm2.Dock = DockStyle.Fill;
            polygonColoringAlgorithm2.FillColor = Color.AliceBlue;
            polygonColoringAlgorithm2.Location = new Point(3, 3);
            polygonColoringAlgorithm2.Name = "polygonColoringAlgorithm2";
            polygonColoringAlgorithm2.Size = new Size(756, 432);
            polygonColoringAlgorithm2.TabIndex = 0;
            // 
            // userControl11
            // 
            userControl11.Dock = DockStyle.Fill;
            userControl11.Location = new Point(3, 3);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(756, 432);
            userControl11.TabIndex = 0;
            // 
            // Lab2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 466);
            Controls.Add(CSATabControl);
            MinimumSize = new Size(754, 395);
            Name = "Lab2";
            Text = "Лабораторная работа 2";
            Load += Lab2_Load;
            CSATabControl.ResumeLayout(false);
            CSATabPage.ResumeLayout(false);
            PCATabPage.ResumeLayout(false);
            BrazenhemTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ColorDialog BorderColorDialog;
        private ColorDialog FillColorDialog;
        private Tabs.CohenSutherlandAlgorithmTab cohenSutherlandAlgorithmTab1;
        private TabControl CSATabControl;
        private TabPage CSATabPage;
        private TabPage PCATabPage;
        private Tabs.PolygonColoringAlgorithm polygonColoringAlgorithm1;
        private TabPage BrazenhemTabPage;
        private Tabs.PolygonColoringAlgorithm polygonColoringAlgorithm2;
        private Tabs.UserControl1 userControl11;
    }
}
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
            polygonColoringAlgorithm1 = new Tabs.PolygonColoringAlgorithm();
            CSATabControl.SuspendLayout();
            CSATabPage.SuspendLayout();
            PCATabPage.SuspendLayout();
            SuspendLayout();
            // 
            // cohenSutherlandAlgorithmTab1
            // 
            cohenSutherlandAlgorithmTab1.Dock = DockStyle.Fill;
            cohenSutherlandAlgorithmTab1.Location = new Point(3, 3);
            cohenSutherlandAlgorithmTab1.Name = "cohenSutherlandAlgorithmTab1";
            cohenSutherlandAlgorithmTab1.Size = new Size(857, 407);
            cohenSutherlandAlgorithmTab1.TabIndex = 0;
            // 
            // CSATabControl
            // 
            CSATabControl.Controls.Add(CSATabPage);
            CSATabControl.Controls.Add(PCATabPage);
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
            CSATabPage.Size = new Size(863, 413);
            CSATabPage.TabIndex = 0;
            CSATabPage.Text = "Алгоритм Коэна-Сазерленда";
            CSATabPage.UseVisualStyleBackColor = true;
            // 
            // PCATabPage
            // 
            PCATabPage.Controls.Add(polygonColoringAlgorithm1);
            PCATabPage.Location = new Point(4, 24);
            PCATabPage.Name = "PCATabPage";
            PCATabPage.Padding = new Padding(3);
            PCATabPage.Size = new Size(863, 413);
            PCATabPage.TabIndex = 1;
            PCATabPage.Text = "Алгоритм закраски многоугольника";
            PCATabPage.UseVisualStyleBackColor = true;
            // 
            // polygonColoringAlgorithm1
            // 
            polygonColoringAlgorithm1.BrushSize = 2;
            polygonColoringAlgorithm1.BorderColor = Color.Black;
            polygonColoringAlgorithm1.Dock = DockStyle.Fill;
            polygonColoringAlgorithm1.FillColor = Color.Green;
            polygonColoringAlgorithm1.Location = new Point(3, 3);
            polygonColoringAlgorithm1.Name = "polygonColoringAlgorithm1";
            polygonColoringAlgorithm1.Size = new Size(857, 407);
            polygonColoringAlgorithm1.TabIndex = 0;
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
    }
}
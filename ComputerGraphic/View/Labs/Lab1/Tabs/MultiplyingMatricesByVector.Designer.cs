namespace ComputerGraphic.View.Labs.Lab1.Tabs
{
    partial class MultiplyingMatricesByVector
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
            this.matrixTextbox = new System.Windows.Forms.TextBox();
            this.nLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matrixButton = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.xTextbox = new System.Windows.Forms.TextBox();
            this.yTextbox = new System.Windows.Forms.TextBox();
            this.zTextbox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.zLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // matrixTextbox
            // 
            this.matrixTextbox.Location = new System.Drawing.Point(284, 124);
            this.matrixTextbox.Name = "matrixTextbox";
            this.matrixTextbox.Size = new System.Drawing.Size(135, 23);
            this.matrixTextbox.TabIndex = 0;
            this.matrixTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationTextbox);
            this.matrixTextbox.Leave += new System.EventHandler(this.matrixTextbox_Leave);
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(256, 127);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(22, 15);
            this.nLabel.TabIndex = 1;
            this.nLabel.Text = "n=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // matrixButton
            // 
            this.matrixButton.Location = new System.Drawing.Point(256, 159);
            this.matrixButton.Name = "matrixButton";
            this.matrixButton.Size = new System.Drawing.Size(119, 23);
            this.matrixButton.TabIndex = 4;
            this.matrixButton.Text = "Ввод матрицы";
            this.matrixButton.UseVisualStyleBackColor = true;
            this.matrixButton.Click += new System.EventHandler(this.matrixButton_Click);
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(256, 230);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(163, 23);
            this.resultButton.TabIndex = 6;
            this.resultButton.Text = "Результат";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // xTextbox
            // 
            this.xTextbox.Location = new System.Drawing.Point(256, 188);
            this.xTextbox.Name = "xTextbox";
            this.xTextbox.Size = new System.Drawing.Size(40, 23);
            this.xTextbox.TabIndex = 7;
            this.xTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationTextbox);
            // 
            // yTextbox
            // 
            this.yTextbox.Location = new System.Drawing.Point(325, 188);
            this.yTextbox.Name = "yTextbox";
            this.yTextbox.Size = new System.Drawing.Size(38, 23);
            this.yTextbox.TabIndex = 8;
            this.yTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationTextbox);
            // 
            // zTextbox
            // 
            this.zTextbox.Location = new System.Drawing.Point(397, 188);
            this.zTextbox.Name = "zTextbox";
            this.zTextbox.Size = new System.Drawing.Size(37, 23);
            this.zTextbox.TabIndex = 9;
            this.zTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationTextbox);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(236, 191);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 15);
            this.xLabel.TabIndex = 10;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(305, 191);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 15);
            this.yLabel.TabIndex = 11;
            this.yLabel.Text = "Y";
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Location = new System.Drawing.Point(377, 191);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(14, 15);
            this.zLabel.TabIndex = 12;
            this.zLabel.Text = "Z";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(325, 268);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 15);
            this.resultLabel.TabIndex = 13;
            // 
            // MultiplyingMatricesByVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.zLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.zTextbox);
            this.Controls.Add(this.yTextbox);
            this.Controls.Add(this.xTextbox);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.matrixButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.matrixTextbox);
            this.Name = "MultiplyingMatricesByVector";
            this.Size = new System.Drawing.Size(723, 528);
            this.Load += new System.EventHandler(this.MultiplyingMatricesByVector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox matrixTextbox;
        private Label nLabel;
        private Label label2;
        private Button matrixButton;
        private Button resultButton;
        private TextBox xTextbox;
        private TextBox yTextbox;
        private TextBox zTextbox;
        private Label xLabel;
        private Label yLabel;
        private Label zLabel;
        private Label resultLabel;
    }
}

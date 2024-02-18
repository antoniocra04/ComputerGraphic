namespace ComputerGraphic.View.Labs.Lab1
{
    partial class InputMatrixForm
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
            this.InputMatrixOkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputMatrixOkButton
            // 
            this.InputMatrixOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.InputMatrixOkButton.Location = new System.Drawing.Point(343, 303);
            this.InputMatrixOkButton.Name = "InputMatrixOkButton";
            this.InputMatrixOkButton.Size = new System.Drawing.Size(75, 23);
            this.InputMatrixOkButton.TabIndex = 0;
            this.InputMatrixOkButton.Text = "OK";
            this.InputMatrixOkButton.UseVisualStyleBackColor = true;
            // 
            // InputMatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputMatrixOkButton);
            this.MaximizeBox = false;
            this.Name = "InputMatrixForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод матрицы";
            this.Load += new System.EventHandler(this.InputMatrixForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Button InputMatrixOkButton;
    }
}
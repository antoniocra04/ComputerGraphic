﻿namespace ComputerGraphic.View.Labs.Lab1
{
    partial class MatrixForm
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
            OKButton = new Button();
            SuspendLayout();
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK;
            OKButton.Location = new Point(186, 104);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 0;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            // 
            // MatrixForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 258);
            Controls.Add(OKButton);
            Name = "MatrixForm";
            Text = "MatrixForm";
            ResumeLayout(false);
        }

        #endregion

        public Button OKButton;
    }
}
﻿namespace cs_learning_app
{
    partial class EnglishForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn001 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "press the letter from your keyboard";
            // 
            // Btn001
            // 
            this.Btn001.BackColor = System.Drawing.Color.Aqua;
            this.Btn001.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn001.FlatAppearance.BorderSize = 0;
            this.Btn001.Font = new System.Drawing.Font("Perpetua Titling MT", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn001.Location = new System.Drawing.Point(121, 50);
            this.Btn001.Name = "Btn001";
            this.Btn001.Size = new System.Drawing.Size(172, 223);
            this.Btn001.TabIndex = 3;
            this.Btn001.Text = "A";
            this.Btn001.UseVisualStyleBackColor = false;
            // 
            // EnglishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 344);
            this.Controls.Add(this.Btn001);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "EnglishForm";
            this.Text = "Learning App";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnglishForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn001;
    }
}


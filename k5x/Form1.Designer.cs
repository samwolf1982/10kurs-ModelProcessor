﻿namespace k5x
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flagbox = new System.Windows.Forms.RichTextBox();
            this.regBox = new System.Windows.Forms.RichTextBox();
            this.showBox = new System.Windows.Forms.RichTextBox();
            this.comandBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flagbox
            // 
            this.flagbox.Location = new System.Drawing.Point(657, 12);
            this.flagbox.Name = "flagbox";
            this.flagbox.Size = new System.Drawing.Size(35, 222);
            this.flagbox.TabIndex = 0;
            this.flagbox.Text = "";
            // 
            // regBox
            // 
            this.regBox.Location = new System.Drawing.Point(527, 12);
            this.regBox.Name = "regBox";
            this.regBox.Size = new System.Drawing.Size(124, 222);
            this.regBox.TabIndex = 1;
            this.regBox.Text = "";
            // 
            // showBox
            // 
            this.showBox.Location = new System.Drawing.Point(291, 13);
            this.showBox.Name = "showBox";
            this.showBox.Size = new System.Drawing.Size(230, 221);
            this.showBox.TabIndex = 2;
            this.showBox.Text = "";
            // 
            // comandBox
            // 
            this.comandBox.Location = new System.Drawing.Point(13, 13);
            this.comandBox.Name = "comandBox";
            this.comandBox.Size = new System.Drawing.Size(207, 221);
            this.comandBox.TabIndex = 3;
            this.comandBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "flags";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comandBox);
            this.Controls.Add(this.showBox);
            this.Controls.Add(this.regBox);
            this.Controls.Add(this.flagbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox flagbox;
        private System.Windows.Forms.RichTextBox regBox;
        private System.Windows.Forms.RichTextBox showBox;
        private System.Windows.Forms.RichTextBox comandBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

﻿namespace FietsSimGui
{
    partial class Form1
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
            this.test = new System.Windows.Forms.Label();
            this.comPortBox = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.sendText = new System.Windows.Forms.Button();
            this.receiveBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(2, 9);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(119, 50);
            this.test.TabIndex = 0;
            this.test.Text = "COM ports";
            this.test.Click += new System.EventHandler(this.label1_Click);
            // 
            // comPortBox
            // 
            this.comPortBox.FormattingEnabled = true;
            this.comPortBox.Location = new System.Drawing.Point(127, 6);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(121, 33);
            this.comPortBox.TabIndex = 1;
            this.comPortBox.Tag = "";
            // 
            // Connect
            // 
            this.Connect.AllowDrop = true;
            this.Connect.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.Location = new System.Drawing.Point(255, 6);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(124, 50);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(7, 72);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(241, 31);
            this.textBox.TabIndex = 3;
            // 
            // sendText
            // 
            this.sendText.AllowDrop = true;
            this.sendText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendText.Location = new System.Drawing.Point(255, 72);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(124, 40);
            this.sendText.TabIndex = 4;
            this.sendText.Text = "send text";
            this.sendText.UseVisualStyleBackColor = true;
            this.sendText.Click += new System.EventHandler(this.sendText_Click);
            // 
            // receiveBox
            // 
            this.receiveBox.Location = new System.Drawing.Point(385, 6);
            this.receiveBox.Multiline = true;
            this.receiveBox.Name = "receiveBox";
            this.receiveBox.ReadOnly = true;
            this.receiveBox.Size = new System.Drawing.Size(300, 106);
            this.receiveBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiveBox);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.comPortBox);
            this.Controls.Add(this.test);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test;
        private System.Windows.Forms.ComboBox comPortBox;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button sendText;
        private System.Windows.Forms.TextBox receiveBox;
        private System.Windows.Forms.Label label1;
    }
}


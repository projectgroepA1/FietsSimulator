namespace FietsSimGui
{
    partial class SimulatorViewForm
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
            this.receiveBox = new System.Windows.Forms.TextBox();
            this.sendText = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // receiveBox
            // 
            this.receiveBox.Location = new System.Drawing.Point(25, 30);
            this.receiveBox.Multiline = true;
            this.receiveBox.Name = "receiveBox";
            this.receiveBox.ReadOnly = true;
            this.receiveBox.Size = new System.Drawing.Size(372, 106);
            this.receiveBox.TabIndex = 6;
            // 
            // sendText
            // 
            this.sendText.AllowDrop = true;
            this.sendText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendText.Location = new System.Drawing.Point(273, 154);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(124, 40);
            this.sendText.TabIndex = 8;
            this.sendText.Text = "send text";
            this.sendText.UseVisualStyleBackColor = true;
            this.sendText.Click += new System.EventHandler(this.sendText_Click_1);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(25, 154);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(241, 31);
            this.textBox.TabIndex = 7;
            // 
            // SimulatorViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 503);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.receiveBox);
            this.Name = "SimulatorViewForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox receiveBox;
        private System.Windows.Forms.Button sendText;
        private System.Windows.Forms.TextBox textBox;
    }
}
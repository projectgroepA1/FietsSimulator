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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.rpmBox = new System.Windows.Forms.TextBox();
            this.distance = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.power = new System.Windows.Forms.TextBox();
            this.energy = new System.Windows.Forms.TextBox();
            this.pulse = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.actualPower = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "speed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "RPM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(273, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "Distance";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(273, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 43);
            this.button4.TabIndex = 12;
            this.button4.Text = "Time";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(273, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 43);
            this.button5.TabIndex = 13;
            this.button5.Text = "Power";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(273, 445);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 43);
            this.button6.TabIndex = 14;
            this.button6.Text = "Energy";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(273, 494);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 43);
            this.button7.TabIndex = 15;
            this.button7.Text = "Pulse";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(25, 200);
            this.speedBox.Name = "speedBox";
            this.speedBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.speedBox.Size = new System.Drawing.Size(241, 31);
            this.speedBox.TabIndex = 16;
            this.speedBox.Text = "20";
            // 
            // rpmBox
            // 
            this.rpmBox.Location = new System.Drawing.Point(25, 249);
            this.rpmBox.Name = "rpmBox";
            this.rpmBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rpmBox.Size = new System.Drawing.Size(241, 31);
            this.rpmBox.TabIndex = 17;
            this.rpmBox.Text = "100";
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(25, 298);
            this.distance.Name = "distance";
            this.distance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.distance.Size = new System.Drawing.Size(241, 31);
            this.distance.TabIndex = 18;
            this.distance.Text = "2";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(25, 347);
            this.time.Name = "time";
            this.time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.time.Size = new System.Drawing.Size(241, 31);
            this.time.TabIndex = 19;
            this.time.Text = "2:00";
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(26, 396);
            this.power.Name = "power";
            this.power.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.power.Size = new System.Drawing.Size(241, 31);
            this.power.TabIndex = 20;
            this.power.Text = "200";
            // 
            // energy
            // 
            this.energy.Location = new System.Drawing.Point(25, 445);
            this.energy.Name = "energy";
            this.energy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.energy.Size = new System.Drawing.Size(241, 31);
            this.energy.TabIndex = 21;
            this.energy.Text = "400";
            // 
            // pulse
            // 
            this.pulse.Location = new System.Drawing.Point(25, 494);
            this.pulse.Name = "pulse";
            this.pulse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pulse.Size = new System.Drawing.Size(241, 31);
            this.pulse.TabIndex = 22;
            this.pulse.Text = "0";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(273, 593);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 39);
            this.button8.TabIndex = 23;
            this.button8.Text = "random";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // actualPower
            // 
            this.actualPower.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.actualPower.Location = new System.Drawing.Point(26, 544);
            this.actualPower.Name = "actualPower";
            this.actualPower.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.actualPower.Size = new System.Drawing.Size(241, 31);
            this.actualPower.TabIndex = 24;
            this.actualPower.Text = "150";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(273, 544);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(197, 43);
            this.button9.TabIndex = 25;
            this.button9.Text = "Actual power";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // SimulatorViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 807);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.actualPower);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.pulse);
            this.Controls.Add(this.energy);
            this.Controls.Add(this.power);
            this.Controls.Add(this.time);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.rpmBox);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox speedBox;
        private System.Windows.Forms.TextBox rpmBox;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox power;
        private System.Windows.Forms.TextBox energy;
        private System.Windows.Forms.TextBox pulse;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox actualPower;
        private System.Windows.Forms.Button button9;
    }
}
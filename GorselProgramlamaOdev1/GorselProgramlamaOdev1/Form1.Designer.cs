namespace GorselProgramlamaOdev1
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
            this.tbrRed = new System.Windows.Forms.TrackBar();
            this.tbrGreen = new System.Windows.Forms.TrackBar();
            this.tbrValue = new System.Windows.Forms.TrackBar();
            this.tbrSaturation = new System.Windows.Forms.TrackBar();
            this.tbrHue = new System.Windows.Forms.TrackBar();
            this.tbrBlue = new System.Windows.Forms.TrackBar();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblSaturation = new System.Windows.Forms.Label();
            this.lblHue = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbrRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // tbrRed
            // 
            this.tbrRed.Location = new System.Drawing.Point(107, 62);
            this.tbrRed.Margin = new System.Windows.Forms.Padding(4);
            this.tbrRed.Maximum = 255;
            this.tbrRed.Name = "tbrRed";
            this.tbrRed.Size = new System.Drawing.Size(524, 56);
            this.tbrRed.TabIndex = 0;
            this.tbrRed.Scroll += new System.EventHandler(this.tbrRed_Scroll);
            this.tbrRed.ValueChanged += new System.EventHandler(this.tbrRed_ValueChanged);
            // 
            // tbrGreen
            // 
            this.tbrGreen.Location = new System.Drawing.Point(107, 137);
            this.tbrGreen.Margin = new System.Windows.Forms.Padding(4);
            this.tbrGreen.Maximum = 255;
            this.tbrGreen.Name = "tbrGreen";
            this.tbrGreen.Size = new System.Drawing.Size(524, 56);
            this.tbrGreen.TabIndex = 1;
            this.tbrGreen.Scroll += new System.EventHandler(this.tbrGreen_Scroll);
            this.tbrGreen.ValueChanged += new System.EventHandler(this.tbrGreen_ValueChanged);
            // 
            // tbrValue
            // 
            this.tbrValue.Location = new System.Drawing.Point(107, 551);
            this.tbrValue.Margin = new System.Windows.Forms.Padding(4);
            this.tbrValue.Maximum = 100;
            this.tbrValue.Name = "tbrValue";
            this.tbrValue.Size = new System.Drawing.Size(524, 56);
            this.tbrValue.TabIndex = 2;
            this.tbrValue.Scroll += new System.EventHandler(this.tbrValue_Scroll);
            this.tbrValue.ValueChanged += new System.EventHandler(this.tbrValue_ValueChanged);
            // 
            // tbrSaturation
            // 
            this.tbrSaturation.Location = new System.Drawing.Point(107, 476);
            this.tbrSaturation.Margin = new System.Windows.Forms.Padding(4);
            this.tbrSaturation.Maximum = 100;
            this.tbrSaturation.Name = "tbrSaturation";
            this.tbrSaturation.Size = new System.Drawing.Size(524, 56);
            this.tbrSaturation.TabIndex = 3;
            this.tbrSaturation.Scroll += new System.EventHandler(this.tbrSaturation_Scroll);
            this.tbrSaturation.ValueChanged += new System.EventHandler(this.tbrSaturation_ValueChanged);
            // 
            // tbrHue
            // 
            this.tbrHue.Location = new System.Drawing.Point(107, 402);
            this.tbrHue.Margin = new System.Windows.Forms.Padding(4);
            this.tbrHue.Maximum = 359;
            this.tbrHue.Name = "tbrHue";
            this.tbrHue.Size = new System.Drawing.Size(524, 56);
            this.tbrHue.TabIndex = 4;
            this.tbrHue.Scroll += new System.EventHandler(this.tbrHue_Scroll);
            this.tbrHue.ValueChanged += new System.EventHandler(this.tbrHue_ValueChanged);
            // 
            // tbrBlue
            // 
            this.tbrBlue.Location = new System.Drawing.Point(107, 211);
            this.tbrBlue.Margin = new System.Windows.Forms.Padding(4);
            this.tbrBlue.Maximum = 255;
            this.tbrBlue.Name = "tbrBlue";
            this.tbrBlue.Size = new System.Drawing.Size(524, 56);
            this.tbrBlue.TabIndex = 5;
            this.tbrBlue.Scroll += new System.EventHandler(this.tbrBlue_Scroll);
            this.tbrBlue.ValueChanged += new System.EventHandler(this.tbrBlue_ValueChanged);
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(772, 43);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(350, 545);
            this.colorPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 402);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "H";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 476);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "S";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 551);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "RGB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 355);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "HSV";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(656, 551);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(22, 24);
            this.lblValue.TabIndex = 20;
            this.lblValue.Text = "0";
            // 
            // lblSaturation
            // 
            this.lblSaturation.AutoSize = true;
            this.lblSaturation.Location = new System.Drawing.Point(654, 476);
            this.lblSaturation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaturation.Name = "lblSaturation";
            this.lblSaturation.Size = new System.Drawing.Size(22, 24);
            this.lblSaturation.TabIndex = 19;
            this.lblSaturation.Text = "0";
            // 
            // lblHue
            // 
            this.lblHue.AutoSize = true;
            this.lblHue.Location = new System.Drawing.Point(653, 402);
            this.lblHue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHue.Name = "lblHue";
            this.lblHue.Size = new System.Drawing.Size(22, 24);
            this.lblHue.TabIndex = 18;
            this.lblHue.Text = "0";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(653, 211);
            this.lblBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(22, 24);
            this.lblBlue.TabIndex = 17;
            this.lblBlue.Text = "0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(652, 137);
            this.lblGreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(22, 24);
            this.lblGreen.TabIndex = 16;
            this.lblGreen.Text = "0";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(652, 62);
            this.lblRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(22, 24);
            this.lblRed.TabIndex = 15;
            this.lblRed.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 674);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblSaturation);
            this.Controls.Add(this.lblHue);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.tbrBlue);
            this.Controls.Add(this.tbrHue);
            this.Controls.Add(this.tbrSaturation);
            this.Controls.Add(this.tbrValue);
            this.Controls.Add(this.tbrGreen);
            this.Controls.Add(this.tbrRed);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbrRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbrRed;
        private System.Windows.Forms.TrackBar tbrGreen;
        private System.Windows.Forms.TrackBar tbrValue;
        private System.Windows.Forms.TrackBar tbrSaturation;
        private System.Windows.Forms.TrackBar tbrHue;
        private System.Windows.Forms.TrackBar tbrBlue;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblSaturation;
        private System.Windows.Forms.Label lblHue;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
    }
}


namespace Arrays_GUI_Praxis
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
            this.RadCityA = new System.Windows.Forms.RadioButton();
            this.RadCityB = new System.Windows.Forms.RadioButton();
            this.RadCityC = new System.Windows.Forms.RadioButton();
            this.RadCityD = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblOutput = new System.Windows.Forms.Label();
            this.RadBR1 = new System.Windows.Forms.RadioButton();
            this.RadBR2 = new System.Windows.Forms.RadioButton();
            this.RadBR3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadCityA
            // 
            this.RadCityA.AutoSize = true;
            this.RadCityA.Checked = true;
            this.RadCityA.Location = new System.Drawing.Point(8, 30);
            this.RadCityA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadCityA.Name = "RadCityA";
            this.RadCityA.Size = new System.Drawing.Size(74, 24);
            this.RadCityA.TabIndex = 0;
            this.RadCityA.TabStop = true;
            this.RadCityA.Text = "City A";
            this.RadCityA.UseVisualStyleBackColor = true;
            this.RadCityA.CheckedChanged += new System.EventHandler(this.RadCityA_CheckedChanged);
            // 
            // RadCityB
            // 
            this.RadCityB.AutoSize = true;
            this.RadCityB.Location = new System.Drawing.Point(8, 80);
            this.RadCityB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadCityB.Name = "RadCityB";
            this.RadCityB.Size = new System.Drawing.Size(74, 24);
            this.RadCityB.TabIndex = 1;
            this.RadCityB.TabStop = true;
            this.RadCityB.Text = "City B";
            this.RadCityB.UseVisualStyleBackColor = true;
            this.RadCityB.CheckedChanged += new System.EventHandler(this.RadCityB_CheckedChanged);
            // 
            // RadCityC
            // 
            this.RadCityC.AutoSize = true;
            this.RadCityC.Location = new System.Drawing.Point(8, 139);
            this.RadCityC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadCityC.Name = "RadCityC";
            this.RadCityC.Size = new System.Drawing.Size(74, 24);
            this.RadCityC.TabIndex = 2;
            this.RadCityC.TabStop = true;
            this.RadCityC.Text = "City C";
            this.RadCityC.UseVisualStyleBackColor = true;
            this.RadCityC.CheckedChanged += new System.EventHandler(this.RadCityC_CheckedChanged);
            // 
            // RadCityD
            // 
            this.RadCityD.AutoSize = true;
            this.RadCityD.Location = new System.Drawing.Point(8, 202);
            this.RadCityD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadCityD.Name = "RadCityD";
            this.RadCityD.Size = new System.Drawing.Size(75, 24);
            this.RadCityD.TabIndex = 3;
            this.RadCityD.TabStop = true;
            this.RadCityD.Text = "City D";
            this.RadCityD.UseVisualStyleBackColor = true;
            this.RadCityD.CheckedChanged += new System.EventHandler(this.RadCityD_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadCityD);
            this.groupBox1.Controls.Add(this.RadCityC);
            this.groupBox1.Controls.Add(this.RadCityB);
            this.groupBox1.Controls.Add(this.RadCityA);
            this.groupBox1.Location = new System.Drawing.Point(71, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(214, 263);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a City";
            // 
            // LblOutput
            // 
            this.LblOutput.BackColor = System.Drawing.SystemColors.Highlight;
            this.LblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOutput.Location = new System.Drawing.Point(180, 402);
            this.LblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(282, 34);
            this.LblOutput.TabIndex = 9;
            this.LblOutput.Text = "The Rent is : ";
            this.LblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblOutput.Click += new System.EventHandler(this.LblOutput_Click);
            // 
            // RadBR1
            // 
            this.RadBR1.AutoSize = true;
            this.RadBR1.Location = new System.Drawing.Point(17, 30);
            this.RadBR1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadBR1.Name = "RadBR1";
            this.RadBR1.Size = new System.Drawing.Size(67, 24);
            this.RadBR1.TabIndex = 4;
            this.RadBR1.Text = "1 BR";
            this.RadBR1.UseVisualStyleBackColor = true;
            this.RadBR1.CheckedChanged += new System.EventHandler(this.RadBR1_CheckedChanged);
            // 
            // RadBR2
            // 
            this.RadBR2.AutoSize = true;
            this.RadBR2.Location = new System.Drawing.Point(17, 80);
            this.RadBR2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadBR2.Name = "RadBR2";
            this.RadBR2.Size = new System.Drawing.Size(76, 24);
            this.RadBR2.TabIndex = 5;
            this.RadBR2.Text = "2 BRs";
            this.RadBR2.UseVisualStyleBackColor = true;
            this.RadBR2.CheckedChanged += new System.EventHandler(this.RadBR2_CheckedChanged);
            // 
            // RadBR3
            // 
            this.RadBR3.AutoSize = true;
            this.RadBR3.Location = new System.Drawing.Point(17, 139);
            this.RadBR3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadBR3.Name = "RadBR3";
            this.RadBR3.Size = new System.Drawing.Size(76, 24);
            this.RadBR3.TabIndex = 6;
            this.RadBR3.Text = "3 BRs";
            this.RadBR3.UseVisualStyleBackColor = true;
            this.RadBR3.CheckedChanged += new System.EventHandler(this.RadBR3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadBR3);
            this.groupBox2.Controls.Add(this.RadBR1);
            this.groupBox2.Controls.Add(this.RadBR2);
            this.groupBox2.Location = new System.Drawing.Point(311, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(215, 263);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "How many bedrooms?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(214, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rent Finder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Rent Finder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadCityA;
        private System.Windows.Forms.RadioButton RadCityB;
        private System.Windows.Forms.RadioButton RadCityC;
        private System.Windows.Forms.RadioButton RadCityD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.RadioButton RadBR1;
        private System.Windows.Forms.RadioButton RadBR2;
        private System.Windows.Forms.RadioButton RadBR3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}


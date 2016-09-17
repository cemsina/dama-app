namespace damaApp
{
    partial class settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startLocY = new System.Windows.Forms.TextBox();
            this.startLocX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.betaColorSelect = new System.Windows.Forms.Button();
            this.alphaColorSelect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alphaColorText = new System.Windows.Forms.Label();
            this.betaColorText = new System.Windows.Forms.Label();
            this.Others = new System.Windows.Forms.GroupBox();
            this.unitSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.alphaColor = new System.Windows.Forms.ColorDialog();
            this.betaColor = new System.Windows.Forms.ColorDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lineColorSelect = new System.Windows.Forms.Button();
            this.lineWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lineColorText = new System.Windows.Forms.Label();
            this.lineColor = new System.Windows.Forms.ColorDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.turnTextY = new System.Windows.Forms.TextBox();
            this.turnTextX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Others.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startLocY);
            this.groupBox1.Controls.Add(this.startLocX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Location";
            // 
            // startLocY
            // 
            this.startLocY.Location = new System.Drawing.Point(49, 59);
            this.startLocY.Name = "startLocY";
            this.startLocY.Size = new System.Drawing.Size(56, 20);
            this.startLocY.TabIndex = 3;
            // 
            // startLocX
            // 
            this.startLocX.Location = new System.Drawing.Point(49, 24);
            this.startLocX.Name = "startLocX";
            this.startLocX.Size = new System.Drawing.Size(56, 20);
            this.startLocX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.betaColorSelect);
            this.groupBox2.Controls.Add(this.alphaColorSelect);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.alphaColorText);
            this.groupBox2.Controls.Add(this.betaColorText);
            this.groupBox2.Location = new System.Drawing.Point(145, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // betaColorSelect
            // 
            this.betaColorSelect.Location = new System.Drawing.Point(177, 52);
            this.betaColorSelect.Name = "betaColorSelect";
            this.betaColorSelect.Size = new System.Drawing.Size(32, 23);
            this.betaColorSelect.TabIndex = 5;
            this.betaColorSelect.Text = "...";
            this.betaColorSelect.UseVisualStyleBackColor = true;
            this.betaColorSelect.Click += new System.EventHandler(this.betaColorSelect_Click);
            // 
            // alphaColorSelect
            // 
            this.alphaColorSelect.Location = new System.Drawing.Point(177, 24);
            this.alphaColorSelect.Name = "alphaColorSelect";
            this.alphaColorSelect.Size = new System.Drawing.Size(32, 23);
            this.alphaColorSelect.TabIndex = 4;
            this.alphaColorSelect.Text = "...";
            this.alphaColorSelect.UseVisualStyleBackColor = true;
            this.alphaColorSelect.Click += new System.EventHandler(this.alphaColorSelect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Beta Team : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alpha Team : ";
            // 
            // alphaColorText
            // 
            this.alphaColorText.AutoSize = true;
            this.alphaColorText.Location = new System.Drawing.Point(93, 29);
            this.alphaColorText.Name = "alphaColorText";
            this.alphaColorText.Size = new System.Drawing.Size(35, 13);
            this.alphaColorText.TabIndex = 2;
            this.alphaColorText.Text = "label6";
            // 
            // betaColorText
            // 
            this.betaColorText.AutoSize = true;
            this.betaColorText.Location = new System.Drawing.Point(93, 59);
            this.betaColorText.Name = "betaColorText";
            this.betaColorText.Size = new System.Drawing.Size(35, 13);
            this.betaColorText.TabIndex = 3;
            this.betaColorText.Text = "label6";
            // 
            // Others
            // 
            this.Others.Controls.Add(this.unitSize);
            this.Others.Controls.Add(this.label5);
            this.Others.Location = new System.Drawing.Point(12, 113);
            this.Others.Name = "Others";
            this.Others.Size = new System.Drawing.Size(127, 75);
            this.Others.TabIndex = 2;
            this.Others.TabStop = false;
            this.Others.Text = "Others";
            // 
            // unitSize
            // 
            this.unitSize.Location = new System.Drawing.Point(70, 24);
            this.unitSize.Name = "unitSize";
            this.unitSize.Size = new System.Drawing.Size(53, 20);
            this.unitSize.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Unit Size : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alphaColor
            // 
            this.alphaColor.Color = System.Drawing.Color.Red;
            // 
            // betaColor
            // 
            this.betaColor.Color = System.Drawing.Color.Blue;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lineColorSelect);
            this.groupBox3.Controls.Add(this.lineWidth);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lineColorText);
            this.groupBox3.Location = new System.Drawing.Point(145, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 75);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Table";
            // 
            // lineColorSelect
            // 
            this.lineColorSelect.Location = new System.Drawing.Point(177, 41);
            this.lineColorSelect.Name = "lineColorSelect";
            this.lineColorSelect.Size = new System.Drawing.Size(32, 23);
            this.lineColorSelect.TabIndex = 6;
            this.lineColorSelect.Text = "...";
            this.lineColorSelect.UseVisualStyleBackColor = true;
            this.lineColorSelect.Click += new System.EventHandler(this.lineColorSelect_Click);
            // 
            // lineWidth
            // 
            this.lineWidth.Location = new System.Drawing.Point(84, 13);
            this.lineWidth.Name = "lineWidth";
            this.lineWidth.Size = new System.Drawing.Size(60, 20);
            this.lineWidth.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Line Color : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Line Width : ";
            // 
            // lineColorText
            // 
            this.lineColorText.AutoSize = true;
            this.lineColorText.Location = new System.Drawing.Point(81, 46);
            this.lineColorText.Name = "lineColorText";
            this.lineColorText.Size = new System.Drawing.Size(35, 13);
            this.lineColorText.TabIndex = 7;
            this.lineColorText.Text = "label6";
            // 
            // lineColor
            // 
            this.lineColor.Color = System.Drawing.Color.Blue;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.turnTextY);
            this.groupBox4.Controls.Add(this.turnTextX);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 95);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Turn Text Position";
            // 
            // turnTextY
            // 
            this.turnTextY.Location = new System.Drawing.Point(49, 59);
            this.turnTextY.Name = "turnTextY";
            this.turnTextY.Size = new System.Drawing.Size(56, 20);
            this.turnTextY.TabIndex = 3;
            // 
            // turnTextX
            // 
            this.turnTextX.Location = new System.Drawing.Point(49, 24);
            this.turnTextX.Name = "turnTextX";
            this.turnTextX.Size = new System.Drawing.Size(56, 20);
            this.turnTextX.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Y : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "X : ";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 301);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Others);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settings";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Others.ResumeLayout(false);
            this.Others.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox startLocY;
        private System.Windows.Forms.TextBox startLocX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Others;
        private System.Windows.Forms.TextBox unitSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label betaColorText;
        private System.Windows.Forms.Label alphaColorText;
        private System.Windows.Forms.ColorDialog alphaColor;
        private System.Windows.Forms.ColorDialog betaColor;
        private System.Windows.Forms.Button betaColorSelect;
        private System.Windows.Forms.Button alphaColorSelect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lineColorText;
        private System.Windows.Forms.ColorDialog lineColor;
        private System.Windows.Forms.Button lineColorSelect;
        private System.Windows.Forms.TextBox lineWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox turnTextY;
        private System.Windows.Forms.TextBox turnTextX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
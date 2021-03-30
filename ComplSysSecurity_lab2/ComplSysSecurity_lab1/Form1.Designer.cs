namespace ComplSysSecurity_lab1
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
            this.originalTXT = new System.Windows.Forms.TextBox();
            this.decodedTXT = new System.Windows.Forms.TextBox();
            this.codedTXT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.keyTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // originalTXT
            // 
            this.originalTXT.Location = new System.Drawing.Point(55, 34);
            this.originalTXT.Multiline = true;
            this.originalTXT.Name = "originalTXT";
            this.originalTXT.Size = new System.Drawing.Size(222, 549);
            this.originalTXT.TabIndex = 0;
            // 
            // decodedTXT
            // 
            this.decodedTXT.Location = new System.Drawing.Point(505, 34);
            this.decodedTXT.Multiline = true;
            this.decodedTXT.Name = "decodedTXT";
            this.decodedTXT.Size = new System.Drawing.Size(210, 549);
            this.decodedTXT.TabIndex = 1;
            // 
            // codedTXT
            // 
            this.codedTXT.Location = new System.Drawing.Point(283, 34);
            this.codedTXT.Multiline = true;
            this.codedTXT.Name = "codedTXT";
            this.codedTXT.Size = new System.Drawing.Size(216, 549);
            this.codedTXT.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(993, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Decode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Coded Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Decoded Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Key";
            // 
            // keyTXT
            // 
            this.keyTXT.Location = new System.Drawing.Point(804, 28);
            this.keyTXT.Name = "keyTXT";
            this.keyTXT.Size = new System.Drawing.Size(391, 26);
            this.keyTXT.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 653);
            this.Controls.Add(this.keyTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.codedTXT);
            this.Controls.Add(this.decodedTXT);
            this.Controls.Add(this.originalTXT);
            this.Name = "Form1";
            this.Text = "Lab 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originalTXT;
        private System.Windows.Forms.TextBox decodedTXT;
        private System.Windows.Forms.TextBox codedTXT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keyTXT;
    }
}


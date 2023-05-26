namespace WindowsFormsApp1
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.CountButton = new System.Windows.Forms.Button();
            this.PrimeButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.number1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CalculateButton.ForeColor = System.Drawing.Color.Black;
            this.CalculateButton.Location = new System.Drawing.Point(57, 44);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(127, 60);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Factorial";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CountButton
            // 
            this.CountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CountButton.Location = new System.Drawing.Point(57, 301);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(127, 63);
            this.CountButton.TabIndex = 1;
            this.CountButton.Text = "Count";
            this.CountButton.UseVisualStyleBackColor = false;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // PrimeButton
            // 
            this.PrimeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PrimeButton.Location = new System.Drawing.Point(57, 175);
            this.PrimeButton.Name = "PrimeButton";
            this.PrimeButton.Size = new System.Drawing.Size(127, 56);
            this.PrimeButton.TabIndex = 2;
            this.PrimeButton.Text = "Is prime?";
            this.PrimeButton.UseVisualStyleBackColor = false;
            this.PrimeButton.Click += new System.EventHandler(this.PrimeButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(333, 195);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(96, 27);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result";
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(278, 44);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(192, 22);
            this.number1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter a number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.PrimeButton);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.Button PrimeButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.Label label1;
    }
}


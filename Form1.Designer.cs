namespace TemperatureConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.CelsToFehr = new System.Windows.Forms.Button();
            this.FehrToCels = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CelsiumTextBox = new System.Windows.Forms.TextBox();
            this.FahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsium";
            // 
            // CelsToFehr
            // 
            this.CelsToFehr.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CelsToFehr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsToFehr.Location = new System.Drawing.Point(365, 175);
            this.CelsToFehr.Name = "CelsToFehr";
            this.CelsToFehr.Size = new System.Drawing.Size(110, 60);
            this.CelsToFehr.TabIndex = 1;
            this.CelsToFehr.Text = "Convert";
            this.CelsToFehr.UseVisualStyleBackColor = false;
            this.CelsToFehr.Click += new System.EventHandler(this.CelsToFehr_Click);
            // 
            // FehrToCels
            // 
            this.FehrToCels.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.FehrToCels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FehrToCels.Location = new System.Drawing.Point(98, 175);
            this.FehrToCels.Name = "FehrToCels";
            this.FehrToCels.Size = new System.Drawing.Size(110, 59);
            this.FehrToCels.TabIndex = 2;
            this.FehrToCels.Text = "Convert";
            this.FehrToCels.UseVisualStyleBackColor = false;
            this.FehrToCels.Click += new System.EventHandler(this.FehrToCels_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fahrenheit";
            // 
            // CelsiumTextBox
            // 
            this.CelsiumTextBox.Location = new System.Drawing.Point(335, 120);
            this.CelsiumTextBox.Name = "CelsiumTextBox";
            this.CelsiumTextBox.Size = new System.Drawing.Size(180, 22);
            this.CelsiumTextBox.TabIndex = 4;
            // 
            // FahrenheitTextBox
            // 
            this.FahrenheitTextBox.Location = new System.Drawing.Point(68, 120);
            this.FahrenheitTextBox.Name = "FahrenheitTextBox";
            this.FahrenheitTextBox.Size = new System.Drawing.Size(180, 22);
            this.FahrenheitTextBox.TabIndex = 5;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(236, 280);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(149, 36);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.FahrenheitTextBox);
            this.Controls.Add(this.CelsiumTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FehrToCels);
            this.Controls.Add(this.CelsToFehr);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Temperature Conversion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CelsToFehr;
        private System.Windows.Forms.Button FehrToCels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CelsiumTextBox;
        private System.Windows.Forms.TextBox FahrenheitTextBox;
        private System.Windows.Forms.Button ExitBtn;
    }
}
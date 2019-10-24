namespace _1MajasDarbs
{
    partial class RandomNumberGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.buttonGenerateRandomNumber = new System.Windows.Forms.Button();
            this.labelRandomNumber = new System.Windows.Forms.Label();
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFrom.Location = new System.Drawing.Point(51, 54);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(94, 39);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "From";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFrom.Location = new System.Drawing.Point(151, 54);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(125, 45);
            this.textBoxFrom.TabIndex = 0;
            this.textBoxFrom.Leave += new System.EventHandler(this.textBoxFrom_TextChanged);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTo.Location = new System.Drawing.Point(344, 54);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(52, 39);
            this.labelTo.TabIndex = 0;
            this.labelTo.Text = "To";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTo.Location = new System.Drawing.Point(402, 54);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(125, 45);
            this.textBoxTo.TabIndex = 1;
            this.textBoxTo.Leave += new System.EventHandler(this.textBoxTo_TextChanged);
            // 
            // buttonGenerateRandomNumber
            // 
            this.buttonGenerateRandomNumber.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerateRandomNumber.Location = new System.Drawing.Point(51, 174);
            this.buttonGenerateRandomNumber.Name = "buttonGenerateRandomNumber";
            this.buttonGenerateRandomNumber.Size = new System.Drawing.Size(476, 59);
            this.buttonGenerateRandomNumber.TabIndex = 2;
            this.buttonGenerateRandomNumber.Text = "Generate Random Number";
            this.buttonGenerateRandomNumber.UseVisualStyleBackColor = true;
            this.buttonGenerateRandomNumber.Click += new System.EventHandler(this.buttonGenerateRandomNumber_Click);
            // 
            // labelRandomNumber
            // 
            this.labelRandomNumber.AutoSize = true;
            this.labelRandomNumber.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRandomNumber.Location = new System.Drawing.Point(240, 296);
            this.labelRandomNumber.Name = "labelRandomNumber";
            this.labelRandomNumber.Size = new System.Drawing.Size(35, 38);
            this.labelRandomNumber.TabIndex = 3;
            this.labelRandomNumber.Text = "0";
            // 
            // RandomNumberGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.labelRandomNumber);
            this.Controls.Add(this.buttonGenerateRandomNumber);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.textBoxTo);
            this.Name = "RandomNumberGenerator";
            this.Text = "Random Number Generator";

        }

        #endregion

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button buttonGenerateRandomNumber;
        private System.Windows.Forms.Label labelRandomNumber;
    }
}


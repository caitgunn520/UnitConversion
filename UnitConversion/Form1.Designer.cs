namespace UnitConversion
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructLabel = new System.Windows.Forms.Label();
            this.convertLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.convertInput = new System.Windows.Forms.TextBox();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(168, 68);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(246, 33);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Linear Conversion";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // instructLabel
            // 
            this.instructLabel.Location = new System.Drawing.Point(169, 118);
            this.instructLabel.Name = "instructLabel";
            this.instructLabel.Size = new System.Drawing.Size(245, 106);
            this.instructLabel.TabIndex = 1;
            this.instructLabel.Text = "1. Inches to Centimetres\r\n\r\n2. Feet to Centimetres\r\n\r\n3. Yards to Metres\r\n\r\n4. Mi" +
    "les to Kilometres";
            // 
            // convertLabel
            // 
            this.convertLabel.Location = new System.Drawing.Point(156, 248);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(164, 23);
            this.convertLabel.TabIndex = 2;
            this.convertLabel.Text = "Enter conversion choice (1-4):";
            // 
            // valueLabel
            // 
            this.valueLabel.Location = new System.Drawing.Point(156, 290);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(164, 23);
            this.valueLabel.TabIndex = 3;
            this.valueLabel.Text = "Enter value to be converted:";
            // 
            // convertInput
            // 
            this.convertInput.Location = new System.Drawing.Point(326, 248);
            this.convertInput.Name = "convertInput";
            this.convertInput.Size = new System.Drawing.Size(100, 20);
            this.convertInput.TabIndex = 4;
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(326, 287);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(100, 20);
            this.valueInput.TabIndex = 5;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(170, 333);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(242, 32);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(169, 389);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(243, 23);
            this.outputLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.convertInput);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.convertLabel);
            this.Controls.Add(this.instructLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Unit Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructLabel;
        private System.Windows.Forms.Label convertLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox convertInput;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputLabel;
    }
}


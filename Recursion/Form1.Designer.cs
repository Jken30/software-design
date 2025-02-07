namespace Recursion
{
    partial class Form1
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
            btnCalculateSum = new Button();
            txtArrayInput = new TextBox();
            lblSumResult = new Label();
            CalculateSum = new Button();
            SuspendLayout();
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(51, 91);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(112, 23);
            btnCalculateSum.TabIndex = 0;
            btnCalculateSum.Text = "Calculate Factorial";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(235, 91);
            txtArrayInput.Multiline = true;
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(186, 235);
            txtArrayInput.TabIndex = 1;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(233, 67);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(7, 15);
            lblSumResult.TabIndex = 2;
            lblSumResult.Text = "\r\n";
            // 
            // CalculateSum
            // 
            CalculateSum.Location = new Point(51, 143);
            CalculateSum.Name = "CalculateSum";
            CalculateSum.Size = new Size(112, 23);
            CalculateSum.TabIndex = 3;
            CalculateSum.Text = "Calculate Sum";
            CalculateSum.UseVisualStyleBackColor = true;
            CalculateSum.Click += CalculateSum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 382);
            Controls.Add(CalculateSum);
            Controls.Add(lblSumResult);
            Controls.Add(txtArrayInput);
            Controls.Add(btnCalculateSum);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculateSum;
        private TextBox txtArrayInput;
        private Label lblSumResult;
        private Button CalculateSum;
    }
}

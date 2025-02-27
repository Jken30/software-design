namespace lab6
{
    partial class add
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
            label1 = new Label();
            label2 = new Label();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 54);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 101);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(119, 54);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(134, 23);
            txtAuthorName.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(119, 98);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(134, 23);
            txtBookTitle.TabIndex = 3;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(152, 145);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 189);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "add";
            Text = "add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
    }
}
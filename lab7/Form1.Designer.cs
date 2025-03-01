namespace lab7
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
            lblPageNumber = new Label();
            btnNextPage = new Button();
            btnPreviousPage = new Button();
            listBoxBooks = new ListBox();
            addbook = new Button();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnExportBooks = new Button();
            SuspendLayout();
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(12, 9);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(38, 15);
            lblPageNumber.TabIndex = 0;
            lblPageNumber.Text = "label1";
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(12, 168);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(75, 23);
            btnNextPage.TabIndex = 1;
            btnNextPage.Text = "Next Page";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(116, 168);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(75, 23);
            btnPreviousPage.TabIndex = 2;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(12, 38);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(179, 94);
            listBoxBooks.TabIndex = 3;
            // 
            // addbook
            // 
            addbook.Location = new Point(247, 37);
            addbook.Name = "addbook";
            addbook.Size = new Size(75, 23);
            addbook.TabIndex = 4;
            addbook.Text = "Add";
            addbook.UseVisualStyleBackColor = true;
            addbook.Click += addbook_Click;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(379, 38);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(100, 23);
            txtAuthorName.TabIndex = 5;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(379, 82);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(100, 23);
            txtBookTitle.TabIndex = 6;
            // 
            // btnExportBooks
            // 
            btnExportBooks.Location = new Point(12, 210);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(75, 23);
            btnExportBooks.TabIndex = 7;
            btnExportBooks.Text = "Export";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 247);
            Controls.Add(btnExportBooks);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(addbook);
            Controls.Add(listBoxBooks);
            Controls.Add(btnPreviousPage);
            Controls.Add(btnNextPage);
            Controls.Add(lblPageNumber);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageNumber;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private ListBox listBoxBooks;
        private Button addbook;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnExportBooks;
    }
}

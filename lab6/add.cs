using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        public async Task SaveBookAsync(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);


                await context.SaveChangesAsync();

            }
        }

        private async void add_Load(object sender, EventArgs e)
        {

            var authorname = txtAuthorName.Text;
            var booktitle = txtBookTitle.Text;

            await SaveBookAsync(authorname, booktitle);

            MessageBox.Show("Books and Author added successfully");

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

        }
    }
}

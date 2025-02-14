using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class Author
        {

            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }



        }


        public class Book
        {

            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }


        }

        public void AddAuthorsWithBook(string authorName, string bookTitle)
        {

            using (var context = new BookstoreContext())
            {

                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();

                return booksWithAuthors;
            }

        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {

            var books = GetBooksWithAuthors();
            listBoxBooks.DataSource = books;
        }


        public void UpdateBookAndAuthor(int BookId, string newTitle, string newAuthorName)
        {

            using (var context = new BookstoreContext())
            {

                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == BookId);

                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    context.SaveChanges();
                }

            }


        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {

            int bookId = int.Parse(txtBookID.Text);
            UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Books and Author updated successfully");
        }
    }

}

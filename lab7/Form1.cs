using Microsoft.EntityFrameworkCore;


namespace lab7


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private const int pageSize = 10;
        private int currentPage = 1;


        public async Task<List<string>> GetBooksAsync(int page)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                    .Include(book => book.Author)
                    .OrderBy(b => b.BookId)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();


                return books;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {

            currentPage++;
            var books = await GetBooksAsync(currentPage);
            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";
        }


        public async Task SaveBookAsync(string authorName, string bookTitle)
        {

            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };

                    context.Authors.Add(author);
                    context.Books.Add(book);


                    await context.SaveChangesAsync();

                    MessageBox.Show("Books and Author added successfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
            }
        }

        private async void addbook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookAsync(authorName, bookTitle);
        }


        public async Task ExportingBooksAsync(string filepath)
        {
            var books = await GetBooksAsync(currentPage);

            using (StreamWriter writer = new StreamWriter(filepath))
            {
                foreach (var book in books)
                {
                    await writer.WriteLineAsync(book);
                }
            }


        }

        private async void btnExportBooks_Click(object sender, EventArgs e)
        {

            var saveFileDialog = new SaveFileDialog
            {

                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Save Book List"

            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;
                await ExportingBooksAsync(filepath);
                MessageBox.Show("Books exported successfully");
            }

        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {

        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async Task<List<string>> GetBooksAsync()
        {

            using (var context = new BookstoreContext())
            {
                var books = await context.Books.Include(b => b.Author)
                                               .Select(b => $"{b.Title} by {b.Author.Name}")
                                               .ToListAsync();

                return books;
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {

            var books = await GetBooksAsync();

            listBoxBooks.DataSource = books;

        }
    }
}

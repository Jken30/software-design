using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }


        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author}, Issue {IssueNumber}";
            }
        }


        public class Textbook : Book
        {
            public string Subject { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author}, Subject: {Subject}";
            }
        }


        public class AudioBook : Book
        {
            public double Duration { get; set; }
            public string Narrator { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author}, Duration: {Duration} hours, Narrator: {Narrator}";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void ShowInfo_Click(object sender, EventArgs e)
        {

            Book[] books = new Book[]
            {
                new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 },
                new Textbook { Title = "C# Basic", Author = "Jane Smith", Subject = "Programming" },
                new AudioBook { Title = "Stracture of Java", Author = "Alice Johnson", Duration = 12.5, Narrator = "David Lee" }
            };

            string allBookinfo = "";

            foreach (var book in books)
            {
                allBookinfo += book.GetInfo() + "\n";
            }

            MessageBox.Show(allBookinfo);
        }
    }
}

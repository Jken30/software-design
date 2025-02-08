using System.Reflection;

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


        private void Form1_Load(object sender, EventArgs e)
        {

        }








        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author}, Issue {IssueNumber}";
            }
        }





















        private void ShowInfo_Click(object sender, EventArgs e)
        {

            Book mybook = new Magazine {
                Title = "Teck Weekly",
                Author = "John Doe", IssueNumber = 45

            };

            MessageBox.Show(mybook.GetInfo());
        }
    }
}

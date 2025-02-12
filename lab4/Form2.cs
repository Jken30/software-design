using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab4
{

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
            return $"{Title} by {Author} - Issue {IssueNumber}";
        }
    }

    
    public class Ebook : Book
    {
        public int FileSizeMB { get; set; }

        public override string GetInfo()
        {
            return $"{Title} by {Author} - {FileSizeMB}MB";
        }
    }
    [TestClass]

    public class polymorphsimTests
    {
        [TestMethod]
        public void TestPolymorphism_GetInfo_Method() {


            Book[] books = new Book[]
            {

                new Book { Title = "Generic Book", Author = "John Smith" },
                new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 },
                new Ebook { Title = "Learn C#", Author = "Mark Jones", FileSizeMB = 5 }


            };

            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly by Jane Doe - Issue 12", books[1].GetInfo());
            Assert.AreEqual("Learn C# by Mark Jones - 5MB", books[2].GetInfo());

        }

    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



    }
}

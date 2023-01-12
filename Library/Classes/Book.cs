using System.ComponentModel;
using System.Xml.Linq;

namespace Library
{
    [Serializable]
    public class Book
    {
        // Fields

        private string title;
        private string author;
        private BookGenre genre;
        private string publicationDate;
        private string pages;
        private string isbn13;
        private string description;
        private List<Loan> loanHistory;

        public enum BookGenre
        {
            Fantasy,
            Fiction,
            Horror,
            Thriller,
            Romance,
            Adventure,
            Children,
            Education,
            History,
            Poetry
        }

        // Constructor

        public Book(string title, string author, BookGenre genre, string publicationDate, string pages, string isbn13, string description)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.publicationDate = publicationDate;
            this.pages = pages;
            this.isbn13 = isbn13;
            this.description = description;
            loanHistory = new List<Loan>();
        }

        // Parameterless constructor - required for XML Serialization

        private Book() { }

        // Properties - get and set

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public BookGenre Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        [DisplayName("Publication date")]
        public string PublicationDate
        {
            get { return publicationDate; }
            set { publicationDate = value; }
        }

        public string Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        [DisplayName("ISBN-13")]
        public string Isbn13
        {
            get { return isbn13; }
            set { isbn13 = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public List<Loan> LoanHistory
        {
            get { return loanHistory; }
            set { loanHistory = value; }
        }

        // Method that checks for duplicates, adds the book object to the list of books and serializes it

        public void AddBook(Book newBook, string isbn13, string title)
        {
            // Check if book with the same ISBN-13 already exists

            foreach (Book bookObj in Library.Books)
            {
                if (bookObj.isbn13 == isbn13)
                {
                    MessageBox.Show($"A book with the same ISBN13 already exists!" +
                        $"\n\nThat book is:\n{bookObj}\nISBN-13: {bookObj.isbn13}");

                    return;
                }
            }

            // Check if book with the same name already exists

            foreach (Book bookObj in Library.Books)
            {
                if (bookObj.Title.ToLower() == title.ToLower())
                {
                    DialogResult dialogResult = MessageBox.Show($"The book '{bookObj}' already exists!" +
                        $"\n\nAre you sure you want to add this book?", "Add book", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Library.Books.Add(newBook);

            Library.SerializeListToXML("books.xml", Library.Books);
        }

        // Method that removes the book object from the list of books and serializes it

        public void RemoveBook(Book book)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove '"
                + book + "' ?", "Remove book", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Library.Books.Remove(book);

                Library.SerializeListToXML("books.xml", Library.Books);
            }
        }

        // Method to get the current borrower of a book - returns null if book is not currently loaned to anybody

        public Member? GetBorrower()
        {
            foreach (Loan loan in LoanHistory)
            {
                if (loan.ReturnDate == null)
                {
                    return loan.Borrower;
                }
            }
            return null;
        }

        // Overrides the ToString() method to return the Title of the book object

        public override string ToString()
        {
            return Title;
        }
    }
}
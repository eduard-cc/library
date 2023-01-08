using System.ComponentModel;
using System.Xml.Linq;

namespace Library
{
    public class Loan
    {
        // Fields

        private Member borrower;
        private string borrowDate;
        private string returnDate;

        // Constructor

        public Loan(Member borrower, string borrowDate, string returnDate)
        {
            this.borrower = borrower;
            this.borrowDate = borrowDate;
            this.returnDate = returnDate;
        }

        // Parameterless constructor - required for XML Serialization

        public Loan() { }

        // Properties - get and set

        public Member Borrower
        {
            get { return borrower; }
            set { borrower = value; }
        }

        [DisplayName("Borrow date")]
        public string BorrowDate
        {
            get { return borrowDate; }
            set { borrowDate = value; }
        }

        [DisplayName("Return date")]
        public string ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        // Method that adds the loan object to the list of loans of the book object

        public void LoanBook(Loan loan, Book currentBook)
        {
            currentBook.LoanHistory.Add(loan);

            Library.SerializeListToXML("books.xml", Library.Books);
        }


        // Method that updates the return date of a book

        public static void ReturnBook(Book currentBook, string returnDate)
        {
            foreach (Loan loan in currentBook.LoanHistory)
            {
                if (loan.ReturnDate == null)
                {
                    loan.ReturnDate = returnDate;

                    Library.SerializeListToXML("books.xml", Library.Books);
                }
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public partial class Form_Library : Form
    {
        public Form_Library()
        {
            InitializeComponent();
            GetData(Library.Books);

            // Getting enum values in comboBox

            foreach (var genre in Enum.GetValues(typeof(Book.BookGenre)))
            {
                comboBoxGenre.Items.Add(genre);
            }
        }

        // Method to bind list of books to dataGridView - returns binding source

        public BindingSource GetData(List<Book> books)
        {
            BindingSource source = new BindingSource();

            source.DataSource = books;
            dataGridViewBooks.DataSource = source;
            return source;
        }

        // View all books

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            GetData(Library.Books);
        }

        // Open add book form

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Form_Add_Book form = new Form_Add_Book(this);
            form.Show();
        }

        // Open loan and return form

        private void btnLoanReturn_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.CurrentRow != null)
            {
                // Get the selected book object
                Book book = (Book)dataGridViewBooks.CurrentRow.DataBoundItem;

                Form_Loan form = new Form_Loan(book);
                form.Show();
            }
            else
            {
                MessageBox.Show("Select a book!");
            }
        }

        // Open members form

        private void btnMembers_Click(object sender, EventArgs e)
        {
            Form_Members form = new Form_Members();
            form.Show();
        }

        // Remove book

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.CurrentRow != null)
            {
                // Get the selected book object
                Book book = (Book)dataGridViewBooks.CurrentRow.DataBoundItem;

                book.RemoveBook(book);

                GetData(Library.Books).ResetBindings(false);
                MessageBox.Show("Book removed!");
            }
            else
            {
                MessageBox.Show("Select a book!");
            }
        }

        // Search for books based on filters

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Initialize variables from inputs

            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            Book.BookGenre genre = (Book.BookGenre)comboBoxGenre.SelectedIndex;

            if (String.IsNullOrEmpty(title) && 
                String.IsNullOrEmpty(author) && 
                comboBoxGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Enter search filters!");
                return;
            }

            // Updates dataGridView with the list of found books

            GetData(Library.Search(title, author, genre)).ResetBindings(false);

            if (dataGridViewBooks.Rows.Count == 0)
            {
                MessageBox.Show("No books found!");
            }
        }
    }
}
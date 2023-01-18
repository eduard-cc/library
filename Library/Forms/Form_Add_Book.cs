namespace Library
{
    public partial class Form_Add_Book : Form
    {
        private Form_Library mainForm;

        public Form_Add_Book(Form_Library mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();

            // Getting enum values in comboBox

            foreach (var genre in Enum.GetValues(typeof(Book.BookGenre)))
            {
                comboBoxGenre.Items.Add(genre);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Add new book

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Initialize variables from inputs

            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            Book.BookGenre genre = (Book.BookGenre)comboBoxGenre.SelectedIndex;
            string publicationDate = datePicker.Value.Date.ToString("d MMMM yyyy");
            string pages = textBoxPages.Text;
            string isbn13 = textBoxISBN13.Text;
            string description = richTextBoxDescription.Text;

            // Check for empty or invalid inputs

            if (String.IsNullOrEmpty(title))
            {
                MessageBox.Show("Title cannot be empty");
            }
            else if (String.IsNullOrEmpty(author))
            {
                MessageBox.Show("Author cannot be empty");
            }
            else if (String.IsNullOrEmpty(isbn13))
            {
                MessageBox.Show("ISBN13 cannot be empty");
            }
            else if (comboBoxGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a genre");
            }
            else if (!isbn13.All(char.IsDigit))
            {
                MessageBox.Show("ISBN13 must be a numeric value");
            }
            else if (isbn13.Length != 13)
            {
                MessageBox.Show("ISBN13 must be 13 digits");
            }
            else if (!pages.All(char.IsDigit))
            {
                MessageBox.Show("Pages must be a numeric value");
            }
            else
            {
                // Create new book object
                Book newBook = new Book(title, author, genre, publicationDate, pages, isbn13, description);

                DialogResult dialogResult = newBook.AddBook(newBook, isbn13, title);

                if (dialogResult == DialogResult.Yes)
                {
                    // Updates dataGridView in Form_Library
                    mainForm.GetData(Library.Books).ResetBindings(false);
                    MessageBox.Show("Book added!");
                }
            }
        }
    }
}
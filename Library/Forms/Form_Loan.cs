using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
namespace Library
{
    public partial class Form_Loan : Form
    {
        private Book currentBook;

        public Form_Loan(Book currentBook)
        {
            this.currentBook = currentBook;

            InitializeComponent();
            GetData();

            // Inserting current book object data into labels

            lblTitle.Text = currentBook.Title;
            lblAuthor.Text = currentBook.Author;
            lblGenre.Text = currentBook.Genre.ToString();
            lblPublicationDate.Text = currentBook.PublicationDate;
            lblIsbn13.Text = currentBook.Isbn13;
            lblPages.Text = currentBook.Pages;
            lblDescription.Text = currentBook.Description;

            // Inserting current borrower into labels

            if (currentBook.GetBorrower() == null)
            {
                lblCurrentBorrower.Text = lblCurrentBorrower2.Text = "Nobody!";
                btnReturn.Enabled = false;
            }
            else
            {
                lblCurrentBorrower.Text = lblCurrentBorrower2.Text = lblCurrentBorrower3.Text = currentBook.GetBorrower().GetInfo();
                btnLoan.Enabled = false;
                lblReturnFrom.Visible = lblCurrentBorrower2.Visible = true;
                lblBorrowedBy.Visible = lblCurrentBorrower3.Visible = true;
            }

            // Getting members in comboBox

            foreach (Member member in Library.Members)
            {
                comboBoxMembers.Items.Add(member);
            }
        }

        // Method to bind list of books to dataGridView - returns binding source

        public BindingSource GetData()
        {
            BindingSource source = new BindingSource();

            source.DataSource = currentBook.LoanHistory;
            dataGridViewHistory.DataSource = source;
            return source;
        }

        // Find a Member by ID

        private void btnFindID_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxMemberId.Text))
            {
                MessageBox.Show("Enter an ID!");
            }
            else
            {
                foreach (Member member in Library.Members)
                {
                    if (member.Id == textBoxMemberId.Text)
                    {
                        comboBoxMembers.SelectedItem = member;

                        MessageBox.Show($"Member found: {member}");
                        return;
                    }
                }
                textBoxMemberId.Clear();
                comboBoxMembers.SelectedIndex = -1;

                MessageBox.Show("Member not found. This ID does not exist!");
            }
        }

        // Loan the current book

        private void btnLoan_Click(object sender, EventArgs e)
        {
            // Initialize variables from inputs

            Member member = (Member)comboBoxMembers.SelectedItem;
            string member_id = textBoxMemberId.Text;
            string borrowDate = datePickerLoan.Value.Date.ToString("d MMMM yyyy");
            string? returnDate = null;

            // Check for empty or invalid inputs

            if (String.IsNullOrEmpty(comboBoxMembers.Text))
            {
                MessageBox.Show("Enter a member name!");
            }
            else if (member == null)
            {
                MessageBox.Show("This member does not exist!");
            }
            else
            {
                // Create new loan object
                Loan loan = new Loan(member, borrowDate, returnDate);

                loan.LendBook(loan, currentBook);

                // Update dataGridView, labels and buttons

                GetData().ResetBindings(false);
                lblReturnFrom.Visible = lblCurrentBorrower2.Visible = true;
                lblBorrowedBy.Visible = lblCurrentBorrower3.Visible = true;
                lblCurrentBorrower.Text = lblCurrentBorrower2.Text = lblCurrentBorrower3.Text = currentBook.GetBorrower().GetInfo();
                btnLoan.Enabled = false;
                btnReturn.Enabled = true;
            }
        }

        // Return the current book

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string return_date = datePickerReturn.Value.Date.ToString("d MMMM yyyy");

            Loan.ReturnBook(currentBook, return_date);

            // Update dataGridView, labels and buttons

            GetData().ResetBindings(false);
            lblCurrentBorrower.Text = "Nobody!";
            lblReturnFrom.Visible = lblCurrentBorrower2.Visible = false;
            lblBorrowedBy.Visible = lblCurrentBorrower3.Visible = false;
            btnLoan.Enabled = true;
            btnReturn.Enabled = false;
        }
    }
}
namespace Library
{
    public partial class Form_Members : Form
    {
        public Form_Members()
        {
            InitializeComponent();
            GetData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Method to bind list of books to dataGridView - returns binding source

        public BindingSource GetData()
        {
            BindingSource source = new BindingSource();

            source.DataSource = Library.Members;
            dataGridViewMembers.DataSource = source;
            return source;
        }

        // Add new member

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            string name = textBoxMemberName.Text;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter a name!");
            }
            else
            {
                // Create new member object
                Member member = new Member(name);

                member.AddMember(member, name);

                GetData().ResetBindings(false);
            }
        }

        // Remove member

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembers.CurrentRow == null)
            {
                MessageBox.Show("Select a member!");
            }
            else
            {
                // Get the selected member object
                Member member = (Member)dataGridViewMembers.CurrentRow.DataBoundItem;

                member.RemoveMember(member);

                GetData().ResetBindings(false);
            }
        }
    }
}

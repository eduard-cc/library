using System.ComponentModel;

namespace Library
{
    [Serializable]
    public class Member
    {
        // Fields

        private string name;
        private string id;

        // Constructor 

        public Member(string name)
        {
            this.name = name;
        }

        // Parameterless constructor - required for XML Serialization

        public Member() { }

        // Properties - get and set

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DisplayName("ID")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        // Method to generate ID when new member object is created

        public string GenerateId()
        {
            // Get the highest member ID and increment it by 1

            int maxId = Convert.ToInt32(Library.Members.Max(member => member.Id));
            maxId++;
            string generatedId = maxId.ToString("D5");
            return generatedId;
        }

        // Method that adds the member object to the list of members and serializes it

        public void AddMember(Member member, string name)
        {
            // Check if member with the same name already exists

            foreach (Member memberObj in Library.Members)
            {
                if (memberObj.Name.ToLower() == name.ToLower())
                {
                    DialogResult dialogResult = MessageBox.Show($"The member '{memberObj}' already exists!" + 
                        $"\n \n Are you sure you want to add this member?", "Add member", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        goto AddMember;
                    }
                }
            }
            AddMember:

            member.Id = member.GenerateId();
            Library.Members.Add(member);

            Library.SerializeListToXML("members.xml", Library.Members);
            MessageBox.Show("Member added!");
        }

        // Method that removes the member object from the list of members and serializes it

        public void RemoveMember(Member member)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove '"
                + member + "' ?", "Remove book", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Library.Members.Remove(member);

                Library.SerializeListToXML("members.xml", Library.Members);
                MessageBox.Show("Member removed!");
            }
        }

        // Overrides the ToString() method to return the Name of the member object

        public override string ToString()
        {
            return Name;
        }

        // Method to concatenate the Name and ID of a member object to a string

        public string GetInfo()
        {
            return $"{Name} ({Id})";
        }
    }
}
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace Library
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (!File.Exists("books.xml"))
            {
                // Creates a new books.xml file if it doesn't already exist with 3 hardcoded books

                XDocument xmlDoc = new XDocument
                    (
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfBook",
                        new XElement("Book",
                            new XElement("Title", "Harry Potter and the Philosopher's Stone"),
                            new XElement("Author", "J.K. Rowling"),
                            new XElement("Genre", "Fantasy"),
                            new XElement("PublicationDate", "1 September 2014"),
                            new XElement("Pages", "352"),
                            new XElement("Isbn13", "9781408855898"),
                            new XElement("Description", "The first novel in the Harry Potter series and Rowling's debut novel."),
                            new XElement("ArrayOfLoan")),
                        new XElement("Book",
                            new XElement("Title", "The Lord of the Rings"),
                            new XElement("Author", "J.R.R. Tolkien"),
                            new XElement("Genre", "Fantasy"),
                            new XElement("PublicationDate", "29 July 1954"),
                            new XElement("Pages", "423"),
                            new XElement("Isbn13", "9783161484100"),
                            new XElement("Description", "One of the best-selling books ever written, with over 150 million copies sold."),
                            new XElement("ArrayOfLoan")),
                        new XElement("Book",
                            new XElement("Title", "The Da Vinci Code"),
                            new XElement("Author", "Dan Brown"),
                            new XElement("Genre", "Thriller"),
                            new XElement("PublicationDate", "18 March 2003"),
                            new XElement("Pages", "464"),
                            new XElement("Isbn13", "9780385504201"),
                            new XElement("Description", "The novel explores an alternative religious history."),
                            new XElement("ArrayOfLoan")))
                    );
                xmlDoc.Save("books.xml");
            }

            if (!File.Exists("members.xml"))
            {
                // Creates a new members.xml file if it doesn't already exist with 3 hardcoded members

                XDocument xmlDoc = new XDocument
                    (
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfMember",
                        new XElement("Member",
                            new XElement("Name", "John Doe"),
                            new XElement("Id", "00001")),
                        new XElement("Member",
                            new XElement("Name", "Mary Adams"),
                            new XElement("Id", "00002")),
                        new XElement("Member",
                            new XElement("Name", "David Evans"),
                            new XElement("Id", "00003")))
                    );
                xmlDoc.Save("members.xml");
            }

            // Deserialize books and members into their respective lists

            Library.Books = Library.DeserializeXMLtoList("books.xml", Library.Books);
            Library.Members = Library.DeserializeXMLtoList("members.xml", Library.Members);

            Application.Run(new Form_Library());
        }
    }
}
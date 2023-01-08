using System.Xml.Serialization;
using static Library.Book;

namespace Library
{
    public class Library
    {
        // Fields (lists)

        private static List<Book> books;
        private static List<Member> members;

        // Constructor

        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
        }

        // Properties - get and set

        public static List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        public static List<Member> Members
        {
            get { return members; }
            set { members = value; }
        }

        // Method to serialize a generic list to XML file

        public static void SerializeListToXML<T>(string filename, List<T> dataList)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<T>));

            using (var writer = new StreamWriter(filename))
            {
                xmlSerializer.Serialize(writer, dataList);
            }
        }

        // Method to deserialize XML file to a generic list

        public static List<T> DeserializeXMLtoList<T>(string filename, List<T> dataList)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<T>));

            using (var reader = new StreamReader(filename))
            {
                dataList = (List<T>)xmlSerializer.Deserialize(reader);
            }
            return dataList;
        }

        // Search method - Linq query that returns a list of found books based on filters

        public static List<Book> Search(string title, string author, BookGenre genre)
        {
            List<Book> foundBooks = new List<Book>();

            // Selects books that contain the title and author filters

            var query1 = from books in Books
                        where books.Title.ToLower().Contains(title.ToLower()) &&
                              books.Author.ToLower().Contains(author.ToLower())
                        select books;

            foundBooks = query1.ToList();

            // Selects books in foundBooks that also match the genre filter (if genre is defined)

            if (Enum.IsDefined(typeof(BookGenre), genre))
            {
                var query2 = from books in foundBooks
                             where books.Genre == genre
                             select books;

                foundBooks = query2.ToList();
            }

            if (foundBooks.Count == 0)
            {
                MessageBox.Show("No books found!");
            }

            return foundBooks;
        }
    }
}
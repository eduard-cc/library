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

            // Selects books that contain the title, author and genre filters

            var query = from book in Books
                        where book.Title.ToLower().Contains(title.ToLower()) &&
                              book.Author.ToLower().Contains(author.ToLower()) &&
                              (!Enum.IsDefined(typeof(BookGenre), genre) || book.Genre == genre)
                        select book;

            foundBooks = query.ToList();
            return foundBooks;
        }
    }
}
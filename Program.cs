using System.Net;
using System.Reflection;

namespace bookStoreRecord
{
    internal class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);
        static void Main(string[] args)
        {
            Bookstore book1 = new(10, "American Rust", "Philipp Meyer", 15.00);
            Console.WriteLine(book1);
            Bookstore book2 = new(12, "The Secret Garden", "Frances Hodgson Burnett", 11.95);
            Console.WriteLine(book2);
            Bookstore book3 = new(14, "Signature Classics", "C.S. Lewis", 39.99);
            Console.WriteLine(book3);
        }
    }
}

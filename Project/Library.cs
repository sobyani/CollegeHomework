using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project
{
    public class Library
    {
        private List<Book> _books;
        private int _nextId;

        public Library()
        {
            _books = new List<Book>();
            _nextId = 1;
        }

        public void AddBook(string title, string author, int? year)
        {
            var book = new Book(_nextId, title, author, year);
            _books.Add(book);
            _nextId++;
        }

        public bool RemoveBook(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book == null) return false;

            _books.Remove(book);
            return true;
        }

        public List<Book> FindAllBooks() => new List<Book>(_books);

        public List<Book> FindBooksByTitle(string query) =>
            _books.Where(b => b.Title?.Contains(query, StringComparison.OrdinalIgnoreCase) == true)
                   .ToList();

        public List<Book> FindBooksByAuthor(string query) =>
            _books.Where(b => b.Author?.Contains(query, StringComparison.OrdinalIgnoreCase) == true)
                   .ToList();
    }

}

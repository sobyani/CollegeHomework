using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    public struct Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            this.Title = title; 
            this.Author = author;
        }
        public string ToString()
        {
            return $"\"{Title}\" автора {Author}";
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    internal class Student
    {
        private static int _count = 0;
        public string Name { get; set; }
        public Book FavoriteBook { get; set; }
        public Student (string name, Book favoriteBook)
        {
            Name = name;
            FavoriteBook = favoriteBook;
            _count++;
        }
        public static int Count
        {
            get
            {
                return _count;
            }
        }
        public string Tostring()
        {
            return $"{Name},его любимая книга:{FavoriteBook}";
        }
    }
}

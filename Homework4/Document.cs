using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public abstract class Document
    {
        public string Author { get; set; }

        protected Document(string author)
        {
            Author = author;
        }

        public abstract void Render();
    }
}

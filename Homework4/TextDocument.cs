using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class TextDocument : Document
    {
        public string Content { get; set; }

        public TextDocument(string author, string content)
            : base(author)
        {
            Content = content;
        }

        public override void Render()
        {
            Console.WriteLine("[Текст] Автор: " + Author);
            Console.WriteLine("Содержимое: " + Content);
        }
    }
}

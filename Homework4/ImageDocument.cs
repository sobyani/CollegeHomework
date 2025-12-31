using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class ImageDocument : Document
    {
        public string Resolution { get; set; }

        public ImageDocument(string author, string resolution)
            : base(author)
        {
            Resolution = resolution;
        }

        public override void Render()
        {
            Console.WriteLine("[Изображение] Автор: " + Author);
            Console.WriteLine("Рендеринг изображения с разрешением " + Resolution);
        }
    }
}

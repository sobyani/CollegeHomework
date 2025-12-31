using Homework4;

class Program
{
    static void Main(string[] args)
    {
        List<Document> documents = new List<Document>
        {
            new TextDocument("Лев Толстой", "Все счастливые семьи похожи друг на друга..."),
            new ImageDocument("Иван Шишкин", "3558x2180"),
            new TextDocument("Михаил Булгаков", "В белом плаще с кровавым подбоем...")
        };

        Console.WriteLine("--- Рендеринг документов ---");
        Console.WriteLine("Начинаю рендеринг...");
        Console.WriteLine("--------------------");

        foreach (Document doc in documents)
        {
            doc.Render();
            Console.WriteLine("--------------------");
        }
    }
}

using Homework_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Аукцион начинается! ---");

        var lot = new AuctionLot("Старинная ваза", 1000.00m);
        Console.WriteLine($"Лот: '{lot.Name}'. Начальная цена: {lot.CurrentPrice:F2}");

        var ivan = new Bidder("Иван");
        var petr = new Bidder("Петр");
        var anna = new Bidder("Анна");

        lot.PriceChanged += ivan.OnPriceChanged;
        lot.PriceChanged += petr.OnPriceChanged;
        lot.PriceChanged += anna.OnPriceChanged;

        Console.WriteLine($"Участник '{ivan.Name}' подписался на лот.");
        Console.WriteLine($"Участник '{petr.Name}' подписался на лот.");
        Console.WriteLine($"Участник '{anna.Name}' подписался на лот.");

        lot.PlaceBid(ivan, 1200.00m);
        lot.PlaceBid(petr, 1300.00m); 
        lot.PlaceBid(anna, 1500.00m);

        Console.ReadLine(); 
    }
}

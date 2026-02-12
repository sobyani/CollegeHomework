using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    public class AuctionLot
    {
        public string Name { get; }
        public decimal CurrentPrice { get; private set; }

        public event PriceChangedHandler PriceChanged;

        public AuctionLot(string name, decimal startingPrice)
        {
            Name = name;
            CurrentPrice = startingPrice;
        }

        public void PlaceBid(Bidder bidder, decimal newPrice)
        {
            if (newPrice <= CurrentPrice)
            {
                Console.WriteLine($"{bidder.Name} делает ставку: {newPrice:F2}");
                Console.WriteLine($"Ставка не принята. Сумма должна быть выше {CurrentPrice:F2}.");
                return;
            }

            Console.WriteLine($"{bidder.Name} делает ставку: {newPrice:F2}");

            CurrentPrice = newPrice;

            OnPriceChanged(bidder, newPrice);
        }

        protected virtual void OnPriceChanged(Bidder bidder, decimal newPrice)
        {
            PriceChanged?.Invoke(this, bidder, newPrice);
        }
    }
}

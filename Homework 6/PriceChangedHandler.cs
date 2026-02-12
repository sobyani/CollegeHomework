using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    public delegate void PriceChangedHandler(AuctionLot lot, Bidder bidder, decimal newPrice);

    public class Bidder
    {
        public string Name { get; }

        public Bidder(string name)
        {
            Name = name;
        }

        public void OnPriceChanged(AuctionLot lot, Bidder bidder, decimal newPrice)
        {
            if (bidder != this) 
            {
                Console.WriteLine($"[{Name}]: Новая ставка на '{lot.Name}' - {newPrice:F2} (от {bidder.Name}).");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    public class Inventory
    {
        private List<Product> _items;
        private int _nextId;

        public Inventory()
        {
            _items = new List<Product>();
            _nextId = 1;
        }

        public void AddProduct(string name, double price)
        {
            var product = new Product(_nextId, name, price);
            _items.Add(product);
            _nextId++; 
        }

        public bool RemoveProduct(int id)
        {
            var product = _items.Find(p => p.Id == id);
            if (product is null)
            {
                return false;
            }
            _items.Remove(product);
            return true;
        }

        public List<Product> GetAllProducts() => _items.ToList();
    }
}

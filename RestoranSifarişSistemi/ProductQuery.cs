using System;
using System.Collections.Generic;
using System.Linq;

namespace RestoranSifariSistemi
{
    public class ProductQuery
    {
        private ProductDatabase db;

        public ProductQuery(ProductDatabase database)
        {
            db = database;
        }

        public List<Product> GetProductsByCategory(string category)
        {
            return db.GetAll()
                .Where(p => p.GetCategory().Equals(category, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Product> GetAvailableProducts()
        {
            return db.GetAll().Where(p => p.GetIsAvailable() == true).ToList();
        }

        public Product GetCheapestProduct()
        {
            if (db.Count() == 0) return null;

            decimal minPrice = db.GetAll().Min(p => p.GetPrice());
            
            return db.GetAll().FirstOrDefault(p => p.GetPrice() == minPrice);
        }

        public List<Product> GetProductsBelowPrice(decimal maxPrice)
        {
            return db.GetAll().Where(p => p.GetPrice() <= maxPrice).ToList();
        }
    }
}
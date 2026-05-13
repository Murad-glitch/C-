using System;
using System.Collections.Generic;
using System.Linq;
namespace RestoranSifariSistemi
{
    public class ProductDatabase
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        if (product != null)
            products.Add(product);
    }

    public List<Product> GetAll()
    {
        return products;
    }

    public int Count()
    {
        return products.Count;
    }

    public Product GetById(int id)
    {
        return products.FirstOrDefault(p => p.GetID() == id);
    }
}

}

using System;
using System.Collections.Generic;
using System.Linq;
namespace RestoranSifariSistemi
{
    public class SifarişDatabase
    {
    private List<Sifariş> orders = new List<Sifariş>();

    public void AddOrder(Sifariş order)
    {
        if (order != null)
            orders.Add(order);
    }

    public List<Sifariş> GetAll()
    {
        return orders;
    }

    public int Count()
    {
        return orders.Count;
    }
    }

}

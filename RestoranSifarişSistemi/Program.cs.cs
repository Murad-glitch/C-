using System;
using System.Collections.Generic;
namespace RestoranSifariSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDatabase productDb = new ProductDatabase();
            Product p1 = new Product();
            p1.SetId(1);
            p1.SetName("Pizza");
            p1.SetPrice(12.50m);
            p1.SetCategory("Main Course");
            p1.SetIsAvailable(true);
            productDb.AddProduct(p1);
            SifarişDatabase orderDb = new SifarişDatabase();
            Sifariş s1 = new Sifariş();
            s1.SetId(101);
            s1.SetStatus("Pending");
            s1.SetTotalAmount(12.50m);
            s1.SetCreatedDate(DateTime.Today);
            orderDb.AddOrder(s1);
            SifarişQuery query = new SifarişQuery(orderDb);
            Console.WriteLine("Mehsul sayi: " + productDb.Count());
            Console.WriteLine("Cemi sifaris: " + orderDb.Count());
            Console.WriteLine("Gozleyen sifaris sayi: " + query.GetPendingOrders().Count);
            if (query.GetLastOrder() != null)
            {
                Console.WriteLine("Son sifaris ID: " + query.GetLastOrder().GetId());
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace RestoranSifariSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDatabase productDb = new ProductDatabase();
            SifarişDatabase orderDb = new SifarişDatabase();

            Product p1 = new Product();
            p1.SetId(1); p1.SetName("Pizza"); p1.SetPrice(12.50m); p1.SetCategory("Main Course"); p1.SetIsAvailable(true);
            productDb.AddProduct(p1);

            Product p2 = new Product();
            p2.SetId(2); p2.SetName("Kola"); p2.SetPrice(2.50m); p2.SetCategory("Drinks"); p2.SetIsAvailable(true);
            productDb.AddProduct(p2);

            Product p3 = new Product();
            p3.SetId(3); p3.SetName("Doner"); p3.SetPrice(4.00m); p3.SetCategory("Fast Food"); p3.SetIsAvailable(false);
            productDb.AddProduct(p3);

            Sifariş s1 = new Sifariş();
            s1.SetId(101);
            s1.SetStatus("Pending");
            s1.SetCreatedDate(DateTime.Now);

            s1.AddProductToOrder(p1);
            s1.AddProductToOrder(p2);
            
            orderDb.AddOrder(s1);

            SifarişQuery orderQuery = new SifarişQuery(orderDb);
            ProductQuery productQuery = new ProductQuery(productDb);

            Console.WriteLine("====== RESTORAN SİSTEMİ HESABATI ======");
            Console.WriteLine("Menyudakı ümumi məhsul sayı: " + productDb.Count());
            Console.WriteLine("Sistemdəki cəmi sifariş sayı: " + orderDb.Count());
            Console.WriteLine("Gözləyən (Pending) sifariş sayı: " + orderQuery.GetPendingOrders().Count);
            
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine($"101 nömrəli sifarişin məbləği: {s1.GetTotalAmount()} AZN");
            
            Console.WriteLine("Sifariş olunan məhsullar:");
            foreach (var item in s1.GetOrderItems())
            {
                Console.WriteLine($"- {item.GetName()} ({item.GetPrice()} AZN)");
            }

            Console.WriteLine("\n----------------------------------------");
            Product enUcuz = productQuery.GetCheapestProduct();
            if (enUcuz != null)
            {
                Console.WriteLine($"Menyudakı ən ucuz məhsul: {enUcuz.GetName()} ({enUcuz.GetPrice()} AZN)");
            }

            Console.WriteLine("\nİçkilər kateqoriyası:");
            var ickiler = productQuery.GetProductsByCategory("Drinks");
            foreach (var icki in ickiler)
            {
                Console.WriteLine($"- {icki.GetName()}");
            }
            Console.WriteLine("=======================================");
        }
    }
}
//https://github.com/Murad-glitch/C-

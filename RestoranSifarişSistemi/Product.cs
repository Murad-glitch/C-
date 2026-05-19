using System;
using System.Collections.Generic;
using System.Linq;
namespace RestoranSifariSistemi
{
    public class Product
    {
        public  int Id;
        public string Name;
        public decimal Price;
        public string Category;
        public bool IsAvailable;


        public int GetID(){return Id;}
        public string GetName(){return Name;}
        public decimal GetPrice(){return Price;}
        public string GetCategory(){return Category;}
        public bool GetIsAvailable(){return IsAvailable;}


        public void SetId(int id)
        {
            Id=id;
        }
        public void SetName(string name)
        {
            if (name != null) Name=name;
            else Console.WriteLine("Ad boş ola bilməz");
        }
        public void SetPrice(decimal price)
        {
            if (price>=0) Price=price;
            else Console.WriteLine("Qiymət mənfi ola bilməz");
        }
        public void SetCategory(string category)
        {
            Category=category;
        }
        public void SetIsAvailable(bool available)
        {
            IsAvailable=available;
        }
    }
}

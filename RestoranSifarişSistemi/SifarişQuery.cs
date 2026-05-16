using System;
using System.collection.Generic;
using System.Linq;
namespace RestoranSifariSistemi
{
    public class SifarişQuery
    {
        private SifarişDatabase db;
        public SifarişQuery(SifarişDatabase database)
        {
            db = database;
        }
        public List<Sifariş>GetPendingOrders()
        {
            return db.GetAll().Where(s=>s.GetStatus() == "Pending").ToList();
        }
        public List<Sifariş>GetOrderByAmount()
        {
            return db.GetAll().OrderBy(s=>s.GetTotalAmount()).ToList();
        }
        public decimal GetMaxAmount()
        {
            if (db.Count() == 0) return 0;
            return db.GetAll().Max(s => s.GetTotalAmount());
        }
        public List<Sifariş> GetOrdersByToday()
        {
            return db.GetAll()
                .Where(s => s.GetCreatedDate().Date == DateTime.Today)
                .ToList();
        }
        public Sifariş GetLastOrder()
        {
            return db.GetAll().LastOrDefault();
        }
    }
}
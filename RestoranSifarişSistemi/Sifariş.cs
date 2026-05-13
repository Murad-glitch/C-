using System;
using System;
using System.Collection.Generic;
using System.Linq;
namespace RestoranSifariSistemi
{
    public class Sifariş
    {
        int Id;
        string Status;
        decimal TotalAmount;
        DateTime CreatedTime;


        public int GetId(){return Id;}
        public string GetStatus(){return Status;}
        public decimal GetTotalAmount(){return TotalAmount;}
        public DateTime GetCreatedTime(){return CreatedTime;}

        public void SetId(int id){Id=id;}
        public void SetStatus(string status){Status=status;}
        public void SetTotalAmount(decimal büdcə){TotalAmount=büdcə;}
        public void SetCreatedDate(DateTime sifarişvaxt){CreatedTime=sifarişvaxt;}
    }
}

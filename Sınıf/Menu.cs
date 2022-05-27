using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf
{
    public class Menu
    {
        Veritabani.AracKiralamaProjeEntities entities = new Veritabani.AracKiralamaProjeEntities();

        public int Ekle(Veritabani.Customer obj)
        {
            entities.Customer.Add(obj);
            int returnValue = entities.SaveChanges();
            return returnValue;
        }

        public void Duzenle(Veritabani.Customer obj)
        {
            var entity = entities.Customer.Where(p=>p.CustomerID == obj.CustomerID).FirstOrDefault();
            entity = obj;
            var sonuc = entities.SaveChanges();
        }

        public void Sil(int id)
        {
            var Veri = entities.Customer.Where(p => p.CustomerID == id).FirstOrDefault();
            entities.Customer.Remove(Veri);
            var sonuc = entities.SaveChanges();
        }

    }
}

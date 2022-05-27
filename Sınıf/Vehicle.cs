using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string Series { get; set; }
        public DateTime Year { get; set; }
        public string LicencePlate { get; set; }
        public int KM { get; set; }
        public string BodyType { get; set; }
        public int DailyPrice { get; set; }
        public string Color { get; set; }
        public string Fuel { get; set; }

        public string AracEke(List<Vehicle> vehicles, Veritabani.Vehicle vehicle)
        {
            foreach(var item in vehicles)
            {
                vehicle.Fuel = item.Fuel;
                vehicle.BrandName = item.BrandName;
                vehicle.Model = item.Model;
                vehicle.Series = item.Series;
                vehicle.Year = item.Year;
                vehicle.LicencePlate = item.LicencePlate;
                vehicle.KM = item.KM;
                vehicle.BodyType = item.BodyType;
                vehicle.DailyPrice = item.DailyPrice;
                vehicle.color = item.Color;                
            }

            Veritabani.AracKiralamaProjeEntities db = new Veritabani.AracKiralamaProjeEntities();
            db.Vehicle.Add(vehicle);
            db.SaveChanges();
            return "Listeye araç eklendi"; 
        }

        public bool Add(Vehicle vehicle)
        {
            bool added = false;
            using (Veritabani.AracKiralamaProjeEntities db = new Veritabani.AracKiralamaProjeEntities())
            {
                db.Vehicle.Add(new Veritabani.Vehicle()
                {
                    BrandName = vehicle.BrandName,
                    Model = vehicle.Model,
                    Series = vehicle.Series,
                    Year = vehicle.Year,
                    LicencePlate = vehicle.LicencePlate,
                    KM = vehicle.KM,
                    BodyType = vehicle.BodyType,
                    DailyPrice = vehicle.DailyPrice,
                    color = vehicle.Color
                });
                var response = db.SaveChanges();
                if (response == 1)
                {
                    added = true;
                }
            }

            return added;
        }

        public List<Vehicle> GetAllVeichle()
        {
            using (Veritabani.AracKiralamaProjeEntities db = new Veritabani.AracKiralamaProjeEntities())
            {
                var result = (from c in db.Vehicle.ToList()
                              select new Vehicle
                              {
                                  BrandName = c.BrandName,
                                  Model = c.Model,
                                  Series = c.Series,
                                  LicencePlate = c.LicencePlate,
                              }).ToList();
                return result;
                              
            }
        }

        public List<Vehicle> GetById(int id)
        {
            using (Veritabani.AracKiralamaProjeEntities db = new Veritabani.AracKiralamaProjeEntities())
            {

                var result = from c in db.Vehicle.Where(c => c.VehicleID == id)
                             select new Vehicle
                             {
                                 BrandName = c.BrandName,
                                 Model = c.Model,
                                 Series = c.Series,
                                 LicencePlate = c.LicencePlate,
                             };

                return result.ToList();
            }
        }
    }
}

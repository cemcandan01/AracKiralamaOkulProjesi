using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
        public string Adress { get; set; }

        public bool Add(Customer customer)
        {
            bool added = false;
            using (Veritabani.AracKiralamaProjeEntities db = new Veritabani.AracKiralamaProjeEntities())
            {
                db.Customer.Add(new Veritabani.Customer()
                {
                    Email = customer.Email,
                    Password = customer.Password.ToString(),
                    Name = customer.CustomerName,
                    Surname = customer.CustomerSurname,
                    Adress = customer.Adress
                });
                var response = db.SaveChanges();
                if (response == 1)
                {
                    added = true;
                }
            }

            return added;
        }

    }

    
}

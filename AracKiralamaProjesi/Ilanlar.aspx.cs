using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sınıf;

namespace AracKiralamaProjesi
{
    public partial class Ilanlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_ekle_Click(object sender, EventArgs e)
        {
            Veritabani.AracKiralamaProjeEntities db = new Veritabani.AracKiralamaProjeEntities();
            var car = db.Vehicle.FirstOrDefault(
                x => x.BrandName == txt_marka.Text && x.Model == txt_model.Text && x.Series == txt_seri.Text &&
                x.LicencePlate == txt_plaka.Text && x.KM.ToString() == txt_km.Text && x.BodyType == txt_kasa.Text &&
                x.DailyPrice.ToString() == txt_ucret.Text && x.color == txt_renk.Text && x.Fuel == txt_yakit.Text);

            if (car == null)
            {
                LabelError.Text = "Eksik bilgi bulunmaktadır";
            }
            else
            {
                Session.Add("id", car.VehicleID);
                Session.Add("Marka", car.BrandName);
                Session.Add("Model", car.Model);
                Session.Add("Seri", car.Series);
                Session.Add("Plaka", car.LicencePlate);
                Session.Add("KM", car.KM);
                Session.Add("Kasa", car.BodyType);
                Session.Add("Ücret", car.DailyPrice);
                Session.Add("Renk", car.color);
                Session.Add("Yakıt", car.Fuel);

                LabelError.Text = "Araç Eklenmiştir!";
            }
        }

        protected void btn_goster_Click(object sender, EventArgs e)
        {

        }
    }
}
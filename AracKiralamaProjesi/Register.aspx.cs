using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AracKiralamaProjesi
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Veritabani.Customer customer = new Veritabani.Customer();
            customer.Email = floatingInput.Value;
            customer.Password = floatingPassword.Value;
            customer.Name = FirstName.Value;
            customer.Surname = Surname.Value;
            customer.Adress = Adress.Value;
            

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44373/");

                var result = client.PostAsync("api/customer/add", new StringContent(
                    new JavaScriptSerializer().Serialize(customer), Encoding.UTF8, "application/json")).Result;

                if(result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    LabelMessage.Text = "Customer Eklendi";
                }
                else
                {
                    LabelMessage.Text = "Customer Eklenemedi";
                }
            }

            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AracKiralamaProjesi
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btngiris_Click(object sender, EventArgs e)
        {
            Veritabani.AracKiralamaProjeEntities db = new Veritabani.AracKiralamaProjeEntities();
            var user = db.Customer.FirstOrDefault(
                x => x.Email == floatingInput.Value && x.Password.ToString() == floatingPassword.Value);

            if (user == null)
            {
                LabelError.Text = "hatalı şifre veya mail";
            }
            else
            {
                Session.Add("name", user.Name);
                Session.Add("id", user.CustomerID);
                Response.Redirect("Ilanlar.Aspx");
            }
        }

        protected void btnkayit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.Aspx");
        }
    }
}
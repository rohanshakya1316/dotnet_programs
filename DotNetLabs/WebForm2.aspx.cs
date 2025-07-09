using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetLabs
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string age = txtAge.Text;
            string gender = ddlGender.SelectedValue;
            string country = ddlCountry.SelectedValue;

            lblResult.Text = $"Hello {name}!<br/>" +
                             $"Email: {email}<br/>" +
                             $"Age: {age}<br/>" +
                             $"Gender: {gender}<br/>" +
                             $"Country: {country}";
        }
    }
}
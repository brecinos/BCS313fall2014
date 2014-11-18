using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FaroCoffeShop
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonClerkApplication_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClientDataEntry.aspx");
        }
    }
}
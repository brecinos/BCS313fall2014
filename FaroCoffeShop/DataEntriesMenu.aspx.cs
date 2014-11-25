using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FaroCoffeShop
{
    public partial class DataEntriesMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonClient_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClientDataEntry.aspx");
        }

        protected void ButtonPayment_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaymentDataEntry.aspx");
        }

        protected void ButtonEmployee_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeDataEntry.aspx");
        }

        protected void ButtonProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductDataEntry.aspx");
        }

        protected void ButtonGenerateOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("GenerateOrder.aspx");
        }
    }
}
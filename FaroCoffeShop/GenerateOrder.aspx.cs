using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FaroCoffeShop
{
    public partial class GenerateOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loadDropdowns();
        }


        private void loadDropdowns() {

            var db = new DataClassesFaroDataContext();

            var queryClient = db.Clients.ToList();
            var queryEmployee = db.Employees.ToList();


            this.DropDownListClient.DataSource = queryClient;
            DropDownListClient.DataValueField = "idclient";
            DropDownListClient.DataTextField = "name";
            DropDownListClient.DataBind();

            this.DropDownListEmployee.DataSource = queryEmployee;
            DropDownListEmployee.DataValueField = "IdEmployee";
            DropDownListEmployee.DataTextField = "Name";
            DropDownListEmployee.DataBind();

        
        }

    }
}
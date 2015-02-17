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
            {
                LoadAllData();
                ButtonAddProduct.Visible = false;
                
            }
        }

        private void LoadAllData() {
            loadData();
            loadDataDetail();
            loadDropdowns();
        }


        private void loadDropdowns() {

            var db = new DataClassesFaroDataContext();

            var queryClient = db.Clients.ToList();
            var queryEmployee = db.Employees.ToList();
            var queryProducts = db.Products.ToList();

            this.DropDownListClient.DataSource = queryClient;
            DropDownListClient.DataValueField = "idclient";
            DropDownListClient.DataTextField = "name";
            DropDownListClient.DataBind();

            this.DropDownListEmployee.DataSource = queryEmployee;
            DropDownListEmployee.DataValueField = "IdEmployee";
            DropDownListEmployee.DataTextField = "Name";
            DropDownListEmployee.DataBind();

            this.DropDownListProduct.DataSource = queryProducts;
            DropDownListProduct.DataValueField = "ProductId";
            DropDownListProduct.DataTextField = "Name";
            DropDownListProduct.DataBind();
        
        }


        private void loadData()
        {
            var db = new DataClassesFaroDataContext();
            var datasourcex = db.Orderxes.ToList();
            GridView1.DataSource = datasourcex;
            GridView1.DataBind();
        }

        private void loadDataDetail()
        {
            var db = new DataClassesFaroDataContext();
            var datasourcex = db.OrderDetails.ToList();
            GridView2.DataSource = datasourcex;
            GridView2.DataBind();
        }


        protected void ButtonAddProduct_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonGenerateOrder_Click(object sender, EventArgs e)
        {
            var db = new DataClassesFaroDataContext();

            var clientP = int.Parse(this.DropDownListClient.SelectedValue.ToString());
            var employeeP = int.Parse(this.DropDownListEmployee.SelectedValue.ToString());
            var product = int.Parse(this.DropDownListProduct.SelectedValue);
            var quantityP = int.Parse(TextBoxQuantity.Text.Trim());

            var lastinsertedId = 0;

            try
            {
                var newOrder = new Orderx()
                {
                    ClientId = clientP,
                    EmployeeId = employeeP,
                    Date = "11-25-2015"//DateTime.Today.ToString()
                };
                db.Orderxes.InsertOnSubmit(newOrder);
                db.SubmitChanges();
                lastinsertedId = newOrder.OrderId;
                loadDropdowns();

                var newOrderDetail = new OrderDetail()
                {
                    OrderId = lastinsertedId,
                    Subtotal = quantityP,
                    ProductId = product
                };


            }
            catch (Exception ex)
            {
                var errorx = ex.Message;
            }
            LoadAllData();
        }

    }
}
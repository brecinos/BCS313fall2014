using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FaroCoffeShop
{
    public partial class ProductDataEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loadData();
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            InsertProduct();
            this.TextBoxName.Text = "";
            this.TextBoxDesc.Text = "";
            this.TextBoxInventory.Text = "";
            this.TextBoxPrice.Text = "";

        }

        private void loadData()
        {
            var db = new DataClassesFaroDataContext();
            var datasourcex = db.Products.ToList();
            GridView1.DataSource = datasourcex;
            GridView1.DataBind();

        }

        private void InsertProduct()
        {
            var db = new DataClassesFaroDataContext();

            var nameVal = this.TextBoxName.Text.Trim();
            var descVal = this.TextBoxDesc.Text.Trim();
            var priceVal = int.Parse(this.TextBoxPrice.Text.Trim());
            var inventoryVal = int.Parse(this.TextBoxInventory.Text.Trim());

            try
            {
                var newProduct = new Product()
                {
                    name = nameVal,
                    description = descVal,
                    price = priceVal,
                    inventory = inventoryVal
                };
                db.Products.InsertOnSubmit(newProduct);
                db.SubmitChanges();
                loadData();
            }
            catch (Exception ex)
            {
                var errorx = ex.Message;
            }

        }


       
    }
}
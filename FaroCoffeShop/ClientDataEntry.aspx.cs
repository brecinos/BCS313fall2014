using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FaroCoffeShop;
namespace FaroCoffeShop
{
    public partial class ClientDataEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                loadData();
                DropDownLoad();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            InsertClient();
            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
        }


        private void loadData() {

            var db = new DataClassesFaroDataContext();
            /*
            var datasourcex = from p in db.Clients
                              select new
                              {
                                  ,

                              };
             */
                
            var datasourcex  =  db.Clients.ToList();
            GridView1.DataSource = datasourcex;
            GridView1.DataBind();

        }

        private void DropDownLoad()
        {

            var db = new DataClassesFaroDataContext();
            var datasourcex = db.Payments.ToList();
            DropDownListPayment.DataSource = datasourcex;
            DropDownListPayment.DataValueField = "paymentId";
            DropDownListPayment.DataTextField = "paymentMethod";
            DropDownListPayment.DataBind();

        }





        private void InsertClient() 
        {
            var db = new  DataClassesFaroDataContext();

            var nameVal = this.TextBox1.Text.Trim();
            var emailVal = this.TextBox2.Text.Trim();
            var paymentVal = int.Parse(this.DropDownListPayment.SelectedValue);


            try
            {
                var newClient = new Client()
                {
                    email = emailVal,
                    name = nameVal,
                    paymentId = paymentVal
                };
                db.Clients.InsertOnSubmit(newClient);
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
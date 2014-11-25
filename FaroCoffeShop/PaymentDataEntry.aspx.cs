using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FaroCoffeShop
{
    public partial class PaymentDataEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loadData();
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            InsertPayment();
            this.TextBoxPayment.Text = "";
        }

        private void loadData()
        {
            var db = new DataClassesFaroDataContext();
            var datasourcex = db.Payments.ToList();
            GridView1.DataSource = datasourcex;
            GridView1.DataBind();
        }

        private void InsertPayment()
        {
            var db = new DataClassesFaroDataContext();

            var paymentVal = this.TextBoxPayment.Text.Trim();

            try
            {
                var newPayment = new Payment()
                {
                    paymentMethod = paymentVal,
                };
                db.Payments.InsertOnSubmit(newPayment);
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
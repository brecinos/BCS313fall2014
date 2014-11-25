using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FaroCoffeShop
{
    public partial class EmployeeDataEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loadData();
        }

        private void loadData()
        {
            var db = new DataClassesFaroDataContext();
            var datasourcex = db.Employees.ToList();
            GridView1.DataSource = datasourcex;
            GridView1.DataBind();
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            InsertEmployee();
            this.TextBoxName.Text = "";
        }


        private void InsertEmployee() {

            var db = new DataClassesFaroDataContext();

            var employeeVal = this.TextBoxName.Text.Trim();

            try
            {
                var newEmployee = new Employee()
                {
                    Name = employeeVal
                };
                db.Employees.InsertOnSubmit(newEmployee);
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
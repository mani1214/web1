using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowEmployee();
        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            BusinessLogic bl = new BusinessLogic();
            Employee emp = new Employee();
            emp.Eid = int.Parse(TxtID.Text);
            emp.Ename = TxtName.Text;
            emp.Esal = int.Parse(TxtSalary.Text);
            if (bl.AddEmployee(emp))
            {
                ShowEmployee();
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            BusinessLogic bl = new BusinessLogic();
            Employee emp = new Employee();
            emp.Eid = int.Parse(TxtID.Text);
            if (bl.DelEmployee(emp))
            {
                ShowEmployee();
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            BusinessLogic bl = new BusinessLogic();
            Employee emp = new Employee();
            emp.Eid = int.Parse(TxtID.Text);
            emp.Ename = TxtName.Text;
            emp.Esal = int.Parse(TxtSalary.Text);
            if (bl.UpdateEmployee(emp))
            {
                ShowEmployee();
            }
        }

        protected void BtnShow_Click(object sender, EventArgs e)
        {
            ShowEmployee();
        }

        protected void BtnFind_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Eid = int.Parse(TxtID.Text);
            emp = new BusinessLogic().GetEmployeeID(emp);
            TxtName.Text = emp.Ename;
            TxtSalary.Text = emp.Esal.ToString();
        }
        public void ShowEmployee()
        {
            GridView1.DataSource = new BusinessLogic().GetEmployee().ToList();
            GridView1.DataBind();
        }
    }
}
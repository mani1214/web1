using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication4
{
    public class BusinessLogic
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        public BusinessLogic() // Basic Configuration
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            con = new SqlConnection(cs);
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Close();
        } 
        public bool AddEmployee(Employee Emp)
        {
            cmd.CommandText = string.Format($"insert into emptable values({Emp.Eid},'{Emp.Ename}', {Emp.Esal} )");
            con.Open();
            int val = cmd.ExecuteNonQuery();
            con.Close();
            return val == 1;
        }
        public bool DelEmployee(Employee Emp)
        {
            cmd.CommandText = string.Format($"delete from emptable where Eid = {Emp.Eid}");
            con.Open();
            int val = cmd.ExecuteNonQuery();
            con.Close();
            return val == 1;
        }
        public bool UpdateEmployee(Employee Emp)
        {
            cmd.CommandText = string.Format($"update emptable set Ename = '{Emp.Ename}', Esal = {Emp.Esal} where Eid = {Emp.Eid}");
            con.Open();
            int val = cmd.ExecuteNonQuery();
            con.Close();
            return val == 1;
        }
        public List<Employee> GetEmployee()
        {
            List<Employee> employees = new List<Employee>();
            cmd.CommandText = "select * from emptable";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Employee emp = new Employee();
                // emp.Eid = int.Parse(dr[0].ToString());
                // emp.Ename = (dr[1].ToString());
                // emp.Esal = int.Parse(dr[2].ToString());
                // employees.Add(emp);
                employees.Add(new Employee(int.Parse(dr[0].ToString()), dr[1].ToString(), int.Parse(dr[2].ToString())));
            }
            con.Close();
            return employees;
        }
        public Employee GetEmployeeID(Employee emp)
        {
            cmd.CommandText = string.Format($"select * from emptable where eid = {emp.Eid}");
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                emp.Eid = int.Parse(dr[0].ToString());
                emp.Ename = (dr[1].ToString());
                emp.Esal = Convert.ToInt32(dr[2]);
            }
            con.Close();
            return emp;
        }
    }
}
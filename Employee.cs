using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4
{
    public class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public int Esal { get; set; }

        public Employee()
        {

        }
        public Employee (int eid, string ename, int esal)
        {
            Eid = eid;
            Ename = ename;
            Esal = esal;
        }
    }
}
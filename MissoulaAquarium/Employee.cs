using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissoulaAquarium
{
    class Employee
    {
       // private string empName;
        public string empName { get; set; }
        public int empID { get; set; }
        public string empTitle { get; set; }

        public Employee(string n, int id, string t)
        {
            empName = n;
            empID = id;
            empTitle = t;
        }

        public override string ToString()
        {
            return empID + "\t" + empName + "\t" + empTitle;
        }

        //public string empName
        //{
        //    //set the person name
        //    set { this.empName = value; }
        //    //get the person name 
        //    get { return this.empName; }
        //}
        //public int empID
        //{
        //    //set the person id
        //    set { this.empID = value; }
        //    //get the person id 
        //    get { return this.empID; }
        //}
        //public string empTitle
        //{
        //    //set the person title
        //    set { this.empTitle = value; }
        //    //get the person title 
        //    get { return this.empTitle; }
        //}
    }
}

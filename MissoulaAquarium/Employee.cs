using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissoulaAquarium
{
    class Employee
    {      
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
    }
}

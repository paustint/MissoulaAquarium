using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissoulaAquarium
{
    class Shift
    {
        public Employee emp { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public string sun { get; set; }
        public string mon { get; set; }
        public string tue { get; set; }
        public string wed { get; set; }
        public string thu { get; set; }
        public string fri { get; set; }
        public string sat { get; set; }

        public Shift(Employee e, string su, string m, string t, string w, string r, string f, string s)
        {
            emp = e;
            name = emp.empName;
            id = emp.empID;
            sun = su;
            mon = m;
            tue = t;
            wed = w;
            thu = r;
            fri = f;
            sat = s;
        }
    }
}

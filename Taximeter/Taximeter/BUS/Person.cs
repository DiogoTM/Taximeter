using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taximeter.BUS
{
    public class Person
    {
        public Person(string fname, string lname)
        {
            Fname = fname;
            Lname = lname;
        }
        public Person()
        {
            Fname = "";
            Lname = "";
        }

        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}

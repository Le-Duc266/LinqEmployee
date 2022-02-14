using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEmployees
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime birthDay { get; set; }

        public Employee()
        {
        }
        public Employee(int id, string name, DateTime birthDay)
        {
            this.id = id;
            this.name = name;
            this.birthDay = birthDay;
        }
        public override string ToString()
        {
            return "Ma NV: " + id + " - Ten NV: " + name + " - NgaySinh: " + birthDay;
        }
    }
}

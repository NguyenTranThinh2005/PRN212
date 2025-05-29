using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdCard { get; set; }
        public DateTime dob { get; set; }
        public virtual double calSalary()
        {
            return 400;
        }
        public override string ToString()
        {
            return Id+"\t"+Name + "\t" +IdCard + "\t" + dob + "\t" +calSalary();
        }

    }
}

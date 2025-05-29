using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2_Reuse
{
    public static class Utils
    {
        public static int tinhTuoi(this Employee employee)
        {
            return DateTime.Now.Year-employee.dob.Year+1;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class FullTimeEmployee : Employee
    {
        public override double calSalary()
        {
            return base.calSalary()+500;
        }
    }
}

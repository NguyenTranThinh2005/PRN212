﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class PartTimeEmployee :Employee
    {
        public int workingHrs {  get; set; }
        public int workingMinute { get; set; }
        public override double calSalary()
        {
            return 100*workingHrs;
        }
    }
}

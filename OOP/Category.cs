﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Category
    {
        public int id;
        public string name ="";
        public void printInfor()
        {
            Console.WriteLine($"{id}\t{name}");
        }

    }
}

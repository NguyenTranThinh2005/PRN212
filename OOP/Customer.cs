﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public void printInfor()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Customer Id={Id}");
            Console.WriteLine($"Customer name={Name}");
            
        }
    }
   
}

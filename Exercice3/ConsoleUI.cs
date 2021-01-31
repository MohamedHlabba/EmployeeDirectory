﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
   public class ConsoleUI 
    {

        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public void Print(Employee employee)
        {
            Console.WriteLine(employee);
        }
    }
}

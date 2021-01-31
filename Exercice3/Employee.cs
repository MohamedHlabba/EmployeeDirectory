using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
   public class Employee
    {
        private int salary;
        private string name;

        public int Salary { get;  }
        public string Name { get; set; }

        public SalaryLevel SalaryLevel
        { 
            
            
            get
            {  // en val att göra
                if (Salary < 15000)
                {
                    return SalaryLevel.junior;
                }
                else
                {
                    return SalaryLevel.senior;
                }
                //boolen type (return salary < 150000)if true               else flase
                // return salary < 15000 ? SalaryLevel.junior : SalaryLevel.senior;

            }
        
        
        
        }

        public Employee(string name ,int salary)
        {
            Name = name;
            Salary = salary;


        }

        public override string ToString()
        {
            return $"Name : {Name} ,Salary :{Salary} Kr, SalaryLevel :{SalaryLevel} ";
        }



    }
}

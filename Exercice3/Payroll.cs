using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
  public  class Payroll
    {
        private List<Employee> payroll;


        public Payroll()
        {
            payroll = new List<Employee>();
            
        }

        internal void AddEmployees(string name, int salary)
        {
            //1 way
            //Employee temp = new Employee(name,salary);
            //payroll.Add(temp);

            //2 way

            payroll.Add(new Employee(name, salary));
        }

        public  Employee[] GetEmployees()
        {
            return payroll.ToArray(); 
        }





    }
}

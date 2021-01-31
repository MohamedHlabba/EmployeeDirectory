using System;

namespace Exercice3
{
    class Program
    {
        static Payroll payroll = new Payroll();
        static ConsoleUI ui = new ConsoleUI();

        static void Main(string[] args)
        {


            SeedData();
            
            do
            {
                ShowMainMenu();

                UserAction();

            } while (true);

          

        }

        private static void UserAction()
        {
            switch (ui.GetInput())
            {

                case "1":
                    AddEmployee();

                    break;
                case "2":
                    PrintEmployee();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    ui.Print("Wrong Input");
                    break;
            }
        }

        private static void AddEmployee()
        {
            do
            {

            ui.Print("Add a new Employee, Q for exit");
            string name = Util.AskForString("Name : ,  ", ui);
            if (name.Equals("Q")) break;
            int salary = Util.AskForInt("Salary :", ui);
            payroll.AddEmployees(name,salary);
            } while (true);

        }

        private static void ShowMainMenu()
        {
            ui.Print("1.Add new employee");
            ui.Print("2.Print all employees");
            ui.Print("3.Quit");
        }

        private static void PrintEmployee()
        {
            Employee[] employees = payroll.GetEmployees();
            foreach (Employee employee in employees)
            {
                //Console.WriteLine($"Name : {employee.Name} Salary : {employee.Salary}  SalaryLvel : {employee.SalaryLevel}");
                ui.Print(employee);
            }
        }

        private static void SeedData()
        {
            payroll.AddEmployees("Kalle",  10000); 
            payroll.AddEmployees("Nermine", 20000);
            payroll.AddEmployees("Dalel", 10000);
            payroll.AddEmployees("Svenson", 44150000);


        }   
        
        
    }
}

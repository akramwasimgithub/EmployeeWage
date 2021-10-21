using System;

namespace EmployeeWage
{
    class Uc1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage calculation");
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine(" Employee is absent");
            }
        }
    }
}

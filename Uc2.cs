using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Uc2
    {
        static void Main(String[] args)
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next();

            int empCeck = random.Next(0, 2);
            if (empCeck == IS_FULL_TIME)
            {
                Console.WriteLine("Emplyee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("And Emp wage : " + empWage);
         } 
    }
}

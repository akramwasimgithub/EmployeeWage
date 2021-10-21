using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Uc3
    {
        static void Main(String[] args)
        {
            int IS_PAR_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next();

            int empCeck = random.Next(0, 3);
            if (empCeck == IS_PAR_TIME)
            {
                Console.WriteLine(" Employee attend par time");
                empHrs = 4;
            }
            else if (empCeck == IS_FULL_TIME)
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


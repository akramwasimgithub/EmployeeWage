using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Uc4
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME= 2;
        public const int EMP_RATE_PER_HOUR = 20;

        static void Main(String[] args)
        {
            int empHrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch(empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empwage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage : " + empwage);

        }
    }
}

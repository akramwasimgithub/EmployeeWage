using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Uc8
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth) 
        {
            //variablees 
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
            while (totalEmpHrs <= maxHoursPerMonth &&  totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("days#:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }
            int totalWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + "is: " + totalWage);
            return totalWage;
        
       }
        static void Main(String[] args)
        {
            computeEmpWage("Dmart", 20, 2, 10);
            computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}

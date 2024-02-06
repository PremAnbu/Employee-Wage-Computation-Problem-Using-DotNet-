﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeMain
    {
       const int partTime = 0;
       const int fullTime = 1;
       const int empRatePerHour = 20;
       const int NoOfWorkingDays = 2;
        const int maxHoursInMonth = 10;
        public static void CalculateWage()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            int empHours = 0, totalEmpHour = 0, totalWorkingDays = 0;
            while (totalEmpHour<=maxHoursInMonth && totalWorkingDays<NoOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int atten = random.Next(0, 2);
                switch (atten)
                {
                    case partTime:
                        empHours = 40;
                        break;
                    case fullTime:
                        empHours = 80;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalEmpHour =totalEmpHour + empHours;
                Console.WriteLine("Employee Days : {0} Employee Hours {1}",totalWorkingDays,empHours );
            }
            Console.WriteLine("Total Employee wage : {0}", totalEmpHour * empRatePerHour);
        }
        public static void Main()
        {
            CalculateWage();
        }
    }
}

using System;
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
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            int empHours = 0, empWage = 0, totalEmpWage = 0;
            for (int i = 0; i < NoOfWorkingDays; i++)
            {
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
                empWage = empHours * empRatePerHour;
                totalEmpWage =totalEmpWage + empWage;
                Console.WriteLine("Employee wage : {0}", empWage);
            }
            Console.WriteLine("Total Employee wage : {0}", totalEmpWage);
        }
    }
}

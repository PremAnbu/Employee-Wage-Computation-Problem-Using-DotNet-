using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeMain
    {
       const int partTime = 1;
       const int fullTime = 2;
        public static int CalculateWage(string company,int empRatePerHour,int NoOfWorkingDays,int maxHoursInMonth)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            int empHours = 0, totalEmpHour = 0, totalWorkingDays = 0;
            while (totalEmpHour <= maxHoursInMonth && totalWorkingDays < NoOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int atten = random.Next(0, 3);
                switch (atten)
                {
                    case partTime:
                        empHours = 4;
                        break;
                    case fullTime:
                        empHours = 8;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalEmpHour =totalEmpHour + empHours;
                Console.WriteLine("Employee Days : {0} Employee Hours {1}",totalWorkingDays,empHours );
            }
            int totalEmployeeWage = totalEmpHour * empRatePerHour;
            Console.WriteLine("Total Employee wage for company: {0} , is {1}",company,totalEmployeeWage);
            return totalEmployeeWage;
        }
        public static void Main()
        {
            CalculateWage("prem",20,2,10);
            CalculateWage("Kumar", 10, 4, 20);
        }
    }
}

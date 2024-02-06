using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeMain
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            Random random = new Random();
            int atten = random.Next(0,2);
            if (atten == 0)
                Console.WriteLine("Employee Absent");
            else
                Console.WriteLine("Employee Present");
            CalculateEmployeeWage(20,8);
            CalculatePartTimeEmployeeWage(20,8);
        }
        public static void CalculateEmployeeWage(int wagePerHour,int fullDayHour)
        {
            int totalWage=wagePerHour*fullDayHour;
            Console.WriteLine("Total Wage for Full time Employee is {0}", totalWage);
        }
        public static void CalculatePartTimeEmployeeWage(int wagePerHour, int partTimeHour)
        {
            int totalWage = wagePerHour * partTimeHour;
            Console.WriteLine("Total Wage For Part Time Employee is {0}", totalWage);
        }
    }
}

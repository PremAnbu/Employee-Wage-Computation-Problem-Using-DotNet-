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
            Console.WriteLine("Enter \n 1.Full time Employee \n 2.Part time Employee");
            int choice=int .Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine("Enter Wage Per Hour");
                    int WagePerHour=int .Parse(Console.ReadLine());
                    Console.WriteLine("Enter Full Day Hour");
                    int FullDayHour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Full time employee income is {0}",WagePerHour*FullDayHour);
                    break;
                case 2:
                    Console.WriteLine("Enter Wage Per Hour");
                    int WagePerHour1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Part TIme Hour");
                    int PartTImeHour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Part time employee income is {0}", WagePerHour1 * PartTImeHour);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
         
        }
    }
}

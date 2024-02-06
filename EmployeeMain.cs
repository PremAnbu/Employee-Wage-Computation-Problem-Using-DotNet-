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
            int atten = random.Next(0,1);
            if (atten == 0)
                Console.WriteLine("Employee Absent");
            else
                Console.WriteLine("Employee Present");

        }
    }
}

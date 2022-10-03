using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    /// <summary>
    /// Employee Check class
    /// </summary>
    public static  class EmplyeeCheck
    {
        /// <summary>
        /// This method will check the employee attendence.
        /// </summary>
        public static void EmployeeAttendence()
        {
            //Constants
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //Variables
            int empHrs = 0;
            int empWage = 0;

            //Comutation
            Random random = new Random();
            int empCheck = random.Next(2);

            if(empCheck==IS_FULL_TIME)
            {
                Console.WriteLine("Employee is full time");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is no worked");
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("EmpWage : " + empWage);
        }
    }
}

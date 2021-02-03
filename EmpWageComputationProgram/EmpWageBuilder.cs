using System;

namespace EmpWageComputationProgram
{
    class EmpWage
    {
        public static void CheckingAttendance()
        {
            //Constant
            int IS_PRESENT = 1;
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
    class EmpWageBuilder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program");
            EmpWage.CheckingAttendance();

        }
    }
}

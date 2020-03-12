using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int hh;
            double pay;
      
            int[] employeeId = { 56588, 45012, 78951, 87775, 84512, 13028, 75804 };     //created 4 arrays to simulate storage containers for an employee's
            int[] hours = new int[7];                                                   //wages, each index in every array is attached to a specfic employee
            double[] payRate = new double[7];                                           //by the employeeId array
            double[] wages = new double[7];

            Console.WriteLine("You are an employee that calculates weekly wages for all the employee's at your company.\n" +
            "This program was designed to assist you with calculating their wages!\nYou will be entering in the amount of hours\n" +
            "and the amount they get paid for one week worth of pay for 7 employees.\n\n");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Enter the amount of hours {employeeId[i]} has worked this week");
                hh=int.Parse( Console.ReadLine());
                Console.WriteLine($"Enter the how much {employeeId[i]} makes per hour");
                pay= double.Parse( Console.ReadLine());
                Console.WriteLine($"{employeeId[i]} made ${wages[i] = (hh * pay)} this week.");
                Console.ReadLine();
                Console.Clear();


            }



        }
    }
}

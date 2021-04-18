using System;
using System.Collections.Generic;
using System.Text;


/*
Name: Dakota McGregor
Date: 04/17/2021

Validate user input accross other classes
*/

namespace Game
{
    public static class Validation
    {
        public static int Interger(string message)
        {   
            Console.WriteLine(message);

            string i = Console.ReadLine();
            int z;

            while (!(int.TryParse(i, out z)))
            {
                Console.WriteLine("\r\nERROR: Please only enter a valid number.\r\n");
                Console.Write("Please re-enter your answer: ");
                i = Console.ReadLine();
            }
            return z;
        }
    }
}

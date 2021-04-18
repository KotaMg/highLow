using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

/*
Name: Dakota McGregor
Date: 04/17/2021

General styling / layout class
*/

namespace Game
{
    public static class UI
    {
        public static void Header(string y)
        {
            Console.WriteLine($"=====================\r\n {y.ToUpper()}\r\n=====================\r\n");
        }

        public static void Footer(string y, bool pause = false)
        {
            Console.Write($"=====================\r\n{y.ToUpper()}");
            if (pause) Console.ReadLine();
        }

        public static void Separator()
        {
            Console.WriteLine("---------------------");
        }


        public static void Theme()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}    
 


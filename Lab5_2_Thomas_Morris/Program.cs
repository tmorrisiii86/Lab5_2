using System;
using System.Collections.Generic;

namespace Lab5_2_Thomas_Morris
{
    class Program
    {
        //1
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            //2
            List<string> taskList = new List<string>();

            //3
            foreach(WeekDays days in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("Enter new task for " + days);
                string task = days + " : " + Console.ReadLine();
                taskList.Add(task);
            }

            //4
            foreach (string task in taskList)
            {
                Console.WriteLine(task);
            }
        }
    }
}

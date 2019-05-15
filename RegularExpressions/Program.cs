﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            //string pattern = @"\d";
            //string pattern = @"there";
            string pattern = @"\d{5}";

            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12314";

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine($"{matchCollection.Count} hits found: {text}");

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
            }
            DateTime dateTime = new DateTime(2018, 5, 31);

            Console.WriteLine($"My birthday is {dateTime}");

            //write today on screen
            Console.WriteLine(DateTime.Today);

            //Write current time on sccreen
            Console.WriteLine(DateTime.Now);
            
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine($"Tomorrow will be the {tomorrow}");

            Console.WriteLine($"Today is: {DateTime.Today.DayOfWeek}");

            Console.WriteLine($"First day of a year: {GetFirstDayOfYear(1999)}");

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine($"Days in Feb 2000: {days}");
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine($"Days in Feb 2001: {days}");
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine($"Days in Feb 2004: {days}");

            DateTime now = DateTime.Now;
            Console.WriteLine($"Minute: {now.Minute}");

            Console.WriteLine($"{now.Hour} o'clock {now.Minute} minutes and {now.Second}");

            Console.WriteLine("Write date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine($"Days passed since: {daysPassed.Days}");
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

            Console.WriteLine("Write birth date in this format: yyyy-mm-dd");

            string input2 = Console.ReadLine();

            if(DateTime.TryParse(input2,  out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine($"You are {daysPassed.Days} days old!");
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
            Console.ReadLine();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}

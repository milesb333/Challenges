using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1Challenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameAge()
        {
            string firstName = "Miles";
            string lastName = "Blake";
            int age = 20;
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);
        }

        [TestMethod]
        public void Favorites()
        {
            string[] movie = { "Superbad", "Cat Soup" , "Rubber", "Dead Leaves", "Four Brothers" };
        }

        [TestMethod]
        public void Dates()
        {
            List<DateTime> Dates = new List<DateTime>();
            DateTime today = DateTime.Now;
            Dates.Add(today);
            Dates.Add(new DateTime(2020, 02, 11));
            Dates.Add(new DateTime(2019, 07, 20));
            Dates.Add(new DateTime(2020, 05, 17));

        }

        [TestMethod]
        public void SleepTime()
        {
            Console.WriteLine("How much sleep did you get?");
            int hours = 4;
            if(hours >= 10)
            {
                Console.WriteLine("Wow, that's a lot of sleep!");
            }
            else if(hours >= 8 && hours < 10)
            {
                Console.WriteLine("You should be well rested.");
            }
            else if(hours > 4 && hours < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man get some sleep.");
            }
        }
        [TestMethod]
        public void HowHAsYourDayBeen()
        {
            string userDay = "Okay";
            switch (userDay)
            {
                case "Great":
                    Console.WriteLine("Glad you are having a great day");
                    break;
                case "Good":
                    Console.WriteLine("It is a day to be good on");
                    break;
                case "Okay":
                    Console.WriteLine("Hopefully it will get better from here");
                    break;
                case "Bad":
                    Console.WriteLine("There is always tomorrow");
                    break;
                case ":(":
                    Console.WriteLine("I guess this is us now");
                    break;
                default:
                    Console.WriteLine("Please enter something above");
                    break;
            }
        }
        [TestMethod]
        public void Supercalifragilisticexpialidocious()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach(char letter in name)
            {
                if(letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("not an i");
                }
            }
        }
    }
}

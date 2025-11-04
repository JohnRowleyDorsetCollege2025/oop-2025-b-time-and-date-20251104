using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_b_time_and_date_20251104.Models
{
    public static class TimeAndDateDriver
    {
        public static void Run()
        {
            Console.WriteLine("Time and Date Module");
            ShowAppDetails();
            UTCDemo();
            LocalToUTC();
            DateFormatting();
            DaysUntilNextChristmas();
            DaysUntilMyNextBirthday();
            DurationAndDeadline();
            ParseDateString();

        }

        public static void ShowAppDetails()
        {
            Console.WriteLine($"App Title: {AppConstants.Title}");
            Console.WriteLine($"App Version: {AppConstants.Version}");
        }

        public static void UTCDemo()
        {
            DateTime localTime = DateTime.Now;

            DateTime utcNow = DateTime.UtcNow;

            Console.WriteLine($"Local Time: {localTime}");
            Console.WriteLine($"UTC Time: {utcNow}");
        }

        public static void LocalToUTC()
        {
            DateTime localTime = DateTime.Now;
            DateTime utcNow = localTime.ToUniversalTime();

            Console.WriteLine($"Local Time: {localTime}");
            Console.WriteLine($"UTC Time: {utcNow}");


        }

        public static void DateFormatting()
        {
            DateTime localTime = DateTime.Now;

            Console.WriteLine($"Local Time: {localTime}");
            Console.WriteLine($"Short Date: {localTime.ToShortDateString()}");
            Console.WriteLine($"Custom Format: {localTime: dddd, dd MMMM yyyy HH:mm}");
        }

        public static int DaysUntilNextChristmas()
        {
            DateTime today = DateTime.Today;
            DateTime christmasDay = new DateTime(today.Year, 12, 25);
            Console.WriteLine($"christmasDay{christmasDay.ToShortDateString()}");

            if (today > christmasDay)
            {
                christmasDay = christmasDay.AddYears(1);
            }
            TimeSpan difference = christmasDay - today;
            Console.WriteLine($"Days until Christmas: {difference.Days}");
            return difference.Days;

        }

        public static int DaysUntilMyNextBirthday()
        {
            DateTime today = DateTime.Today;
            DateTime myBirthDay = new DateTime(today.Year, 6, 14);
            
            if (today > myBirthDay)
            {
                myBirthDay = myBirthDay.AddYears(1);
            }
            Console.WriteLine($"myBirthDay{myBirthDay.ToShortDateString()}");

            TimeSpan difference = myBirthDay - today;
            Console.WriteLine($"Days until myBirthDay: {difference.Days}");
            return difference.Days;

        }

        public static void DurationAndDeadline()
        {
            TimeSpan duration = new TimeSpan(2, 3, 30, 0);
            DateTime deadline = DateTime.Now + duration;
           
            Console.WriteLine($"deadline: {deadline}");

        }

        public static void ParseDateString()
        {
            string dateText = "2025-12-31 23:59";
            DateTime parsed = DateTime.Parse(dateText);

             Console.WriteLine($"parsed: {parsed}");

        }
    }
}


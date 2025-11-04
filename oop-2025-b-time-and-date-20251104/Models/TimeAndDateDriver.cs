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
        }

        public  static void ShowAppDetails()
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
    }
}

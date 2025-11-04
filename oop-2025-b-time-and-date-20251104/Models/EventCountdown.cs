using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_b_time_and_date_20251104.Models
{
    internal class EventCountdown
    {
        public DateTime eventDate { get; set; }
        public EventCountdown(DateTime eventDate)
        {
            this.eventDate = eventDate;
        }

        public int GetDaysRemaining()
        {
            DateTime today = DateTime.Today;
            TimeSpan difference = eventDate - today;
            return difference.Days;
        }
    }
}

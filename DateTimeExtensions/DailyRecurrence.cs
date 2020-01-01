using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace DateTimeExtensions
{
    public class DailyRecurrence : DateTimeRecurrence
    {            
        public override IEnumerator<DateTime> GetEnumerator()
        {
            DateTime currentDateTime = StartDateTime;

            while (currentDateTime <= EndDateTime)
            {
                if ((1 << (int)currentDateTime.DayOfWeek & (int)DaysOfweek) != 0)
                    yield return currentDateTime;

                currentDateTime = currentDateTime.AddDays(Interval);
            }
        }
    }
}

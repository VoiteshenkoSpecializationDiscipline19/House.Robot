using System;
using System.Text;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;

namespace DateTimeExtensions
{
    public class WeeklyRecurrence : DateTimeRecurrence
    {
        public override IEnumerator<DateTime> GetEnumerator()
        {
            DayOfWeek firstDayofWeek = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;

            DateTime currentDateTime = StartDateTime;

            DateTime currentWeek = currentDateTime;
            // Move the current week "cursor" backwards until it is at the start of the current week.
            while (currentWeek.DayOfWeek != firstDayofWeek)
                currentWeek = currentWeek.AddDays(-1);

            while (currentDateTime <= EndDateTime)
            {
                do
                {
                    if ((1 << (int)currentDateTime.DayOfWeek & (int)DaysOfweek) != 0)
                        yield return currentDateTime;

                    currentDateTime = currentDateTime.AddDays(1);
                } while (currentDateTime.DayOfWeek != firstDayofWeek);

                currentDateTime = currentWeek = currentWeek.AddDays(Interval * 7);
            }
        }
    }
}

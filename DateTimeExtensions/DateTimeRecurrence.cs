using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DateTimeExtensions
{
    [Flags]
    public enum DaysOfWeek
    {
        None = 0x00,
        Sunday = 0x01,
        Monday = 0x02,
        Tuesday = 0x04,
        Wednesday = 0x08,
        Thursday = 0x10,
        Friday = 0x20,
        Saturday = 0x40
    }

    public abstract class DateTimeRecurrence : IEnumerable<DateTime>
    {
        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int Interval { get; set; }

        public DaysOfWeek DaysOfweek { get; set; }

        #region IEnumerable<DateTime> Members

        public virtual IEnumerator<DateTime> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}

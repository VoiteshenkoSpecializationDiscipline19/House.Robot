using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateTimeExtensions
{
    /// <summary>
    /// Calculates solar position and sunrise/sunset times.
    /// </summary>
    public static class SolarCalculator
    {
        public static DateTime Sunrise(DateTime dt, double longitude, double latitude, TimeZoneInfo timeZoneInfo)
        {
            longitude *= -1;

            if (latitude > 89.9)
                latitude = 89.9;
            if (latitude < -89.9)
                latitude = -89.9;

            var fy = FractionalYear(dt.Date);
            var eqtime = EquationOfTime(fy);
            var decl = SolarDeclination(fy);
            var ha = SunriseSunsetHourAngle(decl, latitude).ToDegrees();

            var offset = 720.0 + 4.0 * (longitude - ha) - eqtime;

            var utcDateTime = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, DateTimeKind.Utc);
            utcDateTime += TimeSpan.FromMinutes(offset);

            return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, timeZoneInfo);
        }

        public static DateTime Sunset(DateTime dt, double longitude, double latitude, TimeZoneInfo timeZoneInfo)
        {
            longitude *= -1;

            if (latitude > 89.9)
                latitude = 89.9;
            if (latitude < -89.9)
                latitude = -89.9;

            var fy = FractionalYear(dt.Date);
            var eqtime = EquationOfTime(fy);
            var decl = SolarDeclination(fy);
            var ha = SunriseSunsetHourAngle(decl, latitude).ToDegrees();

            var offset = 720.0 + 4.0 * (longitude + ha) - eqtime;

            var utcDateTime = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, DateTimeKind.Utc);
            utcDateTime += TimeSpan.FromMinutes(offset);

            return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, timeZoneInfo);
        }

        /// <summary>
        /// Calculates the fractional year in radians.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>Fractional year in radians</returns>
        public static double FractionalYear(DateTime dt)
        {
            return ((2.0 * Math.PI) / 365.0) * (dt.DayOfYear - 1 + ((dt.Hour - 12.0) / 24.0));
        }

        private static readonly double z = Math.Cos(90.833.ToRadians());

        public static double SunriseSunsetHourAngle(double declination, double latitude)
        {
            var a = Math.Cos(latitude.ToRadians()) * Math.Cos(declination);
            var b = Math.Tan(latitude.ToRadians()) * Math.Tan(declination);

            return Math.Acos((z / a) - b);
        }

        public static double TimeOffset(DateTime dt, double longitude, int timezone)
        {
            var f = FractionalYear(dt);
            var eqtime = EquationOfTime(f);

            return eqtime - 4.0 * longitude + 60.0 * timezone;
        }

        public static double EquationOfTime(double fractionalYear)
        {
            var f = fractionalYear;
            return 229.18 * (0.000075 + 0.001868 * Math.Cos(f) - 0.032077 * Math.Sin(f) - 0.014615 * Math.Cos(2.0 * f) - 0.040849 * Math.Sin(2.0 * f));
        }

        public static double SolarDeclination(double fy)
        {
            return 0.006918 - 0.399912 * Math.Cos(fy) + 0.070257 * Math.Sin(fy) - 0.006758 * Math.Cos(2.0 * fy) + 0.000907 * Math.Sin(2.0 * fy) - 0.002697 * Math.Cos(3.0 * fy) + 0.00148 * Math.Sin(3.0 * fy);
        }
    }

    public static class TrigonometryExtensions
    {
        public static double ToRadians(this double degrees)
        {
            return (Math.PI * degrees) / 180.0;
        }

        public static double ToDegrees(this double radians)
        {
            return (180.0 * radians) / Math.PI;
        }
    }

    public static class DateTimeExtensions
    {
        public static DateTime Sunrise(this DateTime dt, double longitude, double latitude)
        {
            return SolarCalculator.Sunrise(dt, longitude, latitude, TimeZoneInfo.Local);
        }

        public static DateTime Sunrise(this DateTime dt, double longitude, double latitude, TimeZoneInfo timeZoneInfo)
        {
            return SolarCalculator.Sunrise(dt, longitude, latitude, timeZoneInfo);
        }

        public static DateTime Sunrise(this DateTime dt, double longitude, double latitude, string timeZoneId)
        {
            return SolarCalculator.Sunrise(dt, longitude, latitude, TimeZoneInfo.FindSystemTimeZoneById(timeZoneId));
        }

        public static DateTime Sunset(this DateTime dt, double longitude, double latitude)
        {
            return SolarCalculator.Sunset(dt, longitude, latitude, TimeZoneInfo.Local);
        }

        public static DateTime Sunset(this DateTime dt, double longitude, double latitude, TimeZoneInfo timeZoneInfo)
        {
            return SolarCalculator.Sunset(dt, longitude, latitude, timeZoneInfo);
        }

        public static DateTime Sunset(this DateTime dt, double longitude, double latitude, string timeZoneId)
        {
            return SolarCalculator.Sunset(dt, longitude, latitude, TimeZoneInfo.FindSystemTimeZoneById(timeZoneId));
        }
    }
}

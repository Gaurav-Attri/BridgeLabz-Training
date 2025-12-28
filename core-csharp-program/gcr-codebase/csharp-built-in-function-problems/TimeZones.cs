using System;

class TimeZones{
    static void Main(string[] args){
        // Getting current UTC time
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;

        // Displaying time in different zones
        DisplayTimeZones(utcTime);
    }

    static void DisplayTimeZones(DateTimeOffset utcTime)
    {
        // GMT Time (same as UTC)
        TimeZoneInfo gmtZone = TimeZoneInfo.Utc;
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcTime, gmtZone);

        // IST Time
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);

        // PST Time
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);

        // Displaying results
        Console.WriteLine("Current Time in Different Time Zones:\n");

        Console.WriteLine("GMT Time : " + gmtTime);
        Console.WriteLine("IST Time : " + istTime);
        Console.WriteLine("PST Time : " + pstTime);
    }
}


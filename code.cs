using System;

public class DateIterator
{
    // This method iterates through a range of dates and prints various information about each date to the console
    public static void IterateThroughDate(DateTime startDate, DateTime endDate)
    {
        // Print the year of the start date
        Console.WriteLine(startDate.Year);

        // Iterate through each date in the range
        for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            // If the date is January 1st, print the year
            if (currentDate.Day == 1 && currentDate.Month == 1)
            {
                Console.WriteLine(currentDate.Year);
            }

            // If the date is the first day of the month or the start date, print the month and year
            if (currentDate.Day == 1 || currentDate == startDate)
            {
                Console.WriteLine(currentDate.ToString("MMMM"));
            }

            // Print the date in the format "MM/dd/yyyy"
            Console.WriteLine(currentDate.ToString("MM/dd/yyyy"));
        }
    }

}

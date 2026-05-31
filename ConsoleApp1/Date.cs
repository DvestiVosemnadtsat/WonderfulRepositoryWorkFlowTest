namespace ConsoleApp1;

public class Date
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public Date(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }
    
    public bool IsLeapYear()
    {
        return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
    }
    
    public int DaysDifference(Date otherDate)
    {
        DateTime date1 = new DateTime(Year, Month, Day);
        DateTime date2 = new DateTime(otherDate.Year, otherDate.Month, otherDate.Day);

        return Math.Abs((date2 - date1).Days);
    }

    public override string ToString()
    {
        return $"{Day:D2}.{Month:D2}.{Year}";
    }
}
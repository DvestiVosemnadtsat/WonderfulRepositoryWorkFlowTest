using ConsoleApp1;

class Program
{
    static void Main()
    {
        Date date1 = new Date(15, 3, 2024);
        Date date2 = new Date(20, 5, 2025);

        Console.WriteLine($"Дата 1: {date1}");
        Console.WriteLine($"Дата 2: {date2}");

        Console.WriteLine($"Рік {date1.Year} високосний: {date1.IsLeapYear()}");
        Console.WriteLine($"Рік {date2.Year} високосний: {date2.IsLeapYear()}");
        Console.WriteLine($"Різниця між датами: {date1.DaysDifference(date2)} днів");
    }
}
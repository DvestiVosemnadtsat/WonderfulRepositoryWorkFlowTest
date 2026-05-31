namespace ConsoleApp1.Tests;
using ConsoleApp1;
public class DateTests
{
    [Fact]
    public void IsLeapYear_2024_ReturnsTrue()
    {
        var date = new Date(1, 1, 2024);
        bool result = date.IsLeapYear();
        Assert.True(result);
    }
    [Fact]
    public void IsLeapYear_2023_ReturnsFalse()
    {
        Date date = new Date(1, 1, 2023);
        bool result = date.IsLeapYear();
        Assert.False(result);
    }
    [Fact]
    public void DaysDifference_SameDate_ReturnsZero()
    {
        Date date1 = new Date(15, 5, 2025);
        Date date2 = new Date(15, 5, 2025);
        int result = date1.DaysDifference(date2);
        Assert.Equal(0, result);
    }
}
namespace BonusTask.Interfaces
{
    public interface IWeather
    {
        string City { get; set; }
        string Country { get; set; }
        int Temperature { get; set; }
        decimal WindSpeed { get; set; }
    }
}
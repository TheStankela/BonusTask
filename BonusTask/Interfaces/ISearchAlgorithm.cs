using BonusTask.Models;

namespace BonusTask.Interfaces
{
    public interface ISearchAlgorithm
    {
        public abstract Weather FilterWeatherByZipCode(int zipCode);
        public abstract List<Weather> FilterWeathersByCountry(string country, int operatorValue);
        public abstract List<Weather> FilterWeathersByTemperature(int temperature, int operatorValue);
    }
}
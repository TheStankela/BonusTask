using BonusTask.Models;

namespace BonusTask.Interfaces
{
    public interface ILinearSearch
    {
        Weather? LinearByZipCode(int zipCode);
        public List<Weather> FilterWeatherByTemperature(int temperature, int _operator);
        public List<Weather> FilterWeatherByCountry(string country, int _operator);
	}
}
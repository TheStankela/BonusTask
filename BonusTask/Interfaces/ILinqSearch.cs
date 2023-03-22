using BonusTask.Models;

namespace BonusTask.Interfaces
{
    public interface ILinqSearch
    {
		Weather GetWeatherByZipCode(int zipCode);
		public List<Weather> GetWeathersByTemperature(int temperature, int operatorValue);
		public List<Weather> GetWeathersByCountry(string country, int operatorValue);
	}
}
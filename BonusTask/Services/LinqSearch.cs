using BonusTask.Data;
using BonusTask.Interfaces;
using BonusTask.Models;

namespace BonusTask.Services
{
	public class LinqSearch : ILinqSearch
	{
		public Weather? GetWeatherByZipCode(int zipCode)
		{
			return WeatherData.weatherList.FirstOrDefault(w => w.ZipCode == zipCode);
		}

		public List<Weather>? GetWeathersByTemperature(int temperature, int operatorValue)
		{
			if (operatorValue == 2)
			{
				return WeatherData.weatherList.Where(w => w.Temperature > temperature).ToList();
			}
			else if (operatorValue == 3)
			{
				return WeatherData.weatherList.Where(w => w.Temperature < temperature).ToList();
			}
			else if (operatorValue == 1)
			{
				return WeatherData.weatherList.Where(w => w.Temperature == temperature).ToList();
			}
			else
			{
				return null;
			}
		}
		public List<Weather>? GetWeathersByCountry(string country, int operatorValue)
		{
			if (operatorValue == 2)
			{
				return WeatherData.weatherList.Where(c => c.Country.Substring(0, 1).ToLower() == country.ToLower()).ToList();
			}
			if (operatorValue == 1)
			{
				return WeatherData.weatherList.Where(c => c.Country.ToLower() == country.ToLower()).ToList();
			}
			return null;
		}
	}
}

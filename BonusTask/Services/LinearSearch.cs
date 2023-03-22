using BonusTask.Data;
using BonusTask.Interfaces;
using BonusTask.Models;

namespace BonusTask.Services
{
	public class LinearSearch : ILinearSearch
	{
		public Weather? LinearByZipCode(int zipCode)
		{
			var rawData = WeatherData.weatherList;
			Weather? result = null;

			foreach (var weather in rawData)
			{
				if (weather.ZipCode == zipCode)
				{
					result = weather;
				}
			}

			return result;
		}

		public List<Weather> FilterWeatherByTemperature(int temperature, int _operator)
		{
			var rawData = WeatherData.weatherList;
			List<Weather> filteredList = new List<Weather>();

			switch (_operator)
			{
				case 1:
					foreach (var weather in rawData)
					{
						if (weather.Temperature == temperature)
						{
							filteredList.Add(weather);
						}
					}
					return filteredList;

				case 2:
					foreach (var weather in rawData)
					{
						if (weather.Temperature > temperature)
						{
							filteredList.Add(weather);
						}
					}
					return filteredList;

				case 3:
					foreach (var weather in rawData)
					{
						if (weather.Temperature < temperature)
						{
							filteredList.Add(weather);
						}
					}
					return filteredList;

				default:
					return filteredList;
			}

		}
		public List<Weather> FilterWeatherByCountry(string country, int _operator)
		{
			var rawData = WeatherData.weatherList;
			List<Weather> filteredList = new List<Weather>();

			switch (_operator)
			{
				case 1:
					foreach (var weather in rawData)
					{
						if (weather.Country.ToLower() == country.ToLower())
						{
							filteredList.Add(weather);
						}
					}
					return filteredList;

				case 2:
					foreach (var weather in rawData)
					{
						if (weather.Country[..1].ToLower() == country.ToLower())
						{
							filteredList.Add(weather);
						}
					}
					return filteredList;

				default:
					return filteredList;
			}

		}
	}
}

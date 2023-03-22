using BonusTask.Interfaces;

namespace BonusTask.Models
{
	public abstract class SearchAlgorithm : ISearchAlgorithm
	{
		public abstract Weather FilterWeatherByZipCode(int zipCode);
		public abstract List<Weather> FilterWeathersByCountry(string country, int operatorValue);
		public abstract List<Weather> FilterWeathersByTemperature(int temperature, int operatorValue);

	}
}

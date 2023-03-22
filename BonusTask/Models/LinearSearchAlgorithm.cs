using BonusTask.Interfaces;

namespace BonusTask.Models
{
	public class LinearSearchAlgorithm : SearchAlgorithm
	{
		ILinearSearch _linearSearch;
		public LinearSearchAlgorithm(ILinearSearch linearSearch)
        {
			_linearSearch = linearSearch;
		}


		public override Weather FilterWeatherByZipCode(int zipCode)
		{
			var result = _linearSearch.LinearByZipCode(zipCode);

			return result;
		}

		public override List<Weather> FilterWeathersByCountry(string country, int operatorValue)
		{
			var result = _linearSearch.FilterWeatherByCountry(country, operatorValue);

			return result;
		}

		public override List<Weather> FilterWeathersByTemperature(int temperature, int operatorValue)
		{
			var result = _linearSearch.FilterWeatherByTemperature(temperature, operatorValue);

			return result;
		}
	}
}

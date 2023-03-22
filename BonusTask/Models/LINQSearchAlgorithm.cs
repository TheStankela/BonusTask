using BonusTask.Interfaces;

namespace BonusTask.Models
{
	public class LINQSearchAlgorithm : SearchAlgorithm
	{
		ILinqSearch _linqSearch;
		public LINQSearchAlgorithm(ILinqSearch linqSearch)
        {
			_linqSearch = linqSearch;
		}
		public override Weather? FilterWeatherByZipCode(int zipCode)
		{
			return _linqSearch.GetWeatherByZipCode(zipCode);
		}
		public override List<Weather> FilterWeathersByCountry(string country, int operatorValue)
		{
			var result = _linqSearch.GetWeathersByCountry(country, operatorValue);

			return result;
		}
		public override List<Weather> FilterWeathersByTemperature(int temperature, int operatorValue)
		{
			var result = _linqSearch.GetWeathersByTemperature(temperature, operatorValue);

			return result;
		}
	}
}

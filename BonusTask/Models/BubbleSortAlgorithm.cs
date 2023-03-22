using BonusTask.Interfaces;

namespace BonusTask.Models
{
	public class BubbleSortAlgorithm : SortAlgorithm
	{
		IDataSorter _dataSorter;
        public BubbleSortAlgorithm(IDataSorter dataSorter)
        {
            _dataSorter = dataSorter;
        }

        public override List<Weather> SortByCity(List<Weather> weatherList)
		{
			var result = _dataSorter.SortByCity(weatherList);

			return result;
		}

		public override List<Weather> SortByTemperature(List<Weather> weatherList)
		{
			var result = _dataSorter.SortByTemperature(weatherList);

			return result;
		}
	}
}

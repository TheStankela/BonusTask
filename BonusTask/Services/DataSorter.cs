using BonusTask.Interfaces;
using BonusTask.Models;

namespace BonusTask.Services
{
    public class BubbleDataSorter : IDataSorter
	{
		public List<Weather> SortByTemperature(List<Weather> weatherList)
		{
			var weatherCount = weatherList.Count();

			for (int i = 0; i < weatherCount - 1; i++)
				for (int j = 0; j < weatherCount - i - 1; j++)
					if (weatherList[j].Temperature > weatherList[j + 1].Temperature)
					{
						var tempVar = weatherList[j];
						weatherList[j] = weatherList[j + 1];
						weatherList[j + 1] = tempVar;
					}

			return weatherList;
		}

		public List<Weather> SortByCity(List<Weather> weatherList)
		{
			var weatherCount = weatherList.Count();

			for (int i = 0; i < weatherCount - 1; i++)
				for (int j = 0; j < weatherCount - i - 1; j++)
					if (string.Compare(weatherList[j].City, weatherList[j + 1].City) > 0)
					{
						var tempVar = weatherList[j];
						weatherList[j] = weatherList[j + 1];
						weatherList[j + 1] = tempVar;
					}

			return weatherList;
		}
	}
}

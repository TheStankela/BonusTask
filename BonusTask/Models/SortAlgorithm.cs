using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BonusTask.Interfaces;

namespace BonusTask.Models
{
    public abstract class SortAlgorithm : ISortAlgorithm
	{
		public abstract List<Weather> SortByTemperature(List<Weather> weatherList);
		public abstract List<Weather> SortByCity(List<Weather> weatherList);
	}
}

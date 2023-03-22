using BonusTask.Models;

namespace BonusTask.Interfaces
{
    public interface ISortAlgorithm
    {
        List<Weather> SortByCity(List<Weather> weatherList);
        List<Weather> SortByTemperature(List<Weather> weatherList);
    }
}
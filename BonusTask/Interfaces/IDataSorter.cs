using BonusTask.Models;

namespace BonusTask.Interfaces
{
    public interface IDataSorter
    {
        List<Weather> SortByCity(List<Weather> weatherList);
        List<Weather> SortByTemperature(List<Weather> weatherList);
    }
}
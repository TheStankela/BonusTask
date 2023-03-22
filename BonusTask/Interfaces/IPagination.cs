using BonusTask.Models;

namespace BonusTask.Interfaces
{
    public interface IPagination
    {
		void Start(List<Weather> weatherList, int recordsPerPage);
		void ShowRecordsByPageNumber(int pageNumber, List<Weather> weathers, int recordsPerPage);
	}
}
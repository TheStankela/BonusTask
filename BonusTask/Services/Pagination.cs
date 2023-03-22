using BonusTask.Interfaces;
using BonusTask.Models;

namespace Day6Tasks.Services
{
	public class Pagination : IPagination
	{
		public void ShowRecordsByPageNumber(int pageNumber, List<Weather> weathers, int recordsPerPage)
		{
			var weatherList = weathers
									.Skip((pageNumber - 1) * recordsPerPage)
									.Take(recordsPerPage).ToList();

			Console.WriteLine();
			Console.WriteLine("Page Number: " + pageNumber);

			foreach (var weather in weatherList)
			{
				Console.WriteLine($"{weather.ToString()}");
			}
		}

		public void Start(List<Weather> weatherList, int recordsPerPage)
		{
			bool value = true;
			int PageNumber = 1;
			string? choice;
			int totalRecords = weatherList.Count();

			int TotalPages = totalRecords / recordsPerPage;

			if (totalRecords % recordsPerPage != 0)
				TotalPages++;

			do
			{
				Console.WriteLine($"\nTotal Pages: {TotalPages} \n Navigate with: FIRST / LAST / PREV / NEXT / EXIT");
				choice = Console.ReadLine().ToLower();
				Console.Clear();

				switch (choice)
				{
					case "next":
						{
							if (PageNumber < TotalPages)
								PageNumber++;
							break;
						}
					case "prev":
						{
							if (PageNumber > 1)
								PageNumber--;
							break;
						}
					case "first":
						{
							PageNumber = 1;
							break;
						}
					case "last":
						{
							PageNumber = TotalPages;
							break;
						}
					case "exit":
						{
							value = false;
							break;
						}
				}

				ShowRecordsByPageNumber(PageNumber, weatherList, recordsPerPage);

			} while (value);
		}
	}
}

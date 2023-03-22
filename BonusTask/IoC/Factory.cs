using BonusTask.Interfaces;
using BonusTask.Models;
using BonusTask.Services;
using Day6Tasks.Services;

namespace BonusTask.IoC
{
    public static class Factory
	{
		public static ILinearSearch CreateLinearService()
		{
			return new LinearSearch();
		}
		public static ILinqSearch CreateLingqService()
		{
			return new LinqSearch();
		}
		public static ISearchAlgorithm CreateLinqSearchClass()
		{
			return new LINQSearchAlgorithm(CreateLingqService());
		}
		public static ISearchAlgorithm CreateLinearSearchClass()
		{
			return new LinearSearchAlgorithm(CreateLinearService());
		}
		public static IPagination CreatePagination()
		{
			return new Pagination();
		}
	}
}

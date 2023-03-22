using BonusTask.Interfaces;

namespace BonusTask.Models
{
    public class Weather : IWeather
	{
		public Weather(string country, int zipCode, string city, int temp, decimal windspeed)
		{
			Country = country;
			City = city;
			Temperature = temp;
			WindSpeed = windspeed;
			ZipCode = zipCode;
		}
		public string Country { get; set; }
		public string City { get; set; }
		public int Temperature { get; set; }
		public int ZipCode { get; set; }
		public decimal WindSpeed { get; set; }

		public override string ToString()
		{
			return $"{Country}, {ZipCode},	{City},	{Temperature}, {WindSpeed}";
		}
	}

}

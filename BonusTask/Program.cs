using BonusTask.Data;
using BonusTask.IoC;


//linq
var linqSearchClass = Factory.CreateLinqSearchClass();

var result = linqSearchClass.FilterWeathersByTemperature(9, 2);
var result2 = linqSearchClass.FilterWeathersByCountry("s", 2);
var result3 = linqSearchClass.FilterWeatherByZipCode(23000);


//linear
var linearSearchClass = Factory.CreateLinearSearchClass();

var result4 = linearSearchClass.FilterWeatherByZipCode(23000);
var result5 = linearSearchClass.FilterWeathersByCountry("s", 2);
var result6 = linearSearchClass.FilterWeathersByTemperature(9, 2);

//bubble sort
var bubbleSortClass = Factory.CreateBubbleSortAlgorithm();
var result7 = bubbleSortClass.SortByTemperature(WeatherData.weatherList);
var result8 = bubbleSortClass.SortByCity(WeatherData.weatherList);
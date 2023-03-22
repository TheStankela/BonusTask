using BonusTask.IoC;

var linqsearch = Factory.CreateLinqSearchClass();
var linearsearch = Factory.CreateLinearSearchClass();

//linq
var result = linqsearch.FilterWeathersByTemperature(9, 2);
var result2 = linqsearch.FilterWeathersByCountry("s", 2);
var result3 = linqsearch.FilterWeatherByZipCode(23000);


//linear
var result4 = linearsearch.FilterWeatherByZipCode(23000);
var result5 = linearsearch.FilterWeathersByCountry("s", 2);
var result6 = linearsearch.FilterWeathersByTemperature(9, 2);

Console.WriteLine();
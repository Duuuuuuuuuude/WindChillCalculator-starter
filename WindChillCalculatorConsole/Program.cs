using MeteorologyCalculator;
using System;

// TODO: Utilize the MeteorologyCalculator class library to calculate the wind chill factor of a given temperature and wind speed.

// HINT: The code to call the wind chill calculator could look something like this 


Temperature temperature = new Temperature(5, Temperature.Scale.Celsius);
// WindSpeed speed = new WindSpeed(9, WindSpeed.Unit.MilesPerHour);
WindSpeed speed = new WindSpeed(9, WindSpeed.Unit.MeterPerSecond);
WindChillFactor wcf = new WindChillFactor(temperature, speed);

Console.WriteLine($"Temperature: {temperature.Celsius} celsius");
Console.WriteLine($"Wind: {speed.MetersPerSecond} MeterPerSecond");
Console.WriteLine($"Calculated Chill Factor: {wcf.CalculateWindChillFactor(Temperature.Scale.Celsius)}"); 
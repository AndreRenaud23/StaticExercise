using StaticExercise;
Console.WriteLine("--------------------------------------");

Console.WriteLine("Enter a number: ");
double inputNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{inputNumber} converted from fahrenheit to celsius is: {TempConverter.FahrenheitToCelsius(inputNumber)}°");

Console.WriteLine("--------------------------------------");

Console.WriteLine("Enter a number: ");
double inputNumber2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{inputNumber2} converted from celsius to fahrenheit is: {TempConverter.CelsiusToFahrenheit(inputNumber2)}°");

Console.WriteLine("--------------------------------------");
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Conversor De Temperaturas - Victória Alves Dantas

Console.WriteLine("\n1- Conversor de Celsius °C para Fahrenheit °F");
float.TryParse(Console.ReadLine(), out float celsius);
float resultado1 = ((celsius * 9 / 5) + 32);
Console.WriteLine($"A conversão de {celsius} °C em Fahrenheit é de {resultado1} °F 🌡️");

Console.WriteLine("\n2- Conversor de Fahrenheit °F para Celsius °C ☀️");
float.TryParse(Console.ReadLine(), out float fahrenheit);
float resultado2 = ((fahrenheit - 32) * 5 / 9);
Console.WriteLine($"A conversão de {fahrenheit} °F em Celsius é de {resultado2} °C ☀️");

Console.WriteLine("\n3- Conversor de Fahrenheit °F para Kelvin °K 🌡️");
float.TryParse(Console.ReadLine(), out float FAHRENHEIT);
float resultado3 = ((FAHRENHEIT + 459.67f) * 5 / 9);
Console.WriteLine($"A conversão de {FAHRENHEIT} °F em Kelvin é de {resultado3} °K 🌡️");

Console.WriteLine("\n4- Conversor de Kelvin °K para Fahrenheit °F ☀️");
float.TryParse(Console.ReadLine(), out float kelvin);
float resultado4 = (((kelvin - 273.15f) * 9 / 5) + 32);
Console.WriteLine($"A conversão de {kelvin} °K em Fahrenheit é de {resultado4} °F ☀️");

bool EntendiMateria = true;
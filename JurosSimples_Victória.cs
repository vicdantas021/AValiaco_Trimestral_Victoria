Console.OutputEncoding = System.Text.Encoding.UTF8;

//Juros Simples - Victória Alves Dantas

Console.WriteLine("Cálculo de juros simples 💵");
Console.WriteLine("\r\nDigite o valor inicial investido ou emprestado:  ");
float.TryParse(Console.ReadLine(), out float capital);
Console.WriteLine("\r\n Digite o percentual aplicado sobre o capital (taxa de juros):  ");
float.TryParse(Console.ReadLine(), out float taxa);
Console.WriteLine("\r\n Digite o período em que o capital ficará aplicado:  ");
float.TryParse(Console.ReadLine(), out float tempo);

float juros = capital * taxa * tempo;

Console.WriteLine($"\r\n💵 O valor do seu juros é de: R${juros} 💵");
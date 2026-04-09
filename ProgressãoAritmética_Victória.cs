Console.OutputEncoding = System.Text.Encoding.UTF8;

//Prograssão Aritmética - Victória Alves Dantas

Console.WriteLine("Progressão Aritmética 🔢");
Console.Write("\r\nDigite a quantidade de termos: ");
int.TryParse(Console.ReadLine(), out int termos);
Console.Write("\r\nDigite a razão: ");
int.TryParse(Console.ReadLine(), out int razao);

for (int i = 0; i < termos; i++)
{
    Console.Write($"{razao * i} ");
}
Console.WriteLine("\r\n\r\nFim do programa!");


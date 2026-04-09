Console.OutputEncoding = System.Text.Encoding.UTF8;

//Números Primos - Victória Alves Dantas

int cont = 0;
Console.WriteLine("✨ Calculadora de Números Primos ✨ \r\nSelecione um número e veja se ele é primo ou não!");
int.TryParse(Console.ReadLine(), out int número);

for (int divisor = 1; divisor <= número; divisor++)
{

    if (número % divisor == 0)
    {

        cont++;
    }
}

if (cont == 2)
{
    Console.WriteLine($"\nO Número: {número} É primo! ");

}
else
{
    Console.WriteLine($"\nO Número: {número} Não é primo!");
}
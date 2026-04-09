Console.OutputEncoding = System.Text.Encoding.UTF8;

//Sequência de Fibonacci - Victória Alves Dantas

Console.WriteLine("Sequência de Fibonacci 🐚");
Console.WriteLine("\nDigite o primeiro número da sequência: ");
int.TryParse(Console.ReadLine(), out int numero1);
Console.WriteLine("Digite o segundo número da sequência: ");
int.TryParse(Console.ReadLine(), out int numero2);
Console.WriteLine("\nDigite a quantidade de números da sequência: ");
int.TryParse(Console.ReadLine(), out int quantidade);

Console.WriteLine($"\nEssa é a sua sequência de Fibonacci 🐚🐚:\n");

for (int i = 0; i < quantidade; i++)
{
    Console.Write(numero1 + " ");

    int proximo = numero1 + numero2;
    numero1 = numero2;
    numero2 = proximo;
}

Console.OutputEncoding = System.Text.Encoding.UTF8;
//Area Circulo - Victória Alves Dantas

Console.WriteLine("🧙 O Mago Merlin é um senhor muito sábio!! O Mago estava lendo um livro de poções, porém algo o interrompeu...");
Console.WriteLine("O Deus da profanidade Infofoxu apareceu e lançou uma maldiçao sobre o Mago Merlin." +
    "Você deve protegê-lo fazendo um círculo divino! ✨");
Console.WriteLine("Estabeleça o valor do raio do círculo divino:");
int.TryParse(Console.ReadLine(), out int raio);
double AreaCirculo = 3.14 * (raio * raio);
if (AreaCirculo >= 10)
{
    Console.WriteLine($"O círculo divino é forte o suficiente para proteger o Mago Merlin! 😀💪");
}
else
{
    Console.WriteLine($"O círculo divino não é forte o suficiente para proteger o Mago Merlin! Ele recebeu a maldição de Infofoxu..." +
        $"\n Passará o resto da vida trabalhando como vendedor de cachorro quente sem salsicha e cor dor🙁🤕");
    return;
}

Console.WriteLine("\r\nO Mago Merlin ficou muito grato por sua ajuda! 🧙✨");
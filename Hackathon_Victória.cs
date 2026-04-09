Console.OutputEncoding = System.Text.Encoding.UTF8;

//Hackathon - Victória Alves Dantas

Console.WriteLine("Seja bem vindo ao jogo do Doce Envenenado 🍬" +
    "\r\nDigite o nome do aventureiro:");
string nome = Console.ReadLine();

Console.WriteLine("Você é um aventureiro que sempre está disposto a explorar lugares novos." +
    "Durante uma aventura, você encontra uma cabana misteriosa no meio da floresta 🌲. " +
    "Curioso, você entra e sente um forte cheiro doce no ar." +
    "\r\n\r\nA cabana é da bruxa mais perigosa da aldeia! Sobre uma mesa, há quatro doces 🍬🍬🍬🍬 e " +
    "um bilhete assustador:" +
    "\r\n\"Agora que entrou, não há saída,\nVeio em busca de uma despedida, " +
     "\nSobre a mesa está sua partida,\nUm deles está envenenado… escolha com cuidado,\n"+
    "\nPois um erro pode selar seu destino traçado.💀");

Console.WriteLine($"\n{nome}, escolha um doce de 1 a 4:");
int escolha;
int.TryParse(Console.ReadLine(), out escolha);

Random Doce = new Random();
int doceVenenoso = Doce.Next(1, 5); //-> de 1 a 4

if (escolha == doceVenenoso)
{
    Console.WriteLine("\nOh não! Você escolheu o doce envenenado...");
    Console.WriteLine("Em poucos segundos, seu fim foi decretado...");

    Console.WriteLine("\r\n💀 FIM DE JOGO 💀");
    Console.WriteLine("Sua jornada termina aqui...");
}
else
{
    Console.WriteLine("\nParabéns, aventureiro! Você escolheu um doce seguro. " +
        "\nEntre riscos e medo, seu instinto foi afiado, ");
    Console.WriteLine("O veneno foi evitado… e seu destino segue ao seu lado! ⚔️");

        Console.WriteLine("\r\n🏆 FIM DE JOGO 🏆");
        Console.WriteLine("Você sobreviveu e provou ser um verdadeiro aventureiro!");
    }
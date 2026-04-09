Console.OutputEncoding = System.Text.Encoding.UTF8;

//Desafio Dos Reinos Antigos - Victória Alves Dantas

Console.WriteLine("Um grande Dragão Vermelho 🐉 despertou e está ameaçando o reino! " +
    "Você foi o aventureiro escolhido pela guilda para avaliar se" +
    " um herói está apto a enfrentá-lo ou se virará churrasco.");
Console.WriteLine("Acima de tudo, defina o nome do seu herói! ⚔️");
string nomeheroi = Console.ReadLine();

Console.WriteLine($"\nSeja bem vindo(a) {nomeheroi}. " +
    $"Antes de começarmos essa batalha, escolha a classe que seu herói pertencerá: \nMago \nClérigo \nGuerreiro \nDruida " +
    $"\nAnão \nElfo \nTroll \nDigite abaixo a classe escolhida");

string CLASSE = Console.ReadLine();
string classe = "";

if (CLASSE == "Mago")
{
    Console.WriteLine($"\n {nomeheroi} prepare-se para enfrentar o dragão como Mago!");
    classe = "Mago";
}
else if (CLASSE == "Clérigo")
{
    Console.WriteLine($"\n{nomeheroi} prepare-se para enfrentar o dragão como Clérigo!");
    classe = "Clérigo";
}
else if (CLASSE == "Guerreiro")
{
    Console.WriteLine($"\n{nomeheroi} prepare-se para enfrentar o dragão como Guerreiro!");
    classe = "Guerreiro";
}
else if (CLASSE == "Druida")
{
    Console.WriteLine($"\n{nomeheroi} prepare-se para enfrentar o dragão como Druida!");
    classe = "Druida";
}
else if (CLASSE == "Anão")
{
    Console.WriteLine($"\n{nomeheroi} prepare-se para enfrentar o dragão como Anão!");
    classe = "Anão";
}
else if (CLASSE == "Elfo")
{
    Console.WriteLine($"\n{nomeheroi} prepare-se para enfrentar o dragão como Elfo!");
    classe = "Elfo";
}
else if (CLASSE == "Troll")
{
    Console.WriteLine($"\n{nomeheroi} prepare-se para enfrentar o dragão como Troll!");
    classe = "Troll";
}
Console.WriteLine("\nAgora digite o nível do seu herói (de 0 a 10):");
int.TryParse(Console.ReadLine(), out int nível);

Console.WriteLine("\nDefina os Pontos de Vida (HP) do Herói:");
double.TryParse(Console.ReadLine(), out double PontoVida);

Console.WriteLine("\nDetermine o s Pontos de Magia (Mana) do Herói:");
int.TryParse(Console.ReadLine(), out int Mana);

Console.WriteLine("\nDigite a Quantidade de Ouro na Mochila do Herói:");
int.TryParse(Console.ReadLine(), out int Ouro);

Console.WriteLine($"\nInformacões finais do seu personagem:" +
    $"\nNome: {nomeheroi} \nClasse: {classe} \nNível: {nível} \nPontos de Vida: {PontoVida} " +
    $"\nPontos de Magia:{Mana} \nOuro: {Ouro}");

Console.WriteLine("\nEstamos quase lá Parceiro(a)! Você irá ser avaliado pela Guilda antes de ir ao combate");

if (classe == "Troll")
{
    Console.WriteLine($"\nApós a avaliação da Guilda temos o veredito! \n{nomeheroi} NÃO foi aprovado(a) pela " +
    $"Guilda, Trolls são traidores!!");
    return;
}

else if (nível >= 5)
{
    Console.WriteLine($"\nApós a avaliação da Guilda temos o veredito! \n{nomeheroi} foi aprovado(a) " +
        $"pela Guilda e está apto para lutar contra o Dragão Vermelho 🐉");
}
else
{
    Console.WriteLine($"\nApós a avaliação da Guilda temos o veredito! \n{nomeheroi} NÃO foi " +
        $"aprovado(a) pela Guilda por nível insuficiente.");
}
Console.WriteLine("\nAgora que seu personagem foi aprovado(a), devemos realizar " +
    "o cálculo de Poder de Base...");
double PoderBase = (nível * 10) + (PontoVida / 2) - 5;
Console.WriteLine($"\n{nomeheroi} possui {PoderBase} de Poder de Base");

if (PoderBase % 2 == 0)
{
    Console.WriteLine($"\n🔥 ATAQUE CRÍTICO LENDÁRIO! 🔥\n" +
$"{nomeheroi} liberou um golpe perfeito!");
}
Console.WriteLine($"\nCom todas as informações do herói {nomeheroi}, " +
    $"\nfinalmente chegou a hora de testar seu poder contra o Dragão Vermelho 🐉!");
bool PAtacar = false;

if (classe == "Mago" || classe == "Druida" || classe == "Clérigo")
{
    if (PontoVida >= 30 && nível <= 100)
    {
        Console.WriteLine("\n Com Mana suficiente, o herói canaliza energia poderosa! " +
            "Seu cajado brilha intensamente, pronto para desferir um golpe devastador no Dragão 🐉! ✨");
        PAtacar = true;
    }
    else
    {
        Console.WriteLine("\n O herói não tem Mana suficiente para atacar! " +
            "Seu cajado está fraco e, ao tentar atingir o Dragão 🐉, você só fez cócegas nele.");

    }
}

else if (classe == "Guerreiro" || classe == "Anão" || classe == "Elfo")
{
    if (PontoVida > 20 && PoderBase > 50)
    {
        Console.WriteLine($"\nO ataque foi um sucesso!" +
            $"\nCom força impressionante, o herói atingiu o Dragão 🐉 com um golpe poderoso‼");
        PAtacar = true;
    }
    else
    {
        Console.WriteLine("\nAtaque falhou! 💔" +
            "\nO herói está fraco demais para erguer sua arma… sua força não foi suficiente" +
            "para enfrentar o Dragão 🐉!");
    }
}
if (PAtacar)
{
    Console.WriteLine($"\n🎯 DESTINO FINAL " +
        $"\n{nomeheroi} cumpriu todas as exigências da guilda! Agora está preparado(a) para desafiar" +
        $" o Dragão 🐉 e defender o reino!");
}
else
{
    if (Ouro > 1000 || classe == "Anão")
    {
        Console.WriteLine($"\nPor não poder lutar, o herói suborna 💰 o Dragão 🐉" +
            $" e consegue escapar de virar churrasco! 🍖");
    }
    else
    {
        Console.WriteLine($"\nPor não poder lutar, o herói tenta subornar 💰 o Dragão 🐉," +
            $" mas falha… e acaba virando churrasco! 🍖");
    }
}


Console.WriteLine("\nParabéns, você chegou ao Fim da avaliação do herói!");
//RPG - Victória Alves Dantas

Console.WriteLine("Bem-vindo ao RPG!");

Console.WriteLine("\nDigite o nome do seu heroi");
string nomeheroi = Console.ReadLine();
int ataqueBase = 70;
int bonusArma = 20;
int ataqueTotal = ataqueBase + bonusArma;
double vidaInimigo = 150.5;
double danoInimigo = 50.5;
double vidaRestante = vidaInimigo + danoInimigo;
float moedas = 10.5f;
float moedasDobro = moedas * 2f;
long xpTotal = 100000;
long mediaXp = xpTotal / 2;

Console.WriteLine($"Em uma mundo distante, {nomeheroi} vive com o propósito de salvar sua cidade de monstros que a pertubam." +
    $"{nomeheroi} tem uma ataque de {ataqueBase} e sua arma tem o ataque de {bonusArma} juntando a força de {nomeheroi} e sua " +
    $"arma, ele possui uma força total de {ataqueTotal}. Em certo dia {nomeheroi} encontrou seu inimigo Super Monstro, conhecido como SM, " +
    $"que possui uma vida de {vidaInimigo}." +
    $"{nomeheroi} causou o dano de {danoInimigo} em SM, o deixando com {vidaRestante}.");
Console.WriteLine($"SM foge por estar com pouca vida, {nomeheroi} ganhou {moedas} por essa batalha, como acabou ganhando, o número de moedas " +
    $"é dobrado, resultanto em {moedasDobro}. Ademais, {nomeheroi} ganhou {xpTotal} de XP por causa do combate, tendo " +
    $"{mediaXp} como média de seu nível.Assim {nomeheroi} esta pronto para enfrentar e lutar com seus inimigos, protegendo" +
    $"sua cidade de montros perigosos.");

bool EntendiMateria = true;
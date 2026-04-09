Console.OutputEncoding = System.Text.Encoding.UTF8;

//Calculadora de IMC - Victória Alves Dantas

Console.WriteLine("Lavinia🥑Good🍆Vibe🍒");
Console.WriteLine("Calculadora de IMC");
Console.WriteLine("\r\n\r\nDigite seu peso:  ");
double.TryParse(Console.ReadLine()!.Replace("." , " ,"), out double peso);
Console.WriteLine("Digite sua altura em metros:  ");
double.TryParse(Console.ReadLine().Replace(".", " ,"), out double altura);
double imc = peso / Math.Pow(altura, 2.0);

if (imc < 16.0)
{
    Console.WriteLine("\r\n\r\nClassificação: Magreza extrema (IMC abaixo de 16,0)," +
        "\n indicando risco elevado à saúde e necessidade de avaliação profissional.");
}
if (imc >= 16.0 && imc <= 16.9)
{ 
Console.WriteLine("\r\n\r\nClassificação: Magreza moderada (IMC entre 16,0 e 16,9), " +
    "\nindicando risco à saúde e necessidade de acompanhamento nutricional.");
 }
if (imc >= 17.0 && imc <= 18.4)
{ 
Console.WriteLine("\r\n\r\nClassificação: Magreza leve (IMC entre 17,0 e 18,4), " +
    "\nrecomendando cuidados com a alimentação e possíveis ajustes no estilo de vida."); 
}
if (imc >= 18.5 && imc <= 24.9)
{ 
Console.WriteLine("\r\n\r\nClassificação: Peso normal (IMC entre 18,5 e 24,9), " +
    "\nindicando um estado nutricional saudável.");
 }
if (imc >= 25.0 && imc <= 29.9)
{
    Console.WriteLine("\r\n\r\nClassificação: Sobrepeso (IMC entre 25,0 e 29,9), " +
    "\nrecomendando atenção ao peso e hábitos alimentares para prevenção de doenças.");
}
if  (imc >= 30.0 && imc <= 34.9)
{
    Console.WriteLine("\r\n\r\nClassificação: Obesidade grau II (IMC entre 35,0 e 39,9)," +
        "\ncom risco elevado à saúde e necessidade urgente de intervenção médica e/ou nutricional.");
}
if (imc > 40.0)
{
    Console.WriteLine("\r\n\r\nClassificação: Obesidade grau III (IMC acima de 40,0), " +
        "\nrisco muito elevado à saúde, exigindo acompanhamento médico imediato.");
}

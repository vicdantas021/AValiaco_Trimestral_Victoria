Console.OutputEncoding = System.Text.Encoding.UTF8;

//Registro de Fósseis - Victória Alves Dantas

Console.WriteLine("🧙 O Mago Merlin é muito sábio!! Você foi visitá-lo em sua torre mágica");

Console.WriteLine("\nPorém, algo o interrompeu de te mostrar a torre, com dois toques na porta o Mago foi ver quem era...");
Console.WriteLine("\nUma misteriosa arqueóloga que precisa de ajuda para que se registre os nomes dos fósseis que ela encontrou pela região");

for (int i = 0; i < 7; i++)
{
    Console.WriteLine("Fósseis encontrados por ela: \nDigite 1 para registrar Poríferos " +
    "\nDigite 2 para registrar Cnidários " +
    "\nDigite 3 para registrar Platelmintos" +
    "\nDigite 4 para registrar Moluscos" +
    "\nDigite 5 para registrar Anelídeos " +
    "\nDigite 6 para registrar Urocordados");

    int.TryParse(Console.ReadLine(), out int ff);


    switch (ff)
    {
        case 1:
            Console.WriteLine("Poríferos registrados com sucesso! 🐚");
            break;
        case 2:
            Console.WriteLine("Cnidários registrados com sucesso! 🐙");
            break;
        case 3:
            Console.WriteLine("Platelmintos registrados com sucesso! 🐛");
            break;
        case 4:
            Console.WriteLine("Moluscos registrados com sucesso! 🐌");
            break;
        case 5:
            Console.WriteLine("Anelídeos registrados com sucesso! 🐍");
            break;
        case 6:
            Console.WriteLine("Urocordados registrados com sucesso! 🐟");
            break;
        default:
            Console.WriteLine("Opção inválida! Tente registrar os fósseis novamente... 😕");
            break;
    }
}
Console.WriteLine("\nA arqueóloga ficou muito grata por sua ajuda 🧙✨");
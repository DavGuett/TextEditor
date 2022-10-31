static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Abrir arquivo");
    Console.WriteLine("2 - Criar novo arquivo");
    Console.WriteLine("0 - Sair");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 0:
            System.Environment.Exit(0);
            break;
        case 1:
            Open();
            break;
        case 2:
            Edit();
            break;
        default:
            Menu();
            break;
    }
}

static void Open()
{
    
}

static void Edit()
{
    
}

Menu();
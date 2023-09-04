void Main()
{
    DisplayLogo();
    ShowOptions();
    string choice = CatchInput();

    switch (choice)
    {
        case "1": // todo
            break;

        case "2": // todo
            break;

        case "3": // todo
            break;

        case "4": // todo
            break;

        default: // todo
            break;
    }
}

void DisplayLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░█████╗░██╗░░░██╗██████╗░██╗░█████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔══██╗██║░░░██║██╔══██╗██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ███████║██║░░░██║██║░░██║██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ██╔══██║██║░░░██║██║░░██║██║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██║░░██║╚██████╔╝██████╔╝██║╚█████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═╝░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░
    ");
}

void ShowOptions()
{
    Console.WriteLine(@"
Enter 1 to register a new band
Enter 2 to show all registered bands
Enter 3 to rate a band
Enter 4 to show the average of a band
Type anything to close
            ");
}

string CatchInput() {
    Console.Write("Insert: ");
    string input = Console.ReadLine()!;

    return input;
}

void RegisterNewBand()
{
    // todo
}

void ShowRegistredBands()
{
    // todo
}

Main();

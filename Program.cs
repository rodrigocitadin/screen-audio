void Main()
{
    bool loop = true;

    while (loop)
    {
        DisplayLogo();
        ShowOptions();
        string choice = CatchInput();

        switch (choice)
        {
            case "1":
                RegisterNewBand();
                break;

            case "2":
                ShowRegisteredBands();
                break;

            case "3":
                RateBand();
                break;

            case "4":
                ShowBandAverage();
                break;

            default:
                Console.WriteLine("\nBye bye :)\n");
                loop = false;
                break;
        }
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

string CatchInput()
{
    Console.Write("Insert: ");
    string input = Console.ReadLine()!;

    return input;
}

void RegisterNewBand()
{
    Console.Clear();
    Console.WriteLine("What is the band name?");

    string input = CatchInput();

    Console.WriteLine("Registered band!");
    Thread.Sleep(2500);
    Console.Clear();
}

void ShowRegisteredBands()
{
    // todo
}

void RateBand()
{
    // todo
}

void ShowBandAverage()
{
    // todo
}

Main();

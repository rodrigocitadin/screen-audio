List<string> bandsList = new List<string>();

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
                Console.Clear();
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

    string band = CatchInput();
    bandsList.Add(band);

    Console.WriteLine("Registered band!");
    Thread.Sleep(1500);
    Console.Clear();
}

void ShowRegisteredBands()
{
    Console.Clear();
    Console.WriteLine("These are the bands you registered:\n");

    for (int i = 0; i < bandsList.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {bandsList[i]}");
    }
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

// List<string> bandsList = new List<string>();
Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>();

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
    ShowTitle("What is the band name?");

    string band = CatchInput();
    bandsList.Add(band);

    Console.WriteLine("Registered band!");
    Thread.Sleep(1000);
    Console.Clear();
}

void ShowRegisteredBands()
{
    ShowTitle("These are the bands you registered");

    for (int i = 0; i < bandsList.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {bandsList[i]}");
    }

    Console.WriteLine("\nPress any key to return to the menu");
    Console.ReadKey();
    Console.Clear();
}

void RateBand()
{
    // todo
}

void ShowBandAverage()
{
    // todo
}

void ShowTitle(string title)
{
    string asterisks = string.Empty.PadLeft(title.Length);

    Console.Clear();
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks);
    Console.WriteLine();
}

Main();

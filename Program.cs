Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>();
string[] bandsArray = bands.Keys.ToArray();

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
    Console.Clear();
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
    bands.Add(band, new List<int>());

    Console.WriteLine("Registered band!");
    Thread.Sleep(1000);
}

void ShowRegisteredBands()
{
    ShowTitle("These are the bands you registered");
    ListBands();

    Console.WriteLine("\nPress any key to return to the menu");
    Console.ReadKey();
}

void RateBand()
{
    ShowTitle("Rating a band");
    ListBands();

    Console.Write("\nChoose a band number to rate: ");
    string band = Console.ReadLine()!;

    int bandNumber;

    if (int.TryParse(band, out bandNumber) && bandNumber <= bandsArray.Length)
    {
        ShowTitle("Rating a band");
        Console.Write($"What rating would you like to give the {bandsArray[bandNumber - 1]} band? ");
        string rate = Console.ReadLine()!;
        int rateNumber;

        if (int.TryParse(rate, out rateNumber))
        {
            bands[bandsArray[bandNumber - 1]].Add(rateNumber);
            Console.WriteLine("The note was added successfully");
            Thread.Sleep(1500);
        }
        else
        {
            Console.WriteLine("\nPlease insert a number");
            Console.WriteLine("\nPress any key to return to the menu");
            Console.ReadKey();
        }
    }
    else
    {
        Console.WriteLine("\nBand not found!");
        Console.WriteLine("\nPress any key to return to the menu");
        Console.ReadKey();
    }
}

void ShowBandAverage()
{
    // todo
}

void ShowTitle(string title)
{
    string asterisks = string.Empty.PadLeft(title.Length, '*');

    Console.Clear();
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks);
    Console.WriteLine();
}

void ListBands()
{
    for (int i = 0; i < bandsArray.Length; i++)
    {
        Console.WriteLine($"{i + 1}: {bandsArray[i]}");
    }
}

Main();

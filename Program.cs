using ScreenSound.Menus;
using ScreenSound.Models;

Dictionary<string, Band> bands = new();
string[] bandsArray;

void Main()
{
    bool loop = true;

    while (loop)
    {
        bandsArray = bands.Keys.ToArray();

        DisplayLogo();
        ShowOptions();
        string choice = CatchInput();

        switch (choice)
        {
            case "1":
                MenuRegisterBand register = new();
                register.Execute(bands);
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
Enter 4 to show the average all bands
Type anything to close
            ");
}

string CatchInput()
{
    Console.Write("Insert: ");
    string input = Console.ReadLine()!;

    return input;
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
    string input = Console.ReadLine()!;
    int bandNumber;

    if (!(int.TryParse(input, out bandNumber) && bandNumber <= bandsArray.Length))
    {
        Console.WriteLine("\nBand not found!");
        Console.WriteLine("\nPress any key to return to the menu");
        Console.ReadKey();
        
        return;
    }

    ShowTitle("Rating a band");
    Console.Write($"What rating would you like to give the {bandsArray[bandNumber - 1]} band? ");
    string rating = Console.ReadLine()!;
    int ratingNumber;

    if (!(int.TryParse(rating, out ratingNumber)))
    {
        Console.WriteLine("\nInvalid input");
        Console.WriteLine("\nPress any key to return to the menu");
        Console.ReadKey();

        return;
    }

    bool success = bands[bandsArray[bandNumber - 1]].AddRating(ratingNumber);

    if(!success)
    {
        Console.WriteLine("\nThe rating must be in the range of 0 to 10");
        Console.WriteLine("\nPress any key to return to the menu");
        Console.ReadKey();

        return;
    } 

    Console.WriteLine("The note was added successfully");
    Thread.Sleep(1500);
}

void ShowBandAverage()
{
    ShowTitle("Average band rating");

    for (int i = 0; i < bandsArray.Length; i++)
    {
        if (bands[bandsArray[i]].Rating.Count == 0)
        {
            Console.WriteLine($"{i + 1}: {bandsArray[i]} is unrated");
            continue;
        }

        string average = String.Format("{0:0.00}", bands[bandsArray[i]].Average);

        Console.WriteLine($"{i + 1}: {bandsArray[i]} has an average of {average}");
    }

    Console.WriteLine("\nPress any key to return to the menu");
    Console.ReadKey();
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

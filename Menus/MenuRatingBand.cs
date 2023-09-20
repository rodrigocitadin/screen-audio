using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRatingBand : Menu
{
    public void Execute(Dictionary<string, Band> bands)
    {
    ShowTitle("Rating a band");
    string[] bandsArray = ListBands(bands);

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
}

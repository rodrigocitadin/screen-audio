using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuBandAverage : Menu
{
    public void Execute(Dictionary<string, Band> bands)
    {
        ShowTitle("Average band rating");
        string[] bandsArray = ListBands(bands);

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
}

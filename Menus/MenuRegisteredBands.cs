using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegisteredBands : Menu
{
    public void Execute(Dictionary<string, Band> bands)
    {
        ShowTitle("These are the bands you registered");

        ListBands(bands);

        Console.WriteLine("\nPress any key to return to the menu");
        Console.ReadKey();
    }
}

using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegisterBand : Menu
{
    public void Execute(Dictionary<string, Band> bands)
    {
        ShowTitle("What is the band name?");

        string bandName = CatchInput("Insert the band name: ");
        bands.Add(bandName, new(bandName));

        Console.WriteLine("Band successfully registered!");
        Thread.Sleep(1000);
    }
}

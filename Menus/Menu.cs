namespace ScreenSound.Menus;

internal class Menu
{
    public void ShowTitle(string title)
    {
        string asterisks = string.Empty.PadLeft(title.Length, '*');

        Console.Clear();
        Console.WriteLine(asterisks);
        Console.WriteLine(title);
        Console.WriteLine(asterisks);
        Console.WriteLine();
    }

    public string CatchInput(string text)
    {
        Console.Write(text);
        string input = Console.ReadLine()!;

        return input;
    }
}

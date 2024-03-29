﻿using ScreenSound.Menus;
using ScreenSound.Models;

Dictionary<string, Band> bands = new();

void Main()
{
    bool loop = true;

    while (loop)
    {
        DisplayLogo();
        ShowOptions();

        Console.Write("Insert: ");
        string choice = Console.ReadLine()!;

        switch (choice)
        {
            case "1":
                MenuRegisterBand register = new();
                register.Execute(bands);
                break;

            case "2":
                MenuRegisteredBands registered = new();
                registered.Execute(bands);
                break;

            case "3":
                MenuRatingBand rating = new();
                rating.Execute(bands);
                break;

            case "4":
                MenuBandAverage average = new();
                average.Execute(bands);
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

Main();

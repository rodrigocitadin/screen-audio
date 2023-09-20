namespace ScreenSound.Models;

internal interface IRateable
{
    bool AddRating(double rating);
    double Average { get; }
}

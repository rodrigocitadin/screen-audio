namespace ScreenSound.Models;

class Band
{
    public Band(string name)
    {
        Name = name;
        Albums = new();
        Rating = new();
    }

    public string Name { get; }
    public List<Album> Albums { get; }
    public List<double> Rating { get; }
    public double Average => Rating.Average(); 

    public void AddAlbum(Album album)
    {
        Albums.Add(album);
    }

    public void RemoveAlbum(Album album)
    {
        Albums.Remove(album);
    }

    public void RemoveAlbumById(int index)
    {
        Albums.RemoveAt(index);
    }

    public bool AddRating(double rating)
    {
        if (rating >= 0 && rating <= 10)
        {
            Rating.Add(rating);

            return true;
        }
            
        return false;
    }
}

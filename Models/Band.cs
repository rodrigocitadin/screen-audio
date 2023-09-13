class Band
{
    public Band(string name)
    {
        Name = name;
        Albums = new List<Album>();
    }

    public string Name { get; }
    public List<Album> Albums { get; }


    public void AddAlbum(Album album)
    {
        Albums.Add(album);
    }

    public void RemoveAlbum(Album album)
    {
        Albums.Remove(album);
    }

    public void RemoveMusicById(int index)
    {
        Albums.RemoveAt(index);
    }
}

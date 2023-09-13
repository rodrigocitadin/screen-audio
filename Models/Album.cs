class Album
{
    public Album(string name, List<Music> musics)
    {
       Name = name;
       Musics = musics;
    } 

    public string Name { get; }
    public List<Music> Musics { get; }
    public int DurationInSeconds => Musics.Sum(m => m.DurationInSeconds);

    public void AddMusic(Music music)
    {
        Musics.Add(music);
    }

    public void RemoveMusic(Music music)
    {
        Musics.Remove(music);
    }

    public void RemoveMusicById(int index)
    {
        Musics.RemoveAt(index);
    }
}

class Music
{
    public Music(string name, int durationInSeconds)
    {
        Name = name;
        DurationInSeconds = durationInSeconds;
    }

    public string Name { get; }
    public int DurationInSeconds { get; }
}

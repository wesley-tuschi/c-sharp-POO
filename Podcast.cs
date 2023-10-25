class Podcast {
    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;

    }

    private List<Episode> episodes = new List<Episode>();
    public string Host
    {
        get;
    }
    public string Name
    {
        get;
    }
    public int TotalEpisodes => episodes.Count;

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Podcast: {Name}");
        Console.WriteLine($"Apresentado por: {Host}");
        Console.WriteLine($"Total de episódios: {TotalEpisodes}\n");

        foreach (Episode episode in episodes.OrderBy(episode => episode.Order))
        {
            Console.WriteLine(episode.Resume);
        }
    }
}
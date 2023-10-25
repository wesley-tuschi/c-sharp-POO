class Album
{
    private List<Music> musics = new List<Music>();

    public Album(string name)
    {
        Name = name;
    }
    public string Name { get; }
    public int Duration => musics.Sum(music => music.Duration);

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }
}

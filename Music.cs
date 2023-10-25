class Music
{
    public Music(Band artist, string name) {
       Artist = artist;
       Name = name;
    }
    public string Name
    {
        get;
    }
    public Band Artist
    {
        get;
    }
    public int Duration
    {
        get; set;
    }
    public bool Disponibility
    {
        get; set;
    }

    public void ShowDataSheet()
    {
        Console.WriteLine($"Música: {Name}");
        Console.WriteLine($"Artista: {Artist.Name}");
        Console.WriteLine($"Duração: {Duration} segundos");
        Console.WriteLine($"Disponível: {(Disponibility ? "Sim" : "Não")}\n");
    }
}

class Episode
{
    private List<string> guests = new();
    public Episode(int duration, int order, string title)
    {
        Duration = duration;
        Order = order;
        Title = title;
    }
    public int Duration { get; }
    public int Order { get; }
    public string Title { get; }
    public string Resume => $"{Order} - {Title} - {Duration} minutos - {string.Join(", ", guests)}";

    public void AddGuest(string guest)
    {
        guests.Add(guest);
    }
}
Band cicero = new Band("Cícero");
Album albumCicero = new Album("Canções de Apartamento");

Music music1 = new Music(cicero, "Tempo de Pipa")
{
    Duration = 180,
    Disponibility = true

};
Music music2 = new Music(cicero, "Pelo Interfone")
{
    Duration = 240,
    Disponibility = false
};

albumCicero.AddMusic(music1);
albumCicero.AddMusic(music2);
cicero.AddAlbum(albumCicero);

cicero.ShowDiscography();

music1.ShowDataSheet();
music2.ShowDataSheet();

Episode ep1 = new Episode(45, 1, "O começo de tudo");

ep1.AddGuest("Gustavo");
ep1.AddGuest("Guilherme");

Episode ep2 = new Episode(45, 2, "O retorno da revanche");
ep2.AddGuest("Vinicius");
ep2.AddGuest("Rodrigo");
ep2.AddGuest("Mauricio");

Podcast podcast = new Podcast("Hipsters Ponto Tech", "Caelum");
podcast.AddEpisode(ep1);
podcast.AddEpisode(ep2);

podcast.ShowDetails();
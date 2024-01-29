// Titualar e Conta
Titular titular = new Titular("Jose", "M");
Conta conta = new Conta(91, 123456, 100f, 1000f, titular);

conta.ExibirInformacoes();
Console.WriteLine(conta.Informacoes);

// Musicas
Banda banda = new Banda("The Police");
Musica musica1 = new Musica(banda, "Roxane");
musica1.Duracao = 273;
musica1.Disponivel = true;
musica1.Genero = new Genero("Rock");

banda = new Banda("U2");
Musica musica2 = new Musica(banda, "Vertigo")
{
    Duracao = 367,
    Disponivel = false,
    Genero = new Genero("Rock")
};

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();


// Album, Banda, Musicas
banda = new Banda("Led Zeppelin");
Genero generoRock = new Genero("Rock");
Album albumLedZeppelin = new Album("Led Zeppelin");

musica1 = new Musica(banda, "Kashmir");
musica1.Duracao = 273;
musica1.Genero = generoRock;

musica2 = new Musica(banda, "Trampled Under Foot");
musica2.Duracao = 367;
musica1.Genero = generoRock;

albumLedZeppelin.AdicionarMusica(musica1);
albumLedZeppelin.AdicionarMusica(musica2);

albumLedZeppelin.ExibirMusicasDoAlbum();

// Bandas e Albuns
banda.AdicionarAlbum(albumLedZeppelin);
banda.ExibirDiscografia();

// Podcasts e Episodios

Episodio episodio1 = new Episodio(1, "UFOs", 60);
episodio1.AdicionarConvidados("João");
episodio1.AdicionarConvidados("Joana");

Console.WriteLine(episodio1.Resumo);

Episodio episodio2 = new Episodio(2, "Tubarões", 50);
episodio2.AdicionarConvidados("Martins");

Episodio episodio3 = new Episodio(3, "Super aviões", 120);
episodio3.AdicionarConvidados("Lucio");
episodio3.AdicionarConvidados("Lucia");

Podcast podcast = new Podcast("Coisas Surpreendentes", "Eli Jones");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio3);
podcast.AdicionarEpisodio(episodio2);

podcast.ExibirDetalhes();

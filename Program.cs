Musica musica1 = new Musica();

musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;

Musica musica2 = new Musica();

musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

musica1 = new Musica();
musica2 = new Musica();

Album albumLedZeppelin = new Album();
albumLedZeppelin.Nome = "Led Zeppelin";

musica1.Nome = "Kashmir";
musica1.Duracao = 273;
albumLedZeppelin.AdicionarMusica(musica1);

musica2.Nome = "Trampled Under Foot";
musica2.Duracao = 367;
albumLedZeppelin.AdicionarMusica(musica2);

albumLedZeppelin.ExibirMusicasDoAlbum();


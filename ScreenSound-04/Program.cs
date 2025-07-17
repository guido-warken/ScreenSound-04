
using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        //var musicasPreferidasEmilly = new MusicasPreferidas("Emy");

        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[500]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[637]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[428]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[13]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[71]);

        //musicasPreferidasEmilly.ExibirMusicasFavoritas();
        //musicasPreferidasEmilly.GerarArquivoJson();

        //musicas[0].ExibirFichaTecnica();
        //musicas[1].ExibirFichaTecnica();
        LinqFilter.FiltrarMusicasComTonalidadeDoSustenido(musicas);
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas);
        //LinqFilter.FiltrarMusicasPorArtista(musicas);
        //LinqOrder.ExibirListaDeArtistasFiltrados(musicas);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
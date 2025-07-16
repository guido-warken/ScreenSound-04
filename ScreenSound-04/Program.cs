
using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[0].ExibirFichaTecnica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas);
        LinqFilter.FiltrarMusicasPorArtista(musicas);
        //LinqOrder.ExibirListaDeArtistasFiltrados(musicas);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
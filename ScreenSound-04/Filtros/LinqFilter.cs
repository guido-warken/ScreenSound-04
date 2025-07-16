using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var generosMusicais = musicas
            .Select(m => m.Genero)
            .Distinct()
            .ToList();

        foreach (var genero in generosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas)
    {
        Console.WriteLine("Digite o gênero");
        string? genero = Console.ReadLine();
        var artistasFiltrados = musicas
            .Where(m => m.Genero.Contains(genero))
            .Select(m => m.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine($"Exibindo os artistas do gênero {genero}");

        artistasFiltrados.ForEach(Console.WriteLine);
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas)
    {
        Console.WriteLine("Digite o nome do artista");
        string? artista = Console.ReadLine();
        var musicasFiltradas = musicas
            .Where(m => m.Artista.Equals(artista))
            .ToList();
        if (musicasFiltradas.Count == 0)
        {
            Console.WriteLine($"Nenhuma música encontrada para o artista {artista}");
            return;
        }
        Console.WriteLine($"Exibindo as músicas do artista {artista}");
        musicasFiltradas.ForEach(m => m.ExibirFichaTecnica());
    }
}
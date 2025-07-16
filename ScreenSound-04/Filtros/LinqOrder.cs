using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasFiltrados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas
            .OrderBy(m => m.Artista)
            .Select(m => m.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine("Lista de artistas ordenados: ");

        artistasOrdenados.ForEach(Console.WriteLine);
    }
}

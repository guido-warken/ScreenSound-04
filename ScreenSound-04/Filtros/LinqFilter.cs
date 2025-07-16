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
}

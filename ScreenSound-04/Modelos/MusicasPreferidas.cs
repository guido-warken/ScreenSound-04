
using System.Text.Json;

namespace ScreenSound_04.Modelos;

internal class MusicasPreferidas
{

    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {

        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new { nome = Nome, musicas = ListaDeMusicasFavoritas});
        string nomeArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeArquivo, json);
        Console.WriteLine($"Arquivo json gerado com sucesso no caminho {Path.GetFullPath(nomeArquivo)}");
    }
}
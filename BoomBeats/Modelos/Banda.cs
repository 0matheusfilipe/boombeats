namespace BoomBeats.Modelos;

internal class Banda : IAvaliavel
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota); //para cada avaliação "a", use a propriedade "Nota" para calcular a função média.
        }
    }
    public string? Resumo { get; set; }

    //public List<Album> Albuns => albuns;
    public IEnumerable<Album> Albuns => albuns;
    /*Ao mudar para IEnumerable:
    Você está efetivamente "escondendo" a implementação interna (List) e expondo apenas a interface de leitura. Isso significa que o código externo pode iterar sobre os álbuns, mas não pode modificá-los diretamente.
    Esta abordagem segue o princípio de "programar para interfaces, não para implementações", o que torna seu código mais robusto, flexível e menos propenso a erros causados por uso indevido da classe.
     */
    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }

    
}
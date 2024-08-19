using Exercicios.Filmes;

    public class Program
    {
        static void Main(string[] args)
        {
        Filme filme1 = new Filme("Simplesmente Acontece", 102, new List<string>() { "Lily Collins", "Sam Claflin"});
        Filme filme2 = new("Como Eu Era Antes de Você", 110, new List<string>() { "Sam Claflin", "Emilia Clarke"});
        Filme filme3 = new("Harry Potter e as Relíquias da Morte (Parte 2)", 130, new List<string>() { "Daniel Radcliffe", "Emma Watson", "Rupert Grint"});
        Filme filme4 = new("Jogos vorazes - Em Chamas", 146, new List<string>() { "Jennifer Lawrence", "Josh Hutcherson", "Sam Claflin"});
        Filme filme5 = new("Garota Exemplar", 145, new List<string>() { "Rosamund Pike", "Ben Affleck"});

        List<Filme> filmesFavoritosDaGabi = new List<Filme>();
        filmesFavoritosDaGabi.Add(filme1);
        filmesFavoritosDaGabi.Add(filme2);
        filmesFavoritosDaGabi.Add(filme3);
        filmesFavoritosDaGabi.Add(filme4);
        filmesFavoritosDaGabi.Add(filme5);

            foreach (Filme f in filmesFavoritosDaGabi)
            {
                Console.WriteLine($"Filme: {f.Titulo}");
                Console.WriteLine($"Duracao: {f.Duracao}");
                f.ListarElenco();
                Console.WriteLine();
            }
        }
    }


using BoomBeats.Menus;
using BoomBeats.Modelos;

Banda bacoExuDoBlues = new Banda("Baco Exu do Blues");
Banda bk = new("BK");
Banda djonga = new("Djonga");
Banda aJuliaCosta = new("Ajuliacosta");
Banda kayBlack = new("KayBlack");
Banda l7nnon = new("L7NNON");
Banda majorRd = new("Major RD");
bacoExuDoBlues.AdicionarNota(new Avaliacao(10));
bacoExuDoBlues.AdicionarNota(new Avaliacao(8));
bacoExuDoBlues.AdicionarNota(new Avaliacao(6));

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(bacoExuDoBlues.Nome, bacoExuDoBlues);
bandasRegistradas.Add(bk.Nome, bk);
bandasRegistradas.Add(djonga.Nome, djonga);
bandasRegistradas.Add(aJuliaCosta.Nome, aJuliaCosta);
bandasRegistradas.Add(kayBlack.Nome, kayBlack);
bandasRegistradas.Add(l7nnon.Nome, l7nnon);
bandasRegistradas.Add(majorRd.Nome, majorRd);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuAvaliarBanda());
opcoes.Add(4, new MenuAvaliarAlbum());
opcoes.Add(5, new MenuMostrarBandas());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"
░░░░░░░  ██████╗░░█████╗░░█████╗░███╗░░░███╗  ██████╗░███████╗░█████╗░████████╗░██████╗  ░░░░░░░
██████╗  ██╔══██╗██╔══██╗██╔══██╗████╗░████║  ██╔══██╗██╔════╝██╔══██╗╚══██╔══╝██╔════╝  ██████╗
╚═════╝  ██████╦╝██║░░██║██║░░██║██╔████╔██║  ██████╦╝█████╗░░███████║░░░██║░░░╚█████╗░  ╚═════╝
██████╗  ██╔══██╗██║░░██║██║░░██║██║╚██╔╝██║  ██╔══██╗██╔══╝░░██╔══██║░░░██║░░░░╚═══██╗  ██████╗
╚═════╝  ██████╦╝╚█████╔╝╚█████╔╝██║░╚═╝░██║  ██████╦╝███████╗██║░░██║░░░██║░░░██████╔╝  ╚═════╝
░░░░░░░  ╚═════╝░░╚════╝░░╚════╝░╚═╝░░░░░╚═╝  ╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░╚═════╝░  ░░░░░░░");
    Console.WriteLine("Boas vindas ao Boom Beats 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para avaliar um álbum");
    Console.WriteLine("Digite 5 para mostrar todas as bandas");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0)
        {
            ExibirOpcoesDoMenu();
        }
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ExibirOpcoesDoMenu();
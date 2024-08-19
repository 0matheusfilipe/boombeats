using OpenAI_API;
using BoomBeats.Modelos;
using System.Threading.Tasks;

namespace BoomBeats.Menus;
internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        //Não implementado ainda
        /*var client = new OpenAIAPI("<chave api chatgpt>");
        var chat = client.Chat.CreateConversation();
        chat.AppendSystemMessage($"Resuma a banda/artista {nomeDaBanda} em 1 parágrafo.);

        // Utilizando await para aguardar a resposta do chatbot
        var resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        banda.Resumo = resposta;*/

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}

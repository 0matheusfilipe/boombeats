using BoomBeats.Modelos;

namespace BoomBeats.Menus
{
    internal class Menu
    {
        public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();

        }
        public void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '-');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }
    }
}

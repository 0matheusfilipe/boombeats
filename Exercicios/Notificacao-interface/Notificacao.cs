using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Notificacao_interface
{
    public class Email : INotificavel
    {
        public string EnderecoEmail { get; set; }

        public void EnviarNotificacao()
        {
            Console.WriteLine($"Enviando e-mail para {EnderecoEmail}: Notificação importante!");
        }
    }

    public class SMS : INotificavel
    {
        public string NumeroTelefone { get; set; }

        public void EnviarNotificacao()
        {
            Console.WriteLine($"Enviando SMS para {NumeroTelefone}: Notificação importante!");
        }
    }
}

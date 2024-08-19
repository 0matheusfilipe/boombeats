using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ProdutosEletronicos;

internal class ProdutoEletronico
{
    public string Modelo { get; set; }
    public double Preco { get; set; }

    public virtual string ExibirInformacoes()
    {
        return $"Modelo: {Modelo}, Preço: {Preco:C}";
    }
}

class Smartphone : ProdutoEletronico
{
    public string SistemaOperacional { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, SO: {SistemaOperacional}";
    }
}

class Tablet : ProdutoEletronico
{
    public string TipoTela { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, Tela: {TipoTela}";
    }
}

class Laptop : ProdutoEletronico
{
    public string Processador { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, Processador: {Processador}";
    }
}

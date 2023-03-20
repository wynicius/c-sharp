using System;
using System.Globalization;

public class Estoque {
    public string Nome;

    public double Preco;

    public int Quantidade;

    // Abaixo seguem contrutores padrões e de sobrecarga.

    public Estoque() {
    }

    public Estoque(string nome, double preco, int quantidade) {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public Estoque(string nome, double preco) {
        Nome = nome;
        Preco = preco;
    }

    public double ValorTotalEmEstoque() {
        return Preco * Quantidade;
    }

    public void AdicionarProdutos(int quantidade) {
        Quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade) {
        Quantidade -= quantidade;
    }

    public override string ToString() {
        return $"{Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
    }


}

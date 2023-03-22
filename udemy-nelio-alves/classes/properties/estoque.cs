using System;
using System.Globalization;

public class Estoque {

    // Atributos Privados
    private string _nome;

    // Propriedades Autoimplementadas
    public double Preco { get; set; }

    public int Quantidade { get; set; }

    // Construtores
    public Estoque() {
    }

    public Estoque(string nome, double preco, int quantidade) {
        _nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    // Propriedades Customizadas
    private string Nome {
        get { return _nome; }
        set {
            if (value != null && value.Length > 1) {
                _nome = value;
            }
        }
    }

    // Métodos
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

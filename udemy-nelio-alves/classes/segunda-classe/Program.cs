using System;
using System.Globalization;

System.Console.WriteLine("Entre os dados do produto:");
System.Console.Write("Nome: ");
    string nome = Console.ReadLine();

System.Console.Write("Preço: ");
    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.WriteLine("Quantidade no estoque: ");
    int quantidade = int.Parse(Console.ReadLine());

// Construtor com argumentos
Estoque p = new Estoque(nome,preco,quantidade);
// Construtor padrão
Estoque p2 = new Estoque();
// Construtor de Sintaxe Alternativa para inicializar valores.
Estoque p3 = new Estoque{
    Nome = "TV", 
    Preco = 500.00, 
    Quantidade = 20
};

System.Console.WriteLine("Dados do produto: " + p);

System.Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
    int qte = int.Parse(Console.ReadLine());

p.AdicionarProdutos(qte);

System.Console.WriteLine($"Dados atualizados: {p}");

System.Console.Write("Digite o número de produtos a serem removidos ao estoque: ");
qte = int.Parse(Console.ReadLine());

p.RemoverProdutos(qte);

System.Console.WriteLine($"Dados atualizados: {p}");
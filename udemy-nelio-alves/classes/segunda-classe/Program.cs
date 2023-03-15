using System;
using System.Globalization;

Estoque X = new Estoque();

System.Console.WriteLine("Entre os dados do produto:");
System.Console.Write("Nome: ");
    X.Nome = Console.ReadLine();

System.Console.Write("Preço: ");
    X.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.WriteLine("Quantidade no estoque: ");
    X.Quantidade = int.Parse(Console.ReadLine());

System.Console.WriteLine("Dados do produto: " + X);

System.Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
int qte = int.Parse(Console.ReadLine());
X.AdicionarProdutos(qte);

System.Console.WriteLine($"Dados atualizados: {X}");

System.Console.Write("Digite o número de produtos a serem removidos ao estoque: ");
qte = int.Parse(Console.ReadLine());

X.RemoverProdutos(qte);

System.Console.WriteLine($"Dados atualizados: {X}");
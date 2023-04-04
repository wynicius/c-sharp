// Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N Produtos. Armazene os N produtos em um vetor. Em seguida, mostrar o preço médio dos produtos.

using System.Globalization;

System.Console.WriteLine("Let's calculate the average prices of your products!");
System.Console.Write("How many products will be? ");
int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Products[] vect = new Products[n];

for (int i = 0; i < n; i++) {
    System.Console.Write("Enter the name of the product: ");
    string name = Console.ReadLine();
    System.Console.Write("Enter the price of the product: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    vect[i] = new Products { Name = name, Price = price };

}

double sum = 0.0;

for (int i = 0; i < n; i++) {
    sum += vect[i].Price;
}

double avgPrice = sum / n;

System.Console.WriteLine("AVERAGE PRICE = " + avgPrice.ToString("F2", CultureInfo.InvariantCulture));




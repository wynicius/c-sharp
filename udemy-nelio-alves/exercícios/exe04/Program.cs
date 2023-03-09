using System;
using System.Globalization;

Console.WriteLine("Vamos calcular médias ponderadas!");
Console.Write("Digite o número de alunos do semestre letivo: ");
int N = int.Parse(Console.ReadLine());

double p1 = 0.0, p2 = 0.0, p3 = 0.0, M = 0.0;

for (int i = 0; i < N; i++)
{
    Console.Write("Digite as três notas do semestre, separando-as por espaços, e aperte enter: ");
    string[] line = Console.ReadLine().Split(' ');
    p1 = double.Parse(line[0], CultureInfo.InvariantCulture);
    p2 = double.Parse(line[1], CultureInfo.InvariantCulture);
    p3 = double.Parse(line[2], CultureInfo.InvariantCulture);

    M = (p1 * 2 + p2 * 3 + p3 * 5) / 10;
    Console.WriteLine(M.ToString("F1", CultureInfo.InvariantCulture));
}


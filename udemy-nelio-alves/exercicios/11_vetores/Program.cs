// Fazer um programa para ler um número inteiro N e a altura de N pessoas. Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas pessoas.

using System;
using System.Globalization;

System.Console.WriteLine("Let's calculate the average height of a group!");
System.Console.Write("How many people are there in your experiment? ");
int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double[] heights = new double[n];

for (int i = 0; i < n; i++) {
    System.Console.Write("Enter a height: ");
    heights[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double averageHeight = 0, sum = 0;

for (int i = 0; i < n; i++) {
    sum += heights[i];
    averageHeight = sum / heights.Length;
}

System.Console.WriteLine("AVERAGE HEIGHT = " + averageHeight.ToString("F2", CultureInfo.InvariantCulture));
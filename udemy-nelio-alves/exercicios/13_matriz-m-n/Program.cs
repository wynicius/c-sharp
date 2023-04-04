// Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas contendo números inteiros, podendo haver repetições. 
// Em seguida, ler um número inteiro X que pertence à matriz. 
// Para cada ocorrência de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver, conforme exemplo.

using System;
using System.Collections.Generic;

Console.WriteLine("Create a Matrix!");
Console.Write("How many rows will be? ");
int m = int.Parse(Console.ReadLine());
Console.Write("How many columns will be? ");
int n = int.Parse(Console.ReadLine());

int[,] mat = new int[m,n];

for (int i = 0; i < m; i++) {
    Console.Write("Enter the " + (i+1) + "º row's values: ");
    string[] values = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++) {
        mat[i, j] = int.Parse(values[j]);
    }
}

Console.Write("Enter a int that is in the matrix: ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        if (mat[i,j] == x) {
            Console.WriteLine($"Position (${i},${j}):");
            Console.WriteLine($"Left: ${mat[i,j]}"); 
            Console.WriteLine($"Right: ${mat[i,j]}"); 
            Console.WriteLine($"Down: ${mat[i,j]}"); 
        }
    }
}
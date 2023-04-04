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
    Console.Write("Enter the values for the " + (i+1) + "th row, separated by spaces: ");
    string[] values = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++) {
        mat[i, j] = int.Parse(values[j]);
    }
}    
Console.WriteLine();

Console.Write("Enter a int that is in the matrix: ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        if (mat[i,j] == x) {
            Console.WriteLine($"Position ({i},{j}):");
            if (j > 0) {
                Console.WriteLine("Left: " + mat[i, j - 1]);
            }
            if (i > 0) {
                Console.WriteLine("Up: " + mat[i - 1, j]);
            }
            if (j < n - 1) {
                Console.WriteLine("Right: " + mat[i, j + 1]);
            }
            if (i < m - 1) {
                Console.WriteLine("Down: " + mat[i + 1, j]);
            } 
        }
    }
}
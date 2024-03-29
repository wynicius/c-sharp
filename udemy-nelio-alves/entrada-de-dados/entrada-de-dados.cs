﻿using System.Globalization;

// //  O comando de entrada é : Console.ReadLine();

// //  Lê da entrada padrão até a quebra de linha, que é quando o usuário aperta a tecla ENTER.
// //  Retorna os dados lidos na forma de STRING

// // Exercício: Escreva um código em que o usuário escreva três frutas separadas por espaços, depois separe cada fruta (.Split(' ')) em posições vetoriais de uma variável de vetor  -> [] :

// // string s = Console.ReadLine();
// // string[] frutas = s.Split(' ');

// // porem existem uma maneira mais compacta de escrever os códigos acima, assim:

// string[] frutas = Console.ReadLine().Split(' ');

// string s0 = frutas[0];
// string s1 = frutas[1];
// string s2 = frutas[2];

// System.Console.WriteLine(s0);
// System.Console.WriteLine(s1);
// System.Console.WriteLine(s2);


// PARTE 2 DA AULA DE ENTRADA DE DADOS:
System.Console.Write("Digite a idade: "); // input idade
int n1 = int.Parse(Console.ReadLine());

System.Console.Write("Digite o Sexo: "); // input sexo
char ch = char.Parse(Console.ReadLine());

System.Console.Write("Digite a altura: "); // input altura
double dbl = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.Write("Digite o nome: "); // input nome
string nm = Console.ReadLine();

//Aqui eu unifico tudo em uma string, faço um Split nela e atribuo à uma uma variável vetorial, para praticar
string[] vet = $"{nm} {ch} {n1} {dbl.ToString(CultureInfo.InvariantCulture)}".Split(' ');

// Converto tudo de novo, praticando a posição dos vetores.
string nome = vet[0];
char sexo = char.Parse (vet[1]);
int idade = int.Parse (vet[2]);
double altura = double.Parse (vet[3], CultureInfo.InvariantCulture);

// OUTPUTS Resultados
System.Console.WriteLine(nome);
System.Console.WriteLine(sexo);
System.Console.WriteLine(idade);
System.Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));

using System;
using System.Globalization;

Aluno aluno = new Aluno();

System.Console.Write("Nome do Aluno: ");
aluno.Nome = Console.ReadLine();

System.Console.WriteLine("Digite as três notas do aluno: ");
aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.WriteLine("NOTA FINAL = " 
    + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

System.Console.WriteLine(aluno);
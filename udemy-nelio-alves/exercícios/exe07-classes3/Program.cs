using System;
using System.Globalization;

Funcionario func = new Funcionario();

System.Console.Write("Nome: ");
func.Nome = Console.ReadLine();

System.Console.Write("Salário bruto: ");
func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.Write("Imposto: ");
func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.WriteLine(func);

System.Console.WriteLine($"Digite a porcentagem de aumento para o salário de {func.Nome}: ");
double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
func.AumentarSalario(porcentagem);

System.Console.WriteLine("Dados atualizados: " + func);

// Fazer um programa para ler os dados (nome, email e salário) de funcionários a partir de um arquivo em formato .csv.
// Em seguida mostrar, em ordem alfabética, o email dos funcionários cujo salário seja superior a um dado valor fornecido pelo usuário.
// Mostrar também a soma dos salários dos funcionários cujo nome começa com a letra 'M'.

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

List<Employees> employees = new List<Employees>();

string path = @"C:\Users\User1\Desktop\coding\c-sharp\udemy-nelio-alves\linq2\employees.csv";
string csvContent = "Maria,maria@gmail.com,3200.00\n"
                +   "Alex,alex@gmail.com,1900.00\n"
                +   "Marco,marco@gmail.com,1700.00\n"
                +   "Bob,bob@gmail.com,3500.00\n"
                +   "Anna,anna@gmail.com,2800.00";

Console.WriteLine("Enter the salary for assay:");
double assaySalary = double.Parse(Console.ReadLine()); // 2000.00

File.WriteAllText(path, csvContent);

using (StreamReader sr = new StreamReader(path))
{
    while (!sr.EndOfStream)
    {
        string[] lines = sr.ReadLine().Split(",");
        string name = lines[0];
        string email = lines[1];
        double salary = double.Parse(lines[2], CultureInfo.InvariantCulture);
        employees.Add(new Employees() {Name = name, Email = email, Salary = salary});
    }
}

// mostrar, em ordem alfabética, o email dos funcionários cujo salário seja superior a um dado valor fornecido pelo usuário -> 2000.00
var emails = employees.Where(s => s.Salary > 2000.00).OrderBy(e => e.Email).Select(e => e.Email);

Console.WriteLine($"O email dos funcionários cujo salário seja superior a {assaySalary.ToString("F2", CultureInfo.InvariantCulture)}:\n" + string.Join("\n", emails));

// Mostrar também a soma dos salários dos funcionários cujo nome começa com a letra 'M'.
var employeesM = employees.Where(n => n.Name[0] == 'M').Select(s => s.Salary).Aggregate(0.0, (x, y) => x + y);

Console.WriteLine(@"A soma dos salários dos funcionários cujo nome começa com a letra ""M"": " + employeesM.ToString("F2", CultureInfo.InvariantCulture));


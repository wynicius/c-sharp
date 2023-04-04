// Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N funcionários. Não deve haver repetição de id. 
// Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário. Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos. 
// Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de aumento por porcentagem dada.

using System;
using System.Collections.Generic;
using System.Globalization;

Console.WriteLine("How many employees will be registered? ");
int employeesN = int.Parse(Console.ReadLine());

List<Employee> employeesList = new List<Employee>();

for (int i = 0; i < employeesN; i++) {
    Console.WriteLine("Employee #" + (i + 1) + ":");
    Console.Write("Enter the employee's ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Enter the employee's name: ");
    string name = Console.ReadLine();
    Console.Write("Enter the employee's salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    employeesList.Add(new Employee(id, name, salary));
}
Console.WriteLine();
Console.Write("Enter the employee id that will have salary increase : ");
int searchId = int.Parse(Console.ReadLine());

Employee emp = employeesList.Find(x => x.Id == searchId);

if (emp != null) {
    Console.Write("Enter the percentage (ex: 25): ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    emp.IncreaseSalary(percentage);

    Console.WriteLine();
}
else{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees:");
foreach (Employee obj in employeesList) {
    Console.WriteLine(obj);
}


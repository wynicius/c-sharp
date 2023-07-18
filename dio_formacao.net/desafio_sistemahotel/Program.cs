using System;
using System.Collections.Generic;
using System.Globalization;

try
{
    List<Pessoa> hospedes = new List<Pessoa>();

    Console.WriteLine("Insira o nome e sobrenome dos hospedes, um por um. Vamos lá!");
    Console.WriteLine();
    
    for (int i = 1; i < 2; i++)
    {
        Console.Write("Insira o primeiro nome: ");
        string nome = Console.ReadLine();
        Console.Write("Insira o sobrenome: ");
        string sobrenome = Console.ReadLine();

        hospedes.Add(new Pessoa(nome, sobrenome));

        Console.WriteLine(@"Deseja adicionar mais hóspedes para este quarto? Se não há mais, escreva ""não"", caso contrário, pressione enter e continue.");
        string escolha = Console.ReadLine().ToUpper();

        if (escolha == "NÃO" || escolha == "NAO")
        {
            Console.Clear();
            Console.WriteLine("Hóspedes Registrados.");
            break;
        }
        else
        {
            --i;
        }
    }
    // Cria a suíte
    Suite suitePremium = new Suite("Premium", 2, 30);

    // Cria uma nova reserva, passando a suíte e os hóspedes
    Reserva reserva = new Reserva (5);
    reserva.CadastrarSuite(suitePremium);
    reserva.CadastrarHospedes(hospedes);

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
}
catch (ArgumentOutOfRangeException a)
{
    Console.WriteLine("an error occurred: " + a.Message);
}
catch (NullReferenceException n)
{
    Console.WriteLine("an error occurred: " + n.Message);
}
catch (Exception e)
{
    Console.WriteLine("an error occurred: " + e.Message);
}

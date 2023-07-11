using System.Collections.Generic;
using System;
using System.Globalization;
public class Estacionamento
{
    public decimal PrecoInicial { get; set; }
    public decimal PrecoPorHora { get; set; }
    public List<string> veiculos = new List<string>();

    public Estacionamento( decimal precoInicial, decimal precoPorHora)
    {
        PrecoInicial = precoInicial;
        PrecoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine();

        veiculos.Add(placa.ToUpper());
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placa = Console.ReadLine();

        if (!veiculos.Contains(placa.ToUpper()))
        {
            throw new NullReferenceException("Não há veículo com esta placa estacionado neste momento.");
        }
        else
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            decimal horas = decimal.Parse(Console.ReadLine());
            decimal horasArredondadas = decimal.Round(horas);

            decimal valorTotal = PrecoInicial + PrecoPorHora * (horasArredondadas - 1);

            veiculos.Remove(placa.ToUpper());
            Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (string veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

decimal precoInicial = 10;
decimal precoPorHora = 3.50m;
int opcao = 0;

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

Console.WriteLine("Olá, bem vindo ao sistema de estacionamento da Stoner's ParkingLot");

try{
    do
    {
        Console.WriteLine();
        Console.WriteLine("Digite o indice o para o que deseja:");
        Console.WriteLine("1. Cadastrar veículo\n"
                        + "2. Remover veículo\n"
                        + "3. Listar veículos\n"
                        + "4. Encerrar");

        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                estacionamento.AdicionarVeiculo();
                break;
            case 2:
                estacionamento.RemoverVeiculo();
                break;
            case 3:
                estacionamento.ListarVeiculos();
                break;
        }
    }
    while (opcao != 4);
}
catch (NullReferenceException n)
{
    Console.WriteLine(n.Message);
}
catch (Exception e)
{
    Console.WriteLine("ocorreu um erro: " + e.Message);
}
finally
{
    string carsParkedFile = JsonConvert.SerializeObject(estacionamento, Formatting.Indented);

    File.WriteAllText("files/cars-parked.json", carsParkedFile);
}
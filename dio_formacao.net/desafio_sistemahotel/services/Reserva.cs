using  System;
using System.Collections.Generic;

public class Reserva
{
    public int DiasReservados { get; set; }
    public Suite Suite { get; set; }
    public List<Pessoa> Hospedes = new List<Pessoa>();

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (hospedes.Count <= Suite.Capacidade)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Número de hospedes incompatível com a capacidade da suite.");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        if (Hospedes.Count == 0)
        {
            throw new NullReferenceException("Não há hospedes neste momento.");
        }
        int countHospedes = 0;
        foreach (Pessoa hospede in Hospedes)
        {
            countHospedes++;
        }
        return countHospedes;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valorFinalDiaria = 0M;
        if (DiasReservados >= 10)
        {
            return valorFinalDiaria = (DiasReservados * Suite.ValorDiaria) * 0.9m; // 10% de desconto
        }
        else
        {
            return valorFinalDiaria = (DiasReservados * Suite.ValorDiaria);
        }
    }
}

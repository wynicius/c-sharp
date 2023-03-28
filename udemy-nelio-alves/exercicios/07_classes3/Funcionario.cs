using System;
using System.Globalization;

public class Funcionario {

    public string Nome;

    public double SalarioBruto;

    public double Imposto;

    public double SalarioLiquido() {
        return SalarioBruto - Imposto;
    }

    public void AumentarSalario(double porcentagem) {
        SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
    }

    public override string ToString() {
        return $"O funcionário {Nome} tem o salário líquido de R${SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}
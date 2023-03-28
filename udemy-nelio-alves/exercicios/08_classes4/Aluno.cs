using System;
using System.Globalization;

public class Aluno {

    public string Nome;

    public double N1, N2, N3;

    public double NotaFinal() {
        double notaFinal =  (N1 + N2 + N3) / 3;
        return notaFinal;
    }

    public override string ToString() {
        if (NotaFinal() >= 7.0) {
            return "APROVADO";
        }
        else {
            return "REPROVADO\n" +
                    $"FALTARAM {(7.0 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)} PONTOS";

        }
    }
}
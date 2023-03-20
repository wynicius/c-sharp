class CambioDeMoeda {

    public static double Iof = 0.06; // IOF de 6%
    public static double DolarParaReal(double cotacao, double qntDolar) {
        double total = ((cotacao * Iof) + cotacao) * qntDolar;
        return total;
    }
}
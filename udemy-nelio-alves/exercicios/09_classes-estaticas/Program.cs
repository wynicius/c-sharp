using System;
using System.Globalization;

System.Console.Write("Qual a cotação do dólar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.Write("Quantos dólares você vai comprar? ");
double qntDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// Está sendo usada a classe estática CambioDeMoeda. A diferença é que não há necessidade de referenciação, nem instanciação.

System.Console.WriteLine("Valor a ser pago em reais = " 
    + CambioDeMoeda.DolarParaReal(cotacao,qntDolar).ToString("N", CultureInfo.GetCultureInfo("pt-BR")));

// Para formatar o número com o separador de milhar, você pode usar a string "N" juntamente com a cultura "pt-BR" (ou qualquer outra cultura que use o ponto como separador de milhar).


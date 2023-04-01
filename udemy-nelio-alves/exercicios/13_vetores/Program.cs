// A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos identificados pelos números 0 a 9. 
// Quando um estudante deseja alugar um quarto, deve-se registrar o nome e email deste estudante. 
// Fazer um programa que inicie com todos os dez quartos vazios, e depois leia uma quantidade N representando o número de estudantes que vão alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos N estudantes. Para cada registro de aluguel, informar o nome e email do estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha que seja escolhido um quarto vago. Ao final, seu programa deve imprimir um relatório de todas ocupações do pensionato, por ordem de quarto, conforme exemplo.

using System.Globalization;

class Program {
    static void Main(string[] args) {
        Quartos[] quartos = new Quartos[10];

        Console.WriteLine("-----------------------");
        Console.WriteLine("  BEM-VINDO AO HOTEL!  ");
        Console.WriteLine("-----------------------");
        Console.Write("Possuímos 10 quartos vagos. Quantos quartos deseja alugar? ");

        try {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write("Digite o nome do estudante: ");
                string estudante = Console.ReadLine();

                Console.Write("Digite o e-mail do estudante: ");
                string email = Console.ReadLine();

                Console.Write("Qual quarto deseja? ");
                int numQuarto = int.Parse(Console.ReadLine());

                quartos[numQuarto] = new Quartos(estudante, email);

                Console.WriteLine("É um prazer tê-lo conosco Sr(a). " + estudante + ".");
            }
            System.Console.WriteLine("\nQuartos ocupados: ");
            for (int i = 0; i < 10; i++) {
                if (quartos[i] != null) {
                    System.Console.WriteLine(i + ": " + quartos[i]);
                }
            }
        }
        catch (FormatException) {
            Console.WriteLine("Erro de entrada de dados. Certifique-se de inserir um valor numérico válido para o número de quartos.");
        }
    }
}

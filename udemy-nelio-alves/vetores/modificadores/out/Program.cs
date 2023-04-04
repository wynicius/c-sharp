int a = 10, triple;
Calculator.Triple(a, out triple);
Console.WriteLine(triple);

class Calculator {
    public static void Triple(int origin, out int result) { // A variável x se torna uma referência à int a.
        result = origin * 3;
    }
}
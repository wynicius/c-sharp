int a = 10;
Calculator.Triple(ref a);
Console.WriteLine(a);

class Calculator {
    public static void Triple(ref int x) { // A variável x se torna uma referência à int a.
        x = x * 3;
    }
}
// CASTING (CONVERSÃO DE TIPOS)
int a = 5;
int b = 2;
// temos que fazer o casting pois a e b são tipos int
double c = (double) a / b; 
System.Console.WriteLine(c);

// Contudo, mesmo se os números, 5 e 2, não fossem declarados em uma variante int, eles seriam considerados int por default, vejamos:
double n1 = 10 / 8;
System.Console.WriteLine(n1);

// Então temos de fazer o casting tbm!
double n2 = (double) 10 / 8;
System.Console.WriteLine(n2);

// A exceção é se um dos números possui decimais, como exemplo: 5.0 e/ou 2.0, daí a conversão se dá implicitamente.
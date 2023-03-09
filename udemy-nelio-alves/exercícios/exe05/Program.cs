Pessoas p1,p2;
p1 = new Pessoas();
p2 = new Pessoas();

Console.WriteLine("Dados da primeira pessoa, abaixo");
    Console.Write("Nome: ");
    p1.Nome = Console.ReadLine();

    Console.Write("Idade: ");
    p1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Agora dados da segunda pessoa, abaixo");
    Console.Write("Nome: ");
    p2.Nome = Console.ReadLine();

    Console.Write("Idade: ");
    p2.Idade = int.Parse(Console.ReadLine());

if (p1.Idade > p2.Idade) {
    System.Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
}
else if (p2.Idade > p1.Idade) {
    System.Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
}
else {
    System.Console.WriteLine($"{p1.Nome} e {p2.Nome} possuem a mesma idade!");
}

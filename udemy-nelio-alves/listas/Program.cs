using System.Collections.Generic;

List<string> lista = new List<string>();

// Adiciona-se ao final da lista, pois não há indicação da posição da lista.
lista.Add("Amanda");
lista.Add("Fernando");
lista.Add("Anna");
lista.Add("Ronaldo");
lista.Add("Benedito");
lista.Add("Alan");
lista.Add("Pedro");
lista.Add("Guilherme");

// o 2 é a posição indicada para que se adicione à lista.
lista.Insert(2 , "Wynicius");

foreach (string obj in lista) {
    Console.WriteLine(obj);
}
// Mostra o tamanho da lista.
System.Console.WriteLine("list count: " + lista.Count);

// Método .Find para seleciona a primeira string da lista, passando outra função dentro, esta uma função lambda, que indica um string com a primeira letra um A maiúsculo.
string s1 = lista.Find(x => x[0] == 'A');
System.Console.WriteLine("First 'A': " + s1);

// Método .Find para selecionar a ultima string da lista com a condição que a função lambda indica.
string s2 = lista.FindLast(x => x[0] == 'A');
System.Console.WriteLine("Last 'A': " + s2);

// Método .FindIndex para encontrar o índice do primeiro elemento da lista que começa com a letra 'W'.
int pos1 = lista.FindIndex(x => x[0] == 'W');
System.Console.WriteLine("First 'W': #" + pos1);

// Método .FindLastIndex para encontrar o índice do último elemento da lista que começa com a letra 'A'.
int pos2 = lista.FindLastIndex(x => x[0] == 'A');
System.Console.WriteLine("Last 'A': #" + pos2);

System.Console.WriteLine("-----------------------");
// Utiliza o método ".FindAll" da classe List para encontrar todos os elementos da lista "lista" cujo tamanho é igual a 8. O resultado é armazenado na lista "lista2". A condição é dada pela função lambda x => x.Length == 8, que verifica se o tamanho de cada elemento da lista é igual a 8.
List<string> lista2 = lista.FindAll(x => x.Length == 8);

foreach (string obj in lista2) {
    System.Console.WriteLine(obj);
}

System.Console.WriteLine("-----------------------");
// Utiliza o método ".Remove" da classe List para remover o elemento "Wynicius" da lista "lista". Se o elemento não existir na lista, nada será removido.
lista.Remove("Wynicius");
foreach (string obj in lista) {
    System.Console.WriteLine(obj);
}

System.Console.WriteLine("-----------------------");
// Utiliza o método ".RemoveAll" da classe List para remover todos os elementos da lista "lista" cuja primeira letra é 'A'
lista.RemoveAll(x => x[0] == 'A');
foreach (string obj in lista) {
    System.Console.WriteLine(obj);
}

System.Console.WriteLine("-----------------------");
// Utiliza o método ".RemoveAt" da classe List para remover o elemento da posição 2 da lista "lista". Se a posição não existir na lista, uma exceção será lançada.
lista.RemoveAt(2);
foreach (string obj in lista) {
    System.Console.WriteLine(obj);
}

System.Console.WriteLine("-----------------------");
// Utiliza o método ".RemoveRange" da classe List para remover dois elementos da lista "lista" a partir da posição 2 (inclusive). Se a posição não existir na lista, uma exceção será lançada.
lista.RemoveRange(2 , 2);
foreach (string obj in lista) {
    System.Console.WriteLine(obj);
}
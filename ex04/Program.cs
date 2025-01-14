// Escreva um programa que pergunte o nome do ususario e apresente nome + boas vindas

Console.WriteLine("Qual é o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual é o seu sobrenome?");
string sobrenome = Console.ReadLine();

Console.WriteLine("Qual é o seu ultimo nome ");
string ultimonome = Console.ReadLine();

//Console.WriteLine("Seja bem-vindo(a) " + nome + sobrenome + ultimonome);
Console.WriteLine($"Seja bem-vindo(a) {nome} {sobrenome} {ultimonome}");



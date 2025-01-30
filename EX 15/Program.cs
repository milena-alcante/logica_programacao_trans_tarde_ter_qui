/*

Desafio: Criar um programa que receba 6 nome utilizando arrays. Ao final o programa deve exibir todos os nome digitados

*/

string[] nomes = new string[6];
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Digite o nome:");
    nomes[i] = Console.ReadLine();
}
Console.Clear();

for (int i = 0;i < nomes.Length;i++)
{
    Console.WriteLine($"Nomes: {nomes[i]}");
}
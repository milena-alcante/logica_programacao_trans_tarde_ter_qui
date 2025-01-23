// Descrição: Crie um programa que gera a tabuada de um numero escolhido pelo usuario.
//Do While

Console.WriteLine("Digite um número para ver a tabuada: ");
int num = int.Parse(Console.ReadLine());
int contador = 1;

do
{
    Console.WriteLine($"{num} x {contador} = {num * contador}" );
    contador++;

}
while (contador <= 10);
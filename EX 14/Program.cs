/*
Objetivo: Criar um array que armazene 5 nomes de frutas e, em seguida, imprimir cada nome na tela.
 
Instruções:
- Crie um array de strings para armazenar os nomes das frutas.
- Preencha o array com 5 frutas diferentes.
- Use um loop para iterar sobre o array e imprimir cada fruta.
*/

/*string[] frutas = new string[5]; (sem perguntar para o usuario)

frutas[0] = "Maçã";
frutas[1] = "Tomate";
frutas[2] = "Laranja";
frutas[3] = "Uva";
frutas[4] = "Goiaba";

for  (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Fruta na posição {i}: {frutas[i]}");
}

for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine($"Fruta na posição {i}: {frutas[i]}");
}*/
/*
string[] frutas = new string[5]; (codigo completo)

Console.WriteLine("Digite o nome da fruta:");
frutas[0] = Console.ReadLine();
Console.WriteLine("Digite o nome da fruta:");
frutas[1] = Console.ReadLine();
Console.WriteLine("Digite o nome da fruta:");
frutas[2] = Console.ReadLine();
Console.WriteLine("Digite o nome da fruta:");
frutas[3] = Console.ReadLine();
Console.WriteLine("Digite o nome da fruta:");
frutas[4] = Console.ReadLine();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Fruta na posição {i}: {frutas[i]}");
}
*/

/* Codigo simplificado*/
/*string[] frutas = new string[5];
for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine($"Digite o nome da fruta: {i + 1} fruta: ");
    frutas[i] = Console.ReadLine();
}
 Console.Clear();
/*
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Fruta na posição {i}: {frutas[i]}");
}
*/

Console.WriteLine("========================================");
Console.WriteLine("=============Frutas Digitadas===========");
Console.WriteLine("========================================");

int index = 0;

foreach (string frutas in)
{
    Console.WriteLine($"Fruta na posição {index}: {frutas}");
    index++;
}

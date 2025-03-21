// Projeto: GERENCIADOR DE NOTAS

using System.ComponentModel;

int[] Notas = new int[6];
int tNotas;
double Media;
int Resultado;
Console.WriteLine("Gerenciador de notas dos alunos");
for (int i = 1; i < Notas.Length; i++)
{
    try
    {
        Console.Write($"Digite a {i}ª nota: ");
        Notas[i] = int.Parse(Console.ReadLine());
        if (Notas[i] < 0 || Notas[i] > 10)
        {
            throw new OverflowException();
        }
        else
        {
            Console.Write($"Digite a {i}ª nota: ");
            Notas[i] = int.Parse(Console.ReadLine());
        }
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Insira uma nota entre 0 e 10");
    }
}
// Projeto: GERENCIADOR DE NOTAS

using System.ComponentModel;

int[] Notas = new int[6];
double TNotas = 0.0;
double Media = 0.0;
double Resultado = 0.0;
bool verificacao = true;
Console.WriteLine("=== GERENCIADOR DE NOTAS ===");
for (int i = 1; i < Notas.Length; i++)
{
    do     //Metodo denrepeticao caso o usuario insira uma nota "invalida"
    {
        try
        {
         Console.Write($"Digite a {i}ª nota: ");
         Notas[i] = int.Parse(Console.ReadLine());
            if (Notas[i] < 0 || Notas[i] > 10)
            {
                throw new OverflowException();
                verificacao = false;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Insira uma nota entre 0 e 10");
            i--;
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Insira apenas numeros");
            i--;
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Insira uma nota");
            i--;
        }
    } while (verificacao == false) ;
}
Console.WriteLine();
Console.WriteLine("Notas do aluno:");
for (int i = 1; i < Notas.Length; i++)
{
    Console.Write($" {Notas[i]} ");
}
Console.WriteLine();
for (int i = 0; i < Notas.Length; i++)
{
    TNotas += Notas[i];
}
Console.WriteLine();
Media = TNotas / 5;
Console.WriteLine($"A media do aluno e: {Media}");
Console.WriteLine();
Resultado = Media;
if  (Media >= 7)
{
    Console.WriteLine("O aluno foi APROVADO!");
}
else
{
    Console.WriteLine("O aluno foi REPROVADO!");
}
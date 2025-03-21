//// EXERCICIOS 20/03

//// Exercicio 01 - listagem de elementos <Crie um vetor com 5 elementos, e liste todos os elementos do vetor utilizando um For.>

//string[] nomes = new string[5];

//for (int i = 0; i < nomes.Length; i++)
//{
//    Console.Write("Escreva um nome: ");
//    nomes[i] = Console.ReadLine();
//}
//for (int i = 0; i < nomes.Length; i++)
//{
//    Console.WriteLine($"o nome {i} e: {nomes[i]}");
//}

//// Exercicio 02 - soma de elementos de um Array <Crie um programa que declare um array de 5 números inteiros e utilize um laço de repetição para somar todos os valores. No final, exiba a soma na tela.>

//int[] num = new int[5];
//int soma = 0;
//for (int i = 0; i < num.Length; i++)
//{
//    Console.Write($"escreva o numero {i} e eu irei somar todos ao final: ");
//    num[i] = int.Parse(Console.ReadLine());
//    soma = soma + num[i];
//}
//Console.WriteLine($"O resultado e: {soma}");

//// Exercicio 03 - Encontrar o maior numero em um array <Crie um programa que declare um array de 5 números inteiros e utilize um laço de repetição para encontrar o maior número do array. No final, exiba o maior valor encontrado.>

//int[] num2 = new int[5];
//int comp = 0;
//Console.WriteLine("escreva 5 numeros e eu vou lhe dizer qual o maior!!");
//for (int i = 0; i < num2.Length; i++)
//{
//    Console.Write($"escreva o numero {i}: ");
//    num2[i] = int.Parse(Console.ReadLine());
//    if (num2[i] > comp)
//    {
//        comp = num2[i];
//    }
//}
//Console.WriteLine($"o maior numero e: {comp}");

// Exercicio 04 - Contagem de numeros pares <Peça ao usuário 10 números, armazene em um array e exiba a quantidade de números pares inseridos.>

Console.WriteLine("escreva 10 numeros e eu irei lhe falar quais sao pares!!");
int[] NPar = new int[10];
int[] par = new int[10];
int[] impar = new int[10];
for (int i = 0; i < NPar.Length; i++)
{
    Console.Write($"escreva o numero {i}: ");
    NPar[i] = int.Parse(Console.ReadLine());
    if (NPar[i] %2  == 0)
    { 
            par[i] = NPar[i];
    }
    else
    {
        impar[i] = NPar[i];
    }
}
for (int i = 0; i < par.Length; i++)
{
    Console.WriteLine($"O {par[i]} e par");
}
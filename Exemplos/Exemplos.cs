string[] nomes = new string[15];

nomes[0] = "Daniel";
// Length - largura/quantidade da array
for (int i = 0; i < nomes.Length; i++)
{
    Console.Write("Informe o nome: ");
    nomes[i] = Console.ReadLine();
}

// 1 - listando com o for
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}

// 2 - Listando com o foreach (para cada)
foreach (var item in nomes)
{
    Console.WriteLine(item);
}
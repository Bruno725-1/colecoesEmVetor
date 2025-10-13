using System;
class ListaVet
{
    public static void Rodar()
    {
        // Criando uma lista de inteiros
        CListaVet<int> numeros = new CListaVet<int>();

        // Adiciona - adiciona elementos à lista
        numeros.Adiciona(10);
        numeros.Adiciona(50);
        numeros.Adiciona(30);
        numeros.Adiciona(40);
        numeros.Adiciona(20);
        Console.WriteLine("Lista após Adiciona: " + string.Join(", ", numeros));

        // Limpar - remove todos os elementos
        int[] colecao = { 1, 2, 3 };
        CListaVet<int> outraLista = new CListaVet<int>(colecao);
        outraLista.Limpar();
        Console.WriteLine("Outra lista após Limpar: " + string.Join(", ", outraLista));
        Console.WriteLine("Capacidade de outra lista após Limpar: " + outraLista.Capacidade);

        // Contem - verifica se um elemento existe
        Console.WriteLine("Contém 20? " + numeros.Contem(20));

        // Quantidade - propriedade que retorna o número de elementos
        Console.WriteLine("Quantidade de elementos: " + numeros.Quantidade);

        // PrimeiraOcorrenciaDe - retorna a primeira ocorrência de um elemento
        Console.WriteLine("Índice do 30: " + numeros.PrimeiraOcorrenciaDe(30));

        // InsereIndice - insere um elemento em um índice específico
        numeros.InsereIndice(25, 2); // insere 25 na posição 2
        Console.WriteLine("Lista após InsereIndice: " + string.Join(", ", numeros));

        // UltimaOcorrenciaDe - última ocorrência
        numeros.Adiciona(30);
        Console.WriteLine("Último índice do 30: " + numeros.UltimaOcorrenciaDe(30));

        // Remove - remove a primeira ocorrência do valor
        numeros.Remove(30);
        Console.WriteLine("Lista após Remove(30): " + string.Join(", ", numeros));

        // RemoveIndice - remove pelo índice
        numeros.RemoveIndice(0); // remove o primeiro elemento
        Console.WriteLine("Lista após RemoveIndice(0): " + string.Join(", ", numeros));

        // Inverte - inverte a ordem da lista
        numeros.Inverte();
        Console.WriteLine("Lista após Inverte: " + string.Join(", ", numeros));

        // Ordenar - ordena a lista
        numeros.Ordenar();
        Console.WriteLine("Lista após Ordenar: " + string.Join(", ", numeros));

        // ParaVetor - converte para array
        int[] array = numeros.ParaVetor();
        Console.WriteLine("Array convertido da lista: " + string.Join(", ", array));

        // CortarExcessos - ajusta capacidade da lista
        CListaVet<int> grandeLista = new CListaVet<int>(1000);
        grandeLista.Adiciona(1);
        grandeLista.Adiciona(2);
        grandeLista.Adiciona(3);
        Console.WriteLine($"Capacidade antes do CortarExcessos: {grandeLista.Capacidade}");
        grandeLista.CortarExcessos();
        Console.WriteLine($"Capacidade após CortarExcessos: {grandeLista.Capacidade}");
        Console.WriteLine("Lista números: " + string.Join(", ", numeros));
        Console.WriteLine($"Capacidade da lista números: {numeros.Capacidade}");
        Console.WriteLine(numeros.Quantidade);
        numeros.CortarExcessos();
        Console.WriteLine("Capacidade após cortar excessos: " + numeros.Capacidade);
        numeros.Adiciona(85);
        Console.WriteLine(string.Join(", ", numeros));
        Console.WriteLine(numeros.Capacidade);
        numeros.Adiciona(95);
        numeros.Adiciona(98);
        numeros.Adiciona(2001);
        Console.WriteLine(string.Join(", ", numeros));
        Console.WriteLine("Capacidade da lista números: " + numeros.Capacidade);
    }
}
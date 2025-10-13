using System;
class Teste
{
    public static void Rodar()
    {
        CListaVet<int> numeros = new CListaVet<int>();
        numeros.Adiciona(30);
        numeros.Adiciona(10);
        numeros.Adiciona(15);
        numeros.Adiciona(20);
        numeros.Adiciona(25);
        numeros.Adiciona(30);
        Console.WriteLine($"Capacidade da lista: {numeros.Capacidade}");
        Console.WriteLine($"Quantidade da lista: {numeros.Quantidade}");
        numeros.Adiciona(60);
        Console.WriteLine($"Capacidade da lista: {numeros.Capacidade}");
        Console.WriteLine($"Quantidade da lista: {numeros.Quantidade}");
        Console.WriteLine("Imprimindo a lista:");
        Console.WriteLine(string.Join(", ", numeros));
        numeros.Adiciona(30);
        numeros.Adiciona(10);
        numeros.Adiciona(15);
        numeros.Adiciona(20);
        numeros.Adiciona(25);
        numeros.Adiciona(30);
        Console.WriteLine($"Capacidade da lista: {numeros.Capacidade}");
        Console.WriteLine($"Quantidade da lista: {numeros.Quantidade}");
        Console.WriteLine("Imprimindo a lista:");
        numeros.RemoveIndice(2);
        numeros.RemoveIndice(3);
        Console.WriteLine(string.Join(", ", numeros));
        numeros.Remove(30);
        numeros.RemoveIndice(5);
        Console.WriteLine($"Capacidade da lista: {numeros.Capacidade}");
        Console.WriteLine($"Quantidade da lista: {numeros.Quantidade}");
        numeros.CortarExcessos();
        Console.WriteLine($"Capacidade após cortar excessos: {numeros.Capacidade}");
    }
}
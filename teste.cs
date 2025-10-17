using System;
class Teste
{
    public static void Rodar()
    {
        CListaVet<int> lista = new CListaVet<int>();
        for (int i = 0; i < lista.Capacidade; i++)
            lista.Adiciona(i + 1);
        Console.WriteLine($"Capacidade da lista: {lista.Capacidade}");
        Console.WriteLine($"Quantidade de itens: {lista.Quantidade}");
        for (int i = 6; i < 32; i++)
            lista.Adiciona(i + 1);
        Console.WriteLine($"Capacidade da lista: {lista.Capacidade}");
        Console.WriteLine($"Quantidade de itens: {lista.Quantidade}");
        lista.CortarExcessos();
        Console.WriteLine($"Capacidade após cortar excessos: {lista.Capacidade}");
        Console.WriteLine($"Quantidade de itens: {lista.Quantidade}");
    }
}
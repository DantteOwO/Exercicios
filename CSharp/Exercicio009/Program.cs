using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Executado o projeto 9 - Condifionais");

        int idadeJoao = 16;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else 
        {
            Console.WriteLine("Nao pode entrar!");
        }

        Console.WriteLine("Tecle enter para fechar.... ");
        Console.ReadLine();
    }
}

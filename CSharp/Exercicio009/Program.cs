using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Executado o projeto 9 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else 
        {
            if (quantidadePessoas > 0)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Nao pode entrar!");
            }
        }

        Console.WriteLine("Tecle enter para fechar.... ");
        Console.ReadLine();
    }
}

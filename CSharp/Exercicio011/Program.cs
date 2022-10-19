using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Executado o projeto 10 - Condicionais 2");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 0;

       string textoAdicional;

        if(acompanhado == true)
        {
             textoAdicional = "Joao esta acompanhado";

        }
        else
        {
            textoAdicional = "Joao nao esta acompanhado";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar !");
        }
        else
        {
            Console.WriteLine("Nao pode entrar!");
        }

        Console.WriteLine("Tecle enter para fechar.... ");
        Console.ReadLine();
    }
}

using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 8 - Atribuição de variaveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);

        idade = 25;

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}
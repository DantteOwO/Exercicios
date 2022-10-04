using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variaveis");

        int idade;

       idade = 20;
        
        Console.WriteLine("A idade do carlos é..." + idade);

        idade = 20 - 5;

        Console.WriteLine("A idade de Ana é.." + idade);

        idade = 5 * 2 - 6;

        Console.WriteLine("Minha idade é..." + idade);

        idade = (5 - 2) * 3;

        Console.WriteLine("Silvana tem " + idade + " anos");

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }  
}
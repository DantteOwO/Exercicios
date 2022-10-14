using System;

class Programa
{

    static void Main(string[] args)
    {

        string primeiraFrase = "Alura - Curso de tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string cursos = @"Cursos disponiveis: 
- GO 
- C# 
- Python 
- Java";
        Console.WriteLine(cursos);

        Console.WriteLine(" Tecle enter para fechar...");
        Console.ReadLine();
    }

}
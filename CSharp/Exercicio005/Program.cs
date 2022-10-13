using System;

class Programa
{

    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;

        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro); 

        long x;
        x = 1000000000000000;
        Console.WriteLine(x);

        short y;
        y = 15000;
        Console.Write(y);

        Console.WriteLine(" Tecle enter para fechar...");
        Console.ReadLine();
    }

}
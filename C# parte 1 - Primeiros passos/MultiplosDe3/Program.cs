using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Desafio Multiplo de 3");

        for(int mult = 1; mult <= 100; mult++)
        {
            if (mult % 3 == 0)
            {
                Console.WriteLine(mult);
            }
        }
    }
}
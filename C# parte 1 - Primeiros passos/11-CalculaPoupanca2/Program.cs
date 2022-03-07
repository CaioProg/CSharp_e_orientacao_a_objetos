using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Execuando o projeto 11 - Calcula Poupança 2");

        double valorInvestido = 1000;

        for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
        {
            valorInvestido *= 1.0076;
            Console.WriteLine("Após " + contadorMes + "meses, você terá R$ " + valorInvestido);
        }


        Console.ReadLine();
    }
}
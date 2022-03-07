using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Execuando o projeto 12 - Calcula Investimento a Longo Prazo");

        double valorInvestido = 20000;
        double fatorRendimento = 1.0076;

        for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
        {
            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= fatorRendimento;
            }

            fatorRendimento += 0.0010;
        }
        
        Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido);

        Console.ReadLine();
    }
}
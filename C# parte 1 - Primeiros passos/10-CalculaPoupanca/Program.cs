using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Execuando o projeto 10 - Calcula Poupança");

        // 0.76% = 0,0076

        double valorInvestido = 200000;
        int contadorMes = 1;

        while (contadorMes <= 12)
            {
            valorInvestido = valorInvestido + valorInvestido * 0.0076;
            Console.WriteLine("Após " + contadorMes + " meses, você terá " + valorInvestido);

            // contadorMes = contadorMes + 1;
            // contadorMes += 1;
            contadorMes++;
        }
        

        
        


        Console.ReadLine();
    }
}
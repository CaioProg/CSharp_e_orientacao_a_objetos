using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {

        double salario = 2999.5;

        Console.WriteLine("****Calculo de IR****");

        if(salario >= 1900 && salario <= 2800)
        {
            Console.WriteLine("O IR é de 7.5% e pode deduzir na declaração o valor de R$ 142");
        }
        if(salario >= 2800.1 && salario <= 3751)
        {
            Console.WriteLine("O IR é de 15% e pode deduzir R$ 350");
        }
        if (salario >= 3751.01 && salario <= 4664)
        {
            Console.WriteLine("O IR é de 22.5% e pode deduzir R$ 636");
        }
        if (salario <= 1899 || salario >= 4664.1)
        {
            Console.WriteLine("Valor não encontrado, digite um valor entre 1900 e 4664");
        }
 
    }
}
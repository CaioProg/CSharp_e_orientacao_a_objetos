using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando condicionais");

        int idade = 17;
        int quantidadePessoas = 1;
        bool acompanhado;

        if (quantidadePessoas >= 2)
        {
             acompanhado = true;
        }
        else
        {
            acompanhado = false;
        }


        if (idade >= 18 || acompanhado)
        {
            Console.WriteLine("Seja bem vindo");
        }
        else
        {
            Console.WriteLine("infelizmente voce nao pode entrar");
        }

    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAY de inteiros, com 5 posições

            int[] idades = null;
            idades =  new int[3];

            idades[0] = 15;
            idades[1] = 19;
            idades[2] = 18;
            //idades[3] = 25;
            //idades[4] = 30;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);  

            int acumulador = 0;

            for(int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades no [{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;

            Console.WriteLine($"Média de idades = {media}");

            Console.ReadLine();
        }
    }
}

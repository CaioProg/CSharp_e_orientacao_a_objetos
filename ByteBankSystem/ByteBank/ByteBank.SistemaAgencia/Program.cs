using System;
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

            int[] idades = new int [5];

            idades[0] = 15;
            idades[1] = 19;
            idades[2] = 18;
            idades[3] = 25;
            idades[4] = 30;

            Console.WriteLine(idades[1]);


            Console.ReadLine();
        }
    }
}

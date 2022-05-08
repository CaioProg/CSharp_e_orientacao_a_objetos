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
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.MeuMetodo(numero: 10);

            ContaCorrente contaDoGui = new ContaCorrente(545, 54548485);

            lista.Adicionar(contaDoGui);


            lista.Adicionar(new ContaCorrente(874, 55844660));
            lista.Adicionar(new ContaCorrente(874, 55844668));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));
            lista.Adicionar(new ContaCorrente(874, 55845558));


            lista.Remover(contaDoGui);


            Console.ReadLine();
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
{
                new ContaCorrente(874, 55844660),
                new ContaCorrente(874, 45548845),
                new ContaCorrente(874, 78984515)
};

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }

        }

        static void TestaArrayInt()
        {

            // ARRAY de inteiros, com 5 posições

            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 19;
            idades[2] = 18;
            //idades[3] = 25;
            //idades[4] = 30;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;

            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades no [{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;

            Console.WriteLine($"Média de idades = {media}");
        }
    }
}

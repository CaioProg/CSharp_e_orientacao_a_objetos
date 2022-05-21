using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Extensoes;
using ByteBank.SistemaAgencia;
using Humanizer;
using ByteBank.SistemaAgencia.Comparadores;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(342, 2342342),
                new ContaCorrente(340, 1),
                new ContaCorrente(341, 9999999),
                new ContaCorrente(290, 2342344)
            };

            // contas.Sort(); ~~> Chamar a implementação dada en IComparable

            contas.Sort(new ComparadorContaCorrentePorAgencia());

            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }




            Console.ReadLine();
        }

        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Guilherme",
                "Julia",
                "Leticia",
                "Joao",
                "Ana"
            };

            nomes.Sort();
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }




            var idades = new List<int>();

            idades.Add(19);
            idades.Add(9);
            idades.Add(90);

            idades.AdicionarVarios(45, 90, 40);
            idades.AdicionarVarios(99, -1);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(1);
            //listaDeIdades.Adicionar("um texto qualquer");
            listaDeIdades.Adicionar(5);
            listaDeIdades.AdicionarVarios(10, 55, 45, 19);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }

        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();


            ContaCorrente contaDoGui = new ContaCorrente(111111, 222222222);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 55844660),
                new ContaCorrente(874, 55845558)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(874, 55844660),
                new ContaCorrente(874, 55845558),
                new ContaCorrente(874, 55845558)
                );


            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[1];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
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

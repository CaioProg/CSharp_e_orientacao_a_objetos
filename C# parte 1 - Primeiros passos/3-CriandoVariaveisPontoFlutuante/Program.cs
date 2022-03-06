// See https://aka.ms/new-console-template for more information

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanto projeto 3 Criando variaveis ponto flutuante");

            double salario;
            salario = 1270.70;

            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2.0;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            // Exercícios

            double peso = 4.0;
            int quantidade = 10;
            Console.WriteLine(peso * quantidade);

            int brindes = 15;
            int pessoas = 2;
            Console.WriteLine(brindes / pessoas);

            int dia = 4;
            int outrodia = 4 + dia;
            Console.WriteLine(outrodia);

            double preco = 5.5;
            int ingresso = 4;
            Console.WriteLine(preco * ingresso);


            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}

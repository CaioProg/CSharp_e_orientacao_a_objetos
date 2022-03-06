// See https://aka.ms/new-console-template for more information

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanto o projeto 4 ");

            double salario = 1200.50;
            Console.WriteLine(salario);
            // O int é um tipo de variabel que suporta valores até 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            // O long é uma vairavel de 64 bits
            long idade = 1300000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variael de 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.82f;
            Console.WriteLine(altura);



            Console.WriteLine("Para finalizar a execução tecle Enter.");
            Console.ReadLine();
        }
    }
}
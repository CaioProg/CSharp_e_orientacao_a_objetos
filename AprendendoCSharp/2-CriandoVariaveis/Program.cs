// See https://aka.ms/new-console-template for more information

namespace _1_PrimeiroPorjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 2 - Criando Variaveis");

            int idade;
            idade = 19;

            Console.WriteLine(idade);
            
            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade + "!");

            Console.WriteLine("A execução acabou. Tecle enter para finalziar...");
            Console.ReadLine();
        }
    }
}
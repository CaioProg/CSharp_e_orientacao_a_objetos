namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais2");
            Console.WriteLine("João pode entrar na festa ?");

            int idadeJoao = 18;
            //  int quantidadePessoas = 0;
            //  bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = true;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode!");
            }
            else
            {
                Console.WriteLine("Não pode!");
            }

            Console.ReadLine();
        }

    }
}
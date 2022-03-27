using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(458, 544545);

            Console.WriteLine(conta.Saldo);

            new ContaCorrente(456, 848484);

            conta.Sacar(-10);
            string nome = "Caio";

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();

                ContaCorrente conta = new ContaCorrente(55, 50);
                ContaCorrente conta2 = new ContaCorrente(555, 6666);

                conta2.Transferir(-10, conta);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(-500);
                Console.WriteLine(conta.Saldo);

            }
            catch (ArgumentException ex)
            {
                if(ex.ParamName == "numero")
                {

                }

                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Metodo();
            
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            LeitorDeArquivo leitor = null;

            try
            {
                leitor = new LeitorDeArquivo("contasl.txt");

                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();

            }
            catch (IOException)
            {

                Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            }
            finally
            {
                if(leitor != null)
                {
                    leitor.Fechar();
                }
            }
        }

        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero = " + numero + " e divisor = " + divisor);     
                throw;
                //Console.WriteLine("Código depois do throw");
            }
        }
    }
}
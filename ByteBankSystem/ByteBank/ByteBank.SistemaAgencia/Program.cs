using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


            string textoVazio = "teste";
            Console.WriteLine(string.IsNullOrEmpty(textoVazio));

            Console.ReadLine();


            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(null);

            string url = "pagina?moedaOrigiem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

         



            Console.ReadLine();
        }
    }
}

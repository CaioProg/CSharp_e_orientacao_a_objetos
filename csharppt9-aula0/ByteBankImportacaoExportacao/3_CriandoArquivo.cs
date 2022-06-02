using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // IO = Input e Output
using System.Globalization;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contaExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,5245254,4343.50,Caio Lucas";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);


                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("456,3434,456.0,Pedro Silva");
            }
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 10000000; i++)
                {
                    escritor.WriteLine($"linha {i}");

                    escritor.Flush(); // Despeja o buffer para o Stream

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter para adicionar mais uma!");
                    Console.ReadLine();
                }
            }
        }

    }
}

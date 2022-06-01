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
    }
}

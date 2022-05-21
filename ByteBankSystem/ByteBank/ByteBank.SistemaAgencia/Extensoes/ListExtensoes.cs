using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes<T>
    {
        public static void AdicionarVarios(List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }


        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(11);
            idades.Add(19);
            idades.Add(90);
            idades.Add(14);

            ListExtensoes<int>.AdicionarVarios(idades, 12, 21, 21);

            List<string> nomes = new List<string>();

            nomes.Add("Guilherme");

            ListExtensoes<string>.AdicionarVarios(nomes, "Caio", "Lucas");
        }
    }
}

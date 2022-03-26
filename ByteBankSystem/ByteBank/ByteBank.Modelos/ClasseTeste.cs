using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
     class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadorTeste teste = new ModificadorTeste();
            teste.MetodoPublico();
            teste.MetodoInterno();
        }
    }

    class ClasseDerivada : ModificadorTeste
    {
        public ClasseDerivada()
        {
            MetodoProtegido();
        }
    }

    public class ModificadorTeste
    {
        public void MetodoPublico()
        {
            // Visível fora da classe "ModificadoresTeste"
        }
        private void MetodoPrivado()
        {
            // Visível apenas na classe "ModificadoresTeste"
        }
        protected void MetodoProtegido()
        {
            // Visível apenas na classe "ModificadoresTeste" e derivados
        }
        internal void MetodoInterno()
        {
            // Visível apenas para o projeto ByteBank.Modelos!
        }
    }
}

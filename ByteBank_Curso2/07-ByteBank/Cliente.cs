using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class Cliente
    {
        private string _cpf;

        public string Nome { get; set; }
        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                //Escrevo minha logica de validação de cpf
                _cpf = value;
            }
        }
        
        public string Profissao { get; set; }

    }
}

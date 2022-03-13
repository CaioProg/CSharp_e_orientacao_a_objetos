using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();

            UsarSisema();

            Console.ReadLine();
        }

        public static void UsarSisema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("555.666.777.88");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("456.324.854-25");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();


            Funcionario pedro = new Designer("833.987.888.78");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("555.666.777.88");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("456.584.832-92");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("456.324.854-25");
            camila.Nome = "Camila";

            Desenvolvedor caio = new Desenvolvedor("145.898.888.15");
            caio.Nome = "Caio";

            gerenciadorBonificacao.Registrar(caio);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
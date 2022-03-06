using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(String[] args)
        {

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia";
            string cursosProgramacao = 
@" - .NET 
 - Java
 - Ruby on Rails";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            string saudacao = "Olá meu nome é ";
            string nome = "Lucas ";
            string continuacao = "e minha idade é ";
            int idade = 19;
            Console.WriteLine(saudacao + nome + continuacao + idade);


            Console.WriteLine("Executando o projeto 5 - Caracter e textos " + 2022);
            Console.ReadLine();
        }
    }
}
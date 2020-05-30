using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            CPF cpf = new CPF();
            cpf.nome = "Ryan";
            System.Console.WriteLine( cpf.Saudar() );
        }
    }
}

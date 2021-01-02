using ByteBank.Funcionarios;
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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            
            Funcionario carlos = new Funcionario(2000, "548.879.157-20");

            carlos.Nome = "Carlos";

            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do Carlos " + carlos.Salario);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor(5000, "454.658.148-3");

            roberta.Nome = "Roberta";
            //roberta.CPF = "454.658.148-3";

            roberta.AumentarSalario();
            Console.WriteLine("Novo salário da Roberta " + roberta.Salario);

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}

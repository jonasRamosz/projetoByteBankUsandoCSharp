using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class MontaTela
    {
        public void  TelaInicial()
        {
            Console.WriteLine("Bem-vindo ao byte-bank");
            Console.WriteLine("1 - Criar nova conta");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Saldo");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("0 - SAIR");
        }

        public void RecebeDados()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a sua profissão: ");
            string prof = Console.ReadLine();

            Console.Write("Digite o seu CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Digite seu nome da agencia: ");
            string nomeAgencia = Console.ReadLine();

            Console.Write("Digite o numero da agencia: ");
            int numeroAgencia = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite o numero da conta: ");
            string conta = Console.ReadLine();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using bytebank;
namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                ContaCorrente conta = new ContaCorrente(2547, 5478);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
                Console.WriteLine(conta.Saldo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro no parametro: {ex.ParamName}");
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("exception do tipo SaldoInsuficienteException");
            }
        }
    }
}
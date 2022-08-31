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


            try
            {
                int n1 = 2;
                int n2 = 1;

                double div = n1 / n2;
                Console.WriteLine($"o resultato é {div}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Impossivel dividir pr 0");
            }
            }

    }
}
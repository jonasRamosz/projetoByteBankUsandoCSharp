using bytebank;
namespace bytebank
{
    public class contaCorrente
{
    public contaCorrente( string nome_agencia, int numero_agencia, string contas)
        {
           
            nomeAgencia = nome_agencia;
            numeroAgencia = numero_agencia;
            conta = contas;

            totalDeContasCriadas += 1;

        }
        public static int totalDeContasCriadas { get; set; }

        public Cliente titular { get; set; }
    private string _conta;
    public string conta
        {
            get 
            {
                return _conta; 
            }
            set
            {
                if (value == null) 
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }
    
    private int _numeroAgencia;
    public int numeroAgencia 
        {
            get 
            {
                return _numeroAgencia; 
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    _numeroAgencia = value;
                }
            }

        }
    public string nomeAgencia { get; set; }

    private double saldo;
    
  



    public bool sacar(double valor)
    {
        if (valor < 0)
        {
            return false;
        }
        if (saldo < valor)
        {
            return false;
        }
        else
        {
            saldo -= valor;
            return true;
        }
    }

    public void depositar(double valor)
    {
        saldo += valor;
    }

    public bool transfirir(double valor, contaCorrente destino)
    {
        if (saldo < valor)
        {
            return false;
        }
        if (valor < 0)
        {
            return false;
        }
        else
        {
            saldo -= valor;
            destino.saldo += valor;
            return true;
        }
    }

    public double Saldo
        {
            get { return saldo; }
            
            set
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
               
            }
        }
    
    
    }
  


}

using bytebank;





//contaCorrente jonas = new contaCorrente("Agencia Sampaio", 415, "4577");
//jonas.titular = new Cliente();
//jonas.titular.nome = "jonas ramos";
//jonas.titular.cpf = "45800";
//jonas.titular.profissao = "programador";
//jonas.Saldo = 15000;
//Console.WriteLine($"nome :{jonas.titular.nome} \ncpf :{jonas.titular.cpf} \nprofissão :{jonas.titular.profissao}" +
//    $"\nnome da agencia :{jonas.nomeAgencia} \nnumero da agencia :{jonas.numeroAgencia} \nconta :{jonas.conta}" +
//    $"\nsaldo :{jonas.Saldo}");

while (true)
{
    Console.WriteLine("Bem-vindo ao byte-bank");
    Console.WriteLine("1 - Criar nova conta");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Saldo");
    Console.WriteLine("4 - Sacar");
    Console.WriteLine("0 - SAIR");
    int n = Convert.ToInt16(Console.ReadLine());

    contaCorrente conta1 = new contaCorrente();
    conta1.titular = new Cliente();

    switch (n)
    {
        case 0:
            {
                break;
            }
        case 1:
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

                conta1.nomeAgencia = nomeAgencia;
                conta1.numeroAgencia = numeroAgencia;
                conta1.conta = conta;
                conta1.titular.nome = nome;
                conta1.titular.profissao = prof;
                conta1.titular.cpf = cpf;

                break;
            }

        case 2:
            {
                Console.Write("Qual o valor deseja depositar?");
                double valor = Convert.ToDouble(Console.ReadLine());
                conta1.depositar(valor);
                break;
            }

        case 3:
            {
                Console.WriteLine($"SALDO :{conta1.saldo}");
                break;
            }

        case 4:
            {

                Console.Write("Qual o valor deseja sacar?");
                double valor = Convert.ToDouble(Console.ReadLine());
                bool veri = conta1.sacar(valor);
                break;
            }
    }

    break;
}










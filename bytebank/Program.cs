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

MontaTela tela = new MontaTela();
tela.TelaInicial();
Console.Write("Digite... ");
int n1 = Convert.ToInt16(Console.ReadLine());
string oi = Console.ReadLine();
Console.WriteLine($"vc digitou {oi}");
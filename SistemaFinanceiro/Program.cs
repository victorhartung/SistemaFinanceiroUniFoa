using SistemaFinanceiro;
using SistemaFinanceiro.Model;



try
{
    Banco banco1 = new Banco("Itau", 123);
    Banco banco2 = new Banco("Bradesco", 321);

    Agencia ag1 = new Agencia(888, "Itau", "1111-1111", banco1);
    Agencia ag2 = new Agencia(777, "Bradesco", "2222-2222", banco2);

    Cliente cliente1 = new Cliente("João Silva", "123.456.789-00", 1942);
    Cliente cliente2 = new Cliente("Maria Souza", "987.654.321-00", 1997);


    Conta conta1 = new Conta(123456, 1235.42m, ag2, cliente1);
    Conta conta2 = new Conta(654321, 2341.42m, ag1, cliente2); 
    Conta contaComMaiorSaldo = conta1.Saldo > conta2.Saldo ? conta1 : conta2;
    decimal saldoTotalGeral = conta1.Saldo + conta2.Saldo;

    //Console.WriteLine(banco1.Nome);

    Console.WriteLine("Saldo da conta1 {0:C2}, saldo da conta2 {1:C2}", conta1.Saldo, conta2.Saldo);
    Console.WriteLine("A conta {0} tem o maior saldo que é {1:C2}", contaComMaiorSaldo.Numero, contaComMaiorSaldo.Saldo);
    Console.WriteLine("O saldo inicial total geral é: {0:C2}", saldoTotalGeral);
} 
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
} 
catch(InvalidOperationException ex)
{
    Console.WriteLine($"Error: { ex.Message}");
}





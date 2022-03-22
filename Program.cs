using static System.Console;
using System;

namespace POO1
{
    public class Program
    {
        public static void Main()
        {
            ContaCorrente contaBruna = new ContaCorrente();
            contaBruna.titular = "Bruna";
            contaBruna.agencia = 123;
            contaBruna.conta = 3245678;
            
            WriteLine(contaBruna.titular);
            WriteLine("Ag: " + contaBruna.agencia);
            WriteLine("Conta: {0}",contaBruna.conta);
            WriteLine("Saldo: {0}",contaBruna.saldo);
            WriteLine("--------------------");

            ContaCorrente contaBreno = new ContaCorrente();
            contaBreno.titular = "Breno";
            contaBreno.agencia = 123;
            contaBreno.conta = 4567890;
            contaBreno.saldo = 300.00;

            WriteLine(contaBreno.titular);
            WriteLine("Agencia: {0}",contaBreno.agencia);
            WriteLine("Conta: {0}", contaBreno.conta);
            WriteLine("Saldo: {0}", contaBreno.saldo);
            WriteLine("---------------------");
            
            double saque = contaBreno.Sacar(100.50);
            WriteLine("{0} sacou {1}. Seu saldo agora é de {2}",contaBreno.titular,saque,contaBreno.saldo);

            double deposito = contaBruna.Depositar(137.80);

            WriteLine("{0} recebeu um depósito de {1}. Seu saldo atualizado é de: {2}", contaBruna.titular, deposito, contaBruna.saldo);
            WriteLine("-----------------");

            double transferido = contaBruna.Transferir(59.95,contaBreno);

            //Sem arredondar Saldos
            WriteLine("{0} transferiu R${1} para {2}. Saldo atual de {3} é de R${4}. Saldo atual de {5} é de R${6}", contaBruna.titular,transferido,contaBreno.titular,contaBruna.titular,contaBruna.saldo, contaBreno.titular,contaBreno.saldo);

            //Saldos arredondados
            WriteLine("{0} transferiu R${1} para {2}. Saldo atual de {3} é de R${4}. Saldo atual de {5} é de R${6}", contaBruna.titular,transferido,contaBreno.titular,contaBruna.titular,contaBruna.saldo.ToString("F"), contaBreno.titular,contaBreno.saldo.ToString("F"));


            Console.ReadKey();

        }
    }
}
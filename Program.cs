using static System.Console;
using System;

namespace POO1
{
    public class Program
    {
        public static void Main()
        {
             static void ClienteSemClasseSeparada()
            {
                /*ContaCorrente contaBruna = new ContaCorrente();
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


                Console.ReadKey();*/
                }

            //Criando Cliente sem ligação com a Conta Corrente
            Cliente Bruna = new Cliente();
            Bruna.nome = "Bruna";
            Bruna.cpf = "111.222.333-44";
            Bruna.profissao = "Estudante";

            Cliente Breno = new Cliente();
            Breno.nome = "Breno";
            Breno.cpf = "234.567.890.00";
            Breno.profissao = "Programador";
            
            WriteLine(Bruna.nome);
            WriteLine("CPF: {0}", Bruna.cpf);
            WriteLine("Profissão: {0}",Bruna.profissao);
            WriteLine("--------------------");

            //Criando Conta Corrente com os dados de Cliente da classe separada
            ContaCorrente contaBreno = new ContaCorrente();
            contaBreno.titular = Breno;
            contaBreno.agencia = 123;
            contaBreno.conta = 4567890;
            contaBreno.saldo = 300.00;

            ContaCorrente contaBruna = new ContaCorrente();
            contaBruna.titular = Bruna;
            contaBruna.agencia = 123;
            contaBruna.conta = 1238901;
            contaBruna.saldo = 3000;

            WriteLine(contaBreno.titular.nome);
            WriteLine(contaBreno.titular.profissao);
            WriteLine("Agencia: {0}",contaBreno.agencia);
            WriteLine("Conta: {0}", contaBreno.conta);
            WriteLine("Saldo: {0}", contaBreno.saldo);
            WriteLine("---------------------");
            
            WriteLine(contaBruna.titular.nome);
            WriteLine("Agencia: {0}",contaBruna.agencia);
            WriteLine("Conta: {0}",contaBruna.conta);
            WriteLine("Saldo: {0}",contaBruna.saldo);

            double saque = contaBreno.Sacar(50);
            WriteLine("{0} sacou {1}. Seu saldo agora é de {2}",contaBreno.titular.nome,saque,contaBreno.saldo);

            double deposito = contaBruna.Depositar(37.80);

            WriteLine("{0} recebeu um depósito de {1}. Seu saldo atualizado é de: {2}", contaBruna.titular.nome, deposito, contaBruna.saldo);
            WriteLine("-----------------");

            double transferido = contaBruna.Transferir(59.95,contaBreno);

            //Sem arredondar Saldos
            WriteLine("{0} transferiu R${1} para {2}. Saldo atual de {3} é de R${4}. Saldo atual de {5} é de R${6}", contaBruna.titular.nome,transferido,contaBreno.titular.nome,contaBruna.titular.nome,contaBruna.saldo, contaBreno.titular.nome,contaBreno.saldo);

            //Saldos arredondados
            WriteLine("{0} transferiu R${1} para {2}. Saldo atual de {3} é de R${4}. Saldo atual de {5} é de R${6}", contaBruna.titular.nome,transferido,contaBreno.titular.nome,contaBruna.titular.nome,contaBruna.saldo.ToString("F"), contaBreno.titular.nome,contaBreno.saldo.ToString("F"));


            Console.ReadKey();

        }
    }
}
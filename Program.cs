using static System.Console;
using System;
using POO1.Funcionarios;

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
                contaBruna.Agencia = 123;
                contaBruna.conta = 3245678;
                
                WriteLine(contaBruna.titular);
                WriteLine("Ag: " + contaBruna.Agencia);
                WriteLine("Conta: {0}",contaBruna.conta);
                WriteLine("saldo: {0}",contaBruna.saldo);
                WriteLine("--------------------");

                ContaCorrente contaBreno = new ContaCorrente();
                contaBreno.titular = "Breno";
                contaBreno.Agencia = 123;
                contaBreno.conta = 4567890;
                contaBreno.saldo = 300.00;

                WriteLine(contaBreno.titular);
                WriteLine("Agencia: {0}",contaBreno.Agencia);
                WriteLine("Conta: {0}", contaBreno.conta);
                WriteLine("saldo: {0}", contaBreno.saldo);
                WriteLine("---------------------");
                
                double saque = contaBreno.Sacar(100.50);
                WriteLine("{0} sacou {1}. Seu saldo agora é de {2}",contaBreno.titular,saque,contaBreno.saldo);

                double deposito = contaBruna.Depositar(137.80);

                WriteLine("{0} recebeu um depósito de {1}. Seu saldo atualizado é de: {2}", contaBruna.titular, deposito, contaBruna.saldo);
                WriteLine("-----------------");

                double transferido = contaBruna.Transferir(59.95,contaBreno);

                //Sem arredondar saldos
                WriteLine("{0} transferiu R${1} para {2}. saldo atual de {3} é de R${4}. saldo atual de {5} é de R${6}", contaBruna.titular,transferido,contaBreno.titular,contaBruna.titular,contaBruna.saldo, contaBreno.titular,contaBreno.saldo);

                //saldos arredondados
                WriteLine("{0} transferiu R${1} para {2}. saldo atual de {3} é de R${4}. saldo atual de {5} é de R${6}", contaBruna.titular,transferido,contaBreno.titular,contaBruna.titular,contaBruna.saldo.ToString("F"), contaBreno.titular,contaBreno.saldo.ToString("F"));


                Console.ReadKey();*/
                }

            //Criando Cliente sem ligação com a Conta Corrente
            Cliente Bruna = new Cliente();
            Bruna.Nome = "Bruna";
            Bruna.CPF = "111.222.333-44";
            Bruna.Profissao = "Estudante";

            Cliente Breno = new Cliente();
            Breno.Nome = "Breno";
            Breno.CPF = "234.567.890.00";
            Breno.Profissao = "Programador";
            
            WriteLine(Bruna.Nome);
            WriteLine("CPF: {0}", Bruna.CPF);
            WriteLine("Profissão: {0}",Bruna.Profissao);
            WriteLine("--------------------");

            //Criando Conta Corrente com os dados de Cliente da classe separada
            ContaCorrente contaBreno = new ContaCorrente();
            contaBreno.titular = Breno;
            contaBreno.Agencia = 123;
            contaBreno.Conta = 4567890;
            contaBreno.saldo = 300.00;

            ContaCorrente ContaBruna = new ContaCorrente();
            ContaBruna.titular = Bruna;
            ContaBruna.Agencia = 123;
            ContaBruna.Conta = 1238901;
            ContaBruna.saldo = 3000;

            //Criando ContaConstrutores
            ContaConstrutores contaC = new ContaConstrutores(123, 8905678);
            WriteLine("Imprimindo Agencia e Conta criada com construtor.");

            WriteLine("Conta de número: {0}", ContaConstrutores.ObterNumeroContas);
            WriteLine("Agencia: {0}, Conta: {1}",contaC.Agencia, contaC.Conta);
            WriteLine("---------------------");

            ContaConstrutores contaD = new ContaConstrutores(123, 4568902);
            WriteLine("Conta de número: {0}", ContaConstrutores.ObterNumeroContas);
            WriteLine("Agencia: {0}, Conta: {1}", contaD.Agencia, contaD.Conta);
            WriteLine("---------------------");

            ContaConstrutores contaE = new ContaConstrutores(123,7895431);
            WriteLine("Conta de número: {0}", ContaConstrutores.ObterNumeroContas);
            WriteLine("Agencia: {0}, Conta: {1}", contaE.Agencia, contaE.Conta);
            WriteLine("------------------------");


            Cliente Gisele = new Cliente();
            Gisele.Nome = "Gisele";
            Gisele.CPF = "890.678.456-21";
            Gisele.Profissao = "Professora";

            //Instanciando classe ContaCorrente encapsulada
            ContaCorrenteGetSets novaContaGetSet = new ContaCorrenteGetSets();
            novaContaGetSet.Titular2 = Gisele;
            novaContaGetSet.Conta = 1237890;
            novaContaGetSet.Agencia = 123;
            novaContaGetSet.Saldo = 200.00;
            

            WriteLine(contaBreno.titular.Nome);
            WriteLine(contaBreno.titular.Profissao);
            WriteLine("Agencia: {0}",contaBreno.Agencia);
            WriteLine("Conta: {0}", contaBreno.Conta);
            WriteLine("saldo: {0}", contaBreno.saldo);
            WriteLine("---------------------");
            
            WriteLine(ContaBruna.titular.Nome);
            WriteLine("Agencia: {0}",ContaBruna.Agencia);
            WriteLine("Conta: {0}",ContaBruna.Conta);
            WriteLine("Saldo: {0}",ContaBruna.saldo);

            double saque = contaBreno.Sacar(50);
            WriteLine("{0} sacou {1}. Seu saldo agora é de {2}",contaBreno.titular.Nome,saque,contaBreno.saldo);

            double deposito = ContaBruna.Depositar(37.80);

            WriteLine("{0} recebeu um depósito de {1}. Seu saldo atualizado é de: {2}", ContaBruna.titular.Nome, deposito, ContaBruna.saldo);
            WriteLine("-----------------");

            double transferido = ContaBruna.Transferir(59.95,contaBreno);

            //Sem arredondar saldos
            WriteLine("{0} transferiu R${1} para {2}. saldo atual de {3} é de R${4}. saldo atual de {5} é de R${6}", ContaBruna.titular.Nome,transferido,contaBreno.titular.Nome,ContaBruna.titular.Nome,ContaBruna.saldo, contaBreno.titular.Nome,contaBreno.saldo);

            //saldos arredondados
            WriteLine("{0} transferiu R${1} para {2}. saldo atual de {3} é de R${4}. saldo atual de {5} é de R${6}", ContaBruna.titular.Nome,transferido,contaBreno.titular.Nome,ContaBruna.titular.Nome,ContaBruna.saldo.ToString("F"), contaBreno.titular.Nome,contaBreno.saldo.ToString("F"));

            //Obtendo o saldo de forma encapsulada
            WriteLine("-------------------------");
            WriteLine("Obtendo o saldo da Conta Encapsulada");
            WriteLine("Titular: {0} .Conta: {1}. Agencia: {2} .saldo: R${3}: ",novaContaGetSet.Titular2.Nome, novaContaGetSet.Conta, novaContaGetSet.Agencia, novaContaGetSet.Saldo);
            WriteLine("------------------------");

            RegistrarBonificacao registrarBonus = new RegistrarBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "123.456.789-00";
            carlos.Salario = 2000.00;
            registrarBonus.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "234.654.658-01";
            roberta.Salario = 3000.00;
            registrarBonus.Registrar(roberta);

            Funcionario pedro = new Diretor();
            pedro.Nome = "Pedro";
            pedro.CPF = "234.789.098-10";
            pedro.Salario = 3500.00;
            registrarBonus.Registrar(pedro);

            WriteLine("Nome: {0}. Salário: R${1} . Bonificação: {2} .", carlos.Nome,carlos.Salario, carlos.GetBonificacao());
            WriteLine("-----------------------");

            WriteLine("Nome: {0}. CPF: {1}. Salario: R${2}. Bonificação: R${3} ",roberta.Nome, roberta.CPF, roberta.Salario, roberta.GetBonificacao());
            WriteLine("-------------------");

            WriteLine("Nome: {0}. Salário: R${1} . Bonificação: R${2}",pedro.Nome, pedro.Salario,pedro.GetBonificacao());
            WriteLine("---------------------");

            WriteLine("Total de bonificações pagas pela empresa: R${0}",registrarBonus.GetBonificacao());
            WriteLine("-----------------------");


            Console.ReadKey();

        }
    }
}
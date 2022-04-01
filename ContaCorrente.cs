using static System.Console;

namespace POO1
{
    public class ContaCorrente
    {
        public Cliente? titular;

        //Usando apenas GET a propriedade se torna apenas de leitura, podendo apenas ser alterada pelo construtor
        public int Agencia { get; }
        public int Conta { get; }
        public double saldo = 100;

        public ContaCorrente(int agencia, int conta)
        {
            if(conta <= 0)
            {
                throw new ArgumentException("O numero da Conta precisa ser maior que zero", nameof(Conta));
            }
            if(agencia <= 0)
            {
                throw new ArgumentException("O número da Agência precisa ser maior que zero", nameof(Agencia));
            }
            
            Agencia = agencia;
            Conta = conta;

           // taxaOperacao = 30 / TotalDeContasCRiadas;

        }
        public double Sacar(double valor)
        {
            //Propriedade readonly
            //Agencia = 234;

            if(this.saldo < valor)
            {
                return valor;
            }
            this.saldo -=valor;
            return valor;
        }
        public double Depositar(double valor)
        {
            this.saldo += valor;
            return valor;
        }

        public double Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo < valor)
            {
                return valor;
            }
            this.saldo -=valor;
            destino.Depositar(valor);
            return valor;
        }
    }
}
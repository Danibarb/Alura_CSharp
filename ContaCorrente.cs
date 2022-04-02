using static System.Console;

namespace POO1
{
    public class ContaCorrente
    {
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        private static int taxaOperacao;
        public static int TotalDeContasCriadas { get; private set; }
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

            TotalDeContasCriadas ++;    
            taxaOperacao = 30 / TotalDeContasCriadas;

        }
        public void Sacar(double valor)
        {
            //Propriedade readonly
            //Agencia = 234;
            if(saldo < 0)
            {
                throw new ArgumentException("Valor de Saque não pode ser negativo", nameof(valor));
            }
            if(saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteEx(saldo, valor);
            }
            saldo -= valor;
        }
        public double Depositar(double valor)
        {
            this.saldo += valor;
            return valor;
        }

        public void Transferir(double valor, ContaCorrente destino)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para transferencia.");
            }
            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteEx e)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw;
            }
            
            destino.Depositar(valor);
        }
    }
}
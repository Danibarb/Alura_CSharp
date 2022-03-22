using static System.Console;

namespace POO1
{
    public class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int conta;
        public double saldo = 100;

        public double Sacar(double valor)
        {
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
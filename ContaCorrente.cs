using static System.Console;

namespace POO1
{
    public class ContaCorrente
    {
        public Cliente? titular;
        public int Agencia { get; set; }
        public int Conta { get; set; }
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
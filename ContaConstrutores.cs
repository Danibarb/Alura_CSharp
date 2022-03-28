namespace POO1
{
    public class ContaConstrutores
    {
        public Cliente? Titular3 { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public double saldo { get; set; }
        public static int ObterNumeroContas { get; private set; }

        public ContaConstrutores(int agencia, int conta)
        {
            Agencia = agencia;
            Conta = conta;
            ObterNumeroContas++;
            
        }


    }
}
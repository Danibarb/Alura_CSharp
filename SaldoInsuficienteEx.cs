namespace POO1
{
    public class SaldoInsuficienteEx : OperacoesFinanceirasEx
    {
        public double Saldo { get;}
        public double ValorSaque { get; }
        public SaldoInsuficienteEx()
        {

        }
        public SaldoInsuficienteEx(double saldo, double valorsaque)
            : this("Tentativa de saque do valor de " + valorsaque + " em uma conta com saldo de" + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorsaque; 
        }
        public SaldoInsuficienteEx(string mensagem)
            : base(mensagem)
        {
        }
        public SaldoInsuficienteEx(string mensagem, Exception exccaoInterna) : base(mensagem, exccaoInterna)
        {

        }    
    }
}   
    
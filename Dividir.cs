using static System.Console;

//Tratamento de Exceções

namespace POO1.Excecoes
{
    public class Dividir
    {
        public static int _Dividir( int numero, int divisor)
        {
            ContaCorrente conta = null;
            //WriteLine(conta.saldo);
            return numero / divisor;
        }

        public static void Metodo()
        {
           
            TestaDivisao(0);
            
        }

        public static void TestaDivisao(int divisor)
        {
            _Dividir(10, divisor);
        }
    }
}
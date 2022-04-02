
namespace POO1
{
    public class OperacoesFinanceirasEx : Exception
    {
        public OperacoesFinanceirasEx()
        {

        }
        public OperacoesFinanceirasEx(string mensagem) : base(mensagem)
        {

        }
        public OperacoesFinanceirasEx(string mensagem, Exception excecaoInterna): base(mensagem, excecaoInterna)
        {

        }

        
    }
}
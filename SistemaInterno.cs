using POO1.Sistemas;
using static System.Console;

namespace POO1.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if(usuarioAutenticado)
            {
                WriteLine("Bem vindo ao sistema Interno");
                return true;
            }
            else 
            {
                WriteLine("Acesso negado");
                return false;
            }
        }
    }   
}
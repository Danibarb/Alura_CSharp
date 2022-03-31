using POO1.Funcionarios;
using static System.Console;

namespace POO1.Sistemas
{
    //Interfaces são usadas quando se precisa de múltiplas heranças
    //Interfaces não tem implementação de métodos, apenas assinatura
    public interface IAutenticavel
    {
        public bool Autenticar(string senha);
    }
}
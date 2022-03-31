using POO1.Sistemas;
using static System.Console;

namespace POO1.Funcionarios
{
    public abstract class FuncionarioAutenticavel: Funcionario, IAutenticavel
    {
        public string? Senha { get; set; }

        public FuncionarioAutenticavel(string cpf, double salario): base(cpf, salario)
        {

        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
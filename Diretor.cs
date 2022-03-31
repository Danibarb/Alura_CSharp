using POO1.Sistemas;
using static System.Console;

namespace POO1.Funcionarios
{
    public class Diretor: FuncionarioAutenticavel
    {
        //construtor para obrigar o preenchimento do CPF dos funcionarios
        //Herdado da classe base.
        public Diretor(string cpf, double salario): base(cpf, salario)
        {
            WriteLine("Criando Diretor.");
        }

        public override double AlterarSalario()
        {
           return Salario *= 1.15;
        }
        public override double GetBonificacao()
        {
            return Salario *= 0.5;
        }
    }
}
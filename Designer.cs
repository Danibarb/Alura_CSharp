using static System.Console;

namespace POO1.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf, double salario): base (cpf, salario)
        {
            WriteLine("Criando Designer.");
        }
        public override double AlterarSalario()
        {
            return Salario *= 0.11;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.17;
        }
    }
}
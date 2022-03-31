using static System.Console;
using POO1.Sistemas;

namespace POO1.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf, double salario) : base(cpf, salario)
        {
            WriteLine("Criando Gerente de Contas");
        }
        public override double AlterarSalario()
        {
            return Salario *= 0.5;
        }
        public override double GetBonificacao()
        {
            return Salario *= 0.25;
        }
    }
}
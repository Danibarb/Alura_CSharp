using static System.Console;

namespace POO1.Funcionarios
{
    public class Auxiliar: Funcionario
    {
        public Auxiliar(string cpf, double salario): base( cpf, salario)
        {
            WriteLine("Criando Auxiliar.");
        }
        public override double AlterarSalario()
        {
            return Salario *= 0.10;
        }
        public override double GetBonificacao()
        {
            return Salario *= 0.20;
        }
    }
}
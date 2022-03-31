namespace POO1.Funcionarios
{
    public abstract class Funcionario
    {
        public string? Nome { get; set; }
        public string? CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
        }

        //Tornando os métodos Abstracts para a obrigatoriedade da implementação dos mesmos nas classes filhas
        public abstract double AlterarSalario();

        public abstract double GetBonificacao();
    }
}
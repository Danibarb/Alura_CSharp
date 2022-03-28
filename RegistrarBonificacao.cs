using POO1.Funcionarios;
namespace POO1
{
    public class RegistrarBonificacao
    {
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public virtual double GetBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
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

        public void Registrar(Diretor diretor)
        {
            _totalBonificacao += diretor.GetBonificacao();
        }
        public double GetBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
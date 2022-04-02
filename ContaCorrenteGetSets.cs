using static System.Console;

namespace POO1
{
    public class ContaCorrenteGetSets
    {
        public Cliente? Titular2 {get; set;}
        public int Agencia { get; set; }
        public int Conta { get; set; }  
        private double _saldo = 100;

        public double Saldo 
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value <0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        
    }
}
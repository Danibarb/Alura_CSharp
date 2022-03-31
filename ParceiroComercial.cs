using POO1.Sistemas;
using static System.Console;

namespace POO1
{
    //Nova classe de acesso que recebe a inteface IAutenticavel
    public class ParceiroComercial : IAutenticavel
    {
        public string? Senha { get; set; }

        public bool Autenticar(string senha)
        {
           return Senha == senha;
        }
    }
}
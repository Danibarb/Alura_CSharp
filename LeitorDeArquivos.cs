using System.IO;
using static System.Console;

namespace POO1
{
    public class LeitorDeArquivos : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;
           // throw new FileNotFoundException;
            WriteLine("Abrindo arquivo", arquivo);
        }
        public string LerProximaLinha()
        {
            WriteLine("Lendo linhas do arquivo");

            //Exceção de Entrada e Saída
            throw new IOException();

            //return "Linha do Arquivo";
        }

        public void Dispose()
        {
        WriteLine("Fechando arquivo de leitura.");
        }
        
    }
}
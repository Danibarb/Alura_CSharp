using static System.Console;
public class Program
{
    public static void Main()
    {
        for(int contadorLinha = 0; contadorLinha <= 10; contadorLinha++)
        {
            for(int contadorColuna = 1; contadorColuna <= contadorLinha; contadorColuna++)
            {
                Write("*");
            }
            WriteLine();
        }

        for(char alfabeto ='`'; alfabeto <= 'z'; alfabeto++)
        {
            for(char colunasAlfabeto = '`'; colunasAlfabeto < alfabeto; colunasAlfabeto++)
            {
                Write(alfabeto); 
            }
            WriteLine();
        }
    }
}
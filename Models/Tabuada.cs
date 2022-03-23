using static System.Console;
namespace Aula_Youtube_DaniloAparecido.Models
{
    public class Tabuada
    {
        public void CalculoTabu()
        {   
            
            var numero = int.Parse(ReadLine());
            for (int i = 1;i <= 10;i++)
            {
                WriteLine(numero + " X " + i + "= " + (numero*i));
            }
        }
    }
}
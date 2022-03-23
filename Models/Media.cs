using static System.Console;
namespace Aula_Youtube_DaniloAparecido.Models
{
    public class Media
    {   double Resultado,Valor,Total;
    
        public void Calculo()
        {   
            double Valor = 0;            
            for (double i = 1;i <=4;i++)
            {
            WriteLine($"{i}º Nota :");
            Valor  = double.Parse(ReadLine());
            Resultado = Resultado + Valor;
            Total = Resultado/4;
            }
            WriteLine($"O Resultado da media das 4 notas do aluno é {Total}"); 
        }


    }
}
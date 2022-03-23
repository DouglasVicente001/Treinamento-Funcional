using static System.Console;
namespace Aula_Youtube_DaniloAparecido.Models
{
    public class ImparPar
    {
        int Num;
        public void Descobrindo()
        {   
            while(true)
            {
                Num = int.Parse(ReadLine());

                    if (Num % 2 == 0) //Par
                    {
                    WriteLine("O numero é par!");
                    }
                    else //Impar
                    {
                    WriteLine("O numero é ímpar!");
                    }
        
                WriteLine ("\nDeseja Continuar descobrindo novos valores?"+ "\n\nPressione [1]Continuar/ [0]Parar e voltar ao Menu.");
                var Opcao = int.Parse(ReadLine());
                    if (Opcao ==0)
                    {
                    WriteLine("Insira o novo valor!");
                    break;
                    }
                    else if (Opcao != 0)
                    {
                    WriteLine("Insira o novo valor!");
                    }

            }
        
        }
    }
}
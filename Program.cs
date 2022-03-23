using Aula_Youtube_DaniloAparecido.Models;
using static System.Console;
namespace Aula_Youtube
{
  class program
  {
    public static void Main(string[]args)
    { 
      int Valor;
      while(true)
      {
      WriteLine();
      string mensagem = "MENU\n"+
      "\nUtilizando Programa funcional"+
      "\n"+

      "\n 0- Sair do programa." + 
      "\n 1- Ler arquivos." + 
      "\n 2- Para executar Tabuada." + 
      "\n 3- Calcular Media dos alunos."+
      "\n 4- Descobrir se um número é impar ou par.";
      WriteLine(mensagem);
      Valor = int.Parse(ReadLine());
          if (Valor == 0)
          {
          WriteLine("   Obrigado por utilizar nossos serviços!");
          break;
          }
          else if (Valor == 1)
          {
          WriteLine("   Percorrendo lista de nomes: ");
          Arquivos List1 = new Arquivos();
          List1.Tabela();
          }
          else if(Valor ==2)
          {
          WriteLine("Digite o valor da atabuada que deseja calcular: ");
          Tabuada T1 = new Tabuada();
          T1.CalculoTabu();
          }
          else if (Valor ==3)
          {
          Media M1= new Media ();
          WriteLine("Insira as 4 notas do aluno que deseja calcular a media: ");
          M1.Calculo();
          }
          else if (Valor ==4)
          {
          ImparPar ImparPar = new ImparPar();
          WriteLine("Insira o valor que deseja descobrir ");
          ImparPar.Descobrindo();
          }
          else if (Valor > 4)
          {
          WriteLine("Caso deseje sair do programa Selecione a opção [0] do Menu." + "\nValor inválido. Redirecionando você para o inicio do programa...");
          }
          
      }
    }
  }
}
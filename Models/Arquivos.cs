using static System.Console;
using System.Collections.Generic;
namespace Aula_Youtube_DaniloAparecido.Models
{
    public class Arquivos
    {
        public void Tabela()
        {
            
            List<string> a = new List<string>();
            WriteLine();
            a.Add("    Douglas");
            a.Add("    Frederico");
            a.Add("    Fernanda");
            a.Add("    Jerfao");
            a.Add("    Gui");
            
            foreach (string nome in a)
            {
                WriteLine(nome);
            }
        }
    }
}
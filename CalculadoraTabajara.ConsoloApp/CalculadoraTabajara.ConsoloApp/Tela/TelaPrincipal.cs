using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajara.ConsoloApp
{
    public class TelaPrincipal
    {
        public string MostrarMenuPrincipal()
        {
            string opcaoMenu;
            Console.WriteLine("1 - para somar");
            Console.WriteLine("2 - para subtrair");
            Console.WriteLine("3 - para multiplicar");
            Console.WriteLine("4 - para dividir");
            Console.WriteLine("5 - para listar");
            Console.WriteLine("S - para sair");
            return opcaoMenu = Console.ReadLine();
        }


    }
}

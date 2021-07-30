using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajara.ConsoloApp
{
    class Program
    {


        static void Main(string[] args)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            
            Operacoes operacoes = new Operacoes();

            
            
            string opcaoMenu = string.Empty;
            string tipoOperacao = string.Empty;
            double primeiroNumero = 0;
            double segundoNumero = 0;


            
            opcaoMenu = telaPrincipal.MostrarMenuPrincipal();

            switch (opcaoMenu)
            {

                case "1":
                    {
                        ImputarNumeros(out primeiroNumero, out segundoNumero);
                        tipoOperacao = "+";
                        double resultado = operacoes.RealizarCalculo(tipoOperacao, primeiroNumero, segundoNumero);

                        Console.WriteLine("O resultado é: " + resultado);
                        Console.ReadLine();
                        break;

                    }
            }
        }

        private static void ImputarNumeros(out double primeiroNumero, out double segundoNumero)
        {
            Console.WriteLine("Informe o primeiro numero");
            primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundoNumero numero");
            segundoNumero = Convert.ToDouble(Console.ReadLine());
        }
    }
}


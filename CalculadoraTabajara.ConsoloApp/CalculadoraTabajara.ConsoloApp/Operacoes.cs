using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajara.ConsoloApp
{
    public class Operacoes
    {
        private double resultado = 0;

        public double RealizarCalculo(string operacao,double primeiroNumero, double segundoNumero)
        {
            switch (operacao)
            {
                case "+":
                    {
                        resultado = primeiroNumero + segundoNumero;
                        return resultado;
                        

                }
            }

            return resultado;
        }

    }
}

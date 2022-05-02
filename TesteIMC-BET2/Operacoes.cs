using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC_BET2
{
    public static class Operacoes
    {
        public static double CalculaIMC(double peso, double altura)
        {
            return (peso / (altura * altura));

        }
    }
}

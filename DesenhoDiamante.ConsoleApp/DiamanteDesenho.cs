using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesenhoDiamante.ConsoleApp
{
    public class DiamanteDesenho
    {
        public string ParteCima(int NumeroDiamante)
        {
            int Soma = 0;
            StringBuilder Diamante = new StringBuilder();
            int EspacoSuperior = NumeroDiamante / 2;
            int Espacos = EspacoSuperior;
            int QuantidadeX = 1;
            for (int i = EspacoSuperior; i <= NumeroDiamante; i++)
            {
                if (QuantidadeX >= NumeroDiamante || Espacos < 0)
                {
                    break;
                }

                Diamante.AppendLine(new string(' ', Espacos) + new string('X', QuantidadeX));
                Soma += 2;
                QuantidadeX = 1 + Soma;
                Espacos -= 1;
            }
            return Diamante.ToString();
        }
        public static void ParteMeio(int NumeroDiamante)
        {
            Console.WriteLine(new string('X', NumeroDiamante));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesenhoDiamante.ConsoleApp
{
    class Textos
    {
        public static void ValidarCaracter()
        {
            Console.Clear();
            Console.WriteLine("Você digitou uma letra");
            Console.WriteLine("Precione ENTER para continuar...");
            Console.ReadLine();
        }

        public static void ValidarNumero()
        {
            Console.Clear();
            Console.WriteLine("Você digitou um número inválido");
            Console.WriteLine("Precione ENTER para continuar...");
            Console.ReadLine();
        }

        public static void Introducao()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao programa de desenho de diamante de números impares (estranhamente especifico)");
            Console.WriteLine("Digite um número ímpar para desenhar um diamante");
        }

        public static void Decoracao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("======================================================");
            Console.WriteLine("   *        *      *      *        *     *        *   ");
            Console.WriteLine("        *      *       DIAMANTE     *        *        ");
            Console.WriteLine("  *         *       *     *        *        *      *  ");
            Console.WriteLine("======================================================");
        }
    }
}

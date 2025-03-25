namespace DesenhoDiamante.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite um número impar (inteiro): ");
            int NumeroDiamante = Convert.ToInt32(Console.ReadLine());
            int Espacos = 0;
            int Subtracao = 0;
            int EspacoCima;
            int Soma = 0;

            //EspacoCima = NumeroDiamante / 2;
            //int QuantidadeX = 1;
            //for (int i = 0; i < EspacoCima; i++)
            //{
            //    Espacos -= 1;
            //    Soma += 2;

            //    QuantidadeX = 2 + Soma;
            //    if (QuantidadeX < 0)
            //        break;

            //    Console.WriteLine(new string(' ', Espacos) + new string('X', QuantidadeX));
            //}

            //Console.WriteLine(new string('X', NumeroDiamante));

            //Espacos = 0;
            //Subtracao = 0;

            for (int i = 0; i < NumeroDiamante; i++)
            {

                Espacos += 1;
                Subtracao += 2;

                int QuantidadeX = NumeroDiamante - Subtracao;
                if (QuantidadeX < 0)
                    break;

                Console.WriteLine(new string(' ', Espacos) + new string('X', QuantidadeX));
            }



            //Console.WriteLine(new string(' ', 2) + new string('X', NumeroDiamante - 4));
            //Console.WriteLine(new string(' ', 1) + new string('X', NumeroDiamante - 2));
            //Console.WriteLine(new string('X', NumeroDiamante));
            //Console.WriteLine(new string(' ', 1) + new string('X', NumeroDiamante - 2));
            //Console.WriteLine(new string(' ', 2) + new string('X', NumeroDiamante - 4));
        }
    }
}

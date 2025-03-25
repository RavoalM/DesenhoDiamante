namespace DesenhoDiamante.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite um número impar (inteiro): ");
            int NumeroDiamante = Convert.ToInt32(Console.ReadLine());
            int Subtracao = 0;
            int Soma = 0;


            int EspacoSuperior = NumeroDiamante / 2;
            int Espacos = EspacoSuperior;
            int QuantidadeX = 1;
            for (int i = EspacoSuperior; i <= NumeroDiamante; i++)
            {
               
              if (QuantidadeX >= NumeroDiamante || Espacos < 0)
              {
                break;
              }

                Console.WriteLine(new string(' ', Espacos) + new string('X', QuantidadeX));
                Soma += 2;
                QuantidadeX = 1 + Soma;
                Espacos -= 1;
            }

            Console.WriteLine(new string('X', NumeroDiamante));

            Espacos = 0;
            Subtracao = 0;
           
            for (int i = 0; i < NumeroDiamante; i++)
            {

                Espacos += 1;
                Subtracao += 2;

                QuantidadeX = NumeroDiamante - Subtracao;
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

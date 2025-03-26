namespace DesenhoDiamante.ConsoleApp
{
    internal class Program
    {
        static int Espacos = 0;
        static int Subtracao = 0;
        static void Main()
        {
            while (true)
            {
                Console.Write("Digite um número impar (inteiro): ");
                if (!int.TryParse(Console.ReadLine(), out int NumeroDiamante))
                {
                    Console.Clear();
                    Console.WriteLine("Você digitou uma letra");
                    continue;
                }


                if (NumeroDiamante % 2 != 0 && NumeroDiamante > 1)
                {
                    string ParteCima = new DiamanteDesenho().ParteCima(NumeroDiamante).TrimEnd();
                    Console.WriteLine(ParteCima);
                    
                    DiamanteDesenho.ParteMeio(NumeroDiamante);

                    for (int i = 0; i < NumeroDiamante; i++)
                    {

                        Espacos += 1;
                        Subtracao += 2;

                        int QuantidadeX = NumeroDiamante - Subtracao;
                        if (QuantidadeX < 0)
                            break;

                        Console.WriteLine(new string(' ', Espacos) + new string('X', QuantidadeX));
                    }
                    break;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Número inválido. Digite um número ímpar e maior que 1.");
                    continue;
                }
            }
        }

    }
}

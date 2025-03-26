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

                   string ParteBaixo = new DiamanteDesenho().ParteBaixo(NumeroDiamante).TrimEnd();
                    Console.WriteLine(ParteBaixo);
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

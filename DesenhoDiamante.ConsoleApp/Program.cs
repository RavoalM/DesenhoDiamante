namespace DesenhoDiamante.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Digite um número impar (inteiro): ");
                if (!int.TryParse(Console.ReadLine(), out int NumeroDiamante))
                {
                    Textos.ValidarCaracter();
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
                    Textos.ValidarNumero();
                    continue;
                }

            }
        }

    }
}

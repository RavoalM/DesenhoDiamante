namespace DesenhoDiamante.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Textos.Introducao();
                if (!int.TryParse(Console.ReadLine(), out int NumeroDiamante))
                {
                    Textos.ValidarCaracter();
                    continue;
                }

                if (NumeroDiamante % 2 == 0)
                {
                    Textos.ValidarNumero();
                    continue;
                }
                else if (NumeroDiamante <= 1)
                {
                    Textos.ValidarNumero();
                    continue;
                }

                else if (NumeroDiamante % 2 != 0 && NumeroDiamante > 1)
                {
                    Textos.Decoracao();

                    string ParteCima = new DiamanteDesenho().ParteCima(NumeroDiamante).TrimEnd();
                    Console.WriteLine(ParteCima);

                    DiamanteDesenho.ParteMeio(NumeroDiamante);

                    string ParteBaixo = new DiamanteDesenho().ParteBaixo(NumeroDiamante).TrimEnd();
                    Console.WriteLine(ParteBaixo);
                    break;
                }

            }
        }

    }
}

namespace DesenhoDiamante.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite um número impar (inteiro): ");
            int NumeroDiamante = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('X', NumeroDiamante));
        }
    }
}

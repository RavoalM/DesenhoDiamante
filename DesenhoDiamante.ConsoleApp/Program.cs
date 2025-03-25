namespace DesenhoDiamante.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite um número impar (inteiro): ");
            int NumeroDiamante = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string(' ', 2) + new string('X', NumeroDiamante - 4));
            Console.WriteLine(new string(' ', 1) + new string('X', NumeroDiamante - 2));
            Console.WriteLine(new string('X', NumeroDiamante));
            Console.WriteLine(new string(' ', 1) + new string('X', NumeroDiamante - 2));
            Console.WriteLine(new string(' ', 2) + new string('X', NumeroDiamante - 4));
        }
    }
}

// See https://aka.ms/new-console-template for more information
namespace appnetcore6
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null)
            {
                Console.WriteLine("Olá, mundo!!!");
            }
            else {
                Console.WriteLine(args[0].ToString());
            }
        }
    }
}
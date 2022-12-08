using Course;
using System.Globalization;

namespace SistemaDeEstoquePOOcomCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 2);

            p.Nome = "TV Nova";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
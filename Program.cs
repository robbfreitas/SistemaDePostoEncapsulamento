using Course;
using System.Globalization;

namespace SistemaDeEstoquePOOcomCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 2);

            

            Console.WriteLine(p);
        }
    }
}
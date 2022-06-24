using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRIPTO_API;

namespace TESTE_CRIPTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o texto a codificar: ");
            string input = Console.ReadLine();
            string cripto = Cripto.Codificar(input);
            Console.WriteLine(cripto);
            Console.WriteLine(Cripto.Decodificar(cripto));


            ConsoleKey c = ConsoleKey.D0;
            while(c != ConsoleKey.Escape) {
                c = Console.ReadKey().Key;
            }
       
        }
    }
}

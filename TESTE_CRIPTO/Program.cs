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
           

            
            string input = Console.ReadLine();
            string d = Cripto.Codificar(input);
            Console.Write(d);

            Console.ReadKey();
        }
    }
}

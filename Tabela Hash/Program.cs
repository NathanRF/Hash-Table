using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Hash tabela = new Hash();

            Console.Write("Insira uma palavra: ");
            var palavra = Console.ReadLine();

            foreach (var letra in palavra)
            {
                tabela.Inserir(new Elemento(letra));
            }

            Console.WriteLine("Palavra inserida com sucesso");

            foreach (var letra in palavra)
            {
                Console.WriteLine(tabela.Buscar(letra).Letra);
            }
            

            Console.WriteLine("Pressione qualquer tecla pra continuar...");
            Console.ReadKey();            
        }
    }
}

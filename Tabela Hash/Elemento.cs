using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela_Hash
{
    class Elemento:IDado
    {
        public char Letra { get; set; }
        public Elemento proximo;        

        public Elemento(char dado)
        {
            this.Letra = dado;
            proximo = null;
        }
    }
}

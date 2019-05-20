using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela_Hash
{
    class Lista
    {
        Elemento first;
        Elemento last;

        public Lista()
        {
            first = new Elemento(' ');
            last = first;
        }

        public bool Vazia
        {
            get { return first == last; }
        }

        public void Inserir(IDado novo)
        {
            Elemento aux = new Elemento(novo.Letra);

            if (Vazia)
            {
                first.proximo = aux;
                last = aux;
            }
            else
            {
                last.proximo = aux;
                last = aux;
            }
        }

        public IDado Localizar(char Letra)
        {
            Elemento aux;

            aux = first;
            while(aux != null && aux.Letra != Letra)
            {
                aux = aux.proximo;
            }
            return aux;
        }
    }
}

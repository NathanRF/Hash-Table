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

        public IDado Remover(char letra)
        {
            if (this.Vazia) return null;

            Elemento aux = this.first;

            while ((aux.proximo != null) && (!aux.proximo.Letra.Equals(letra)))
            {
                aux = aux.proximo;

                if (aux.proximo == null) return null;
                else
                {
                    Elemento auxRet = aux.proximo;
                    aux.proximo = auxRet.proximo;
                    if (auxRet == this.last)
                        this.last = aux;
                    else
                        auxRet.proximo = null;

                    return (IDado)auxRet;
                }
            }
            return null;
        }

        //public IDado Localizar(char letra)
        //{
        //    int posAux = 0;
        //    Elemento aux = first;

        //    while ((aux != null) && (!aux.Letra.Equals(letra)))
        //    {
        //        aux = aux.proximo;
        //        posAux++;
        //    }

        //    if (aux == null)
        //        return null;
        //    else
        //        return (IDado)aux;
        //}

        public IDado Localizar(char Letra)
        {
            Elemento aux;

            aux = first.proximo;
            while(aux != null && aux.Letra != Letra)
            {
                aux = aux.proximo;
            }
            return aux;
        }
    }
}

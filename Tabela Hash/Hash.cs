using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela_Hash
{
    class Hash
    {
        private int Tam_Max = 31;
        public Lista[] dados;

        public Hash()
        {
            dados = new Lista[Tam_Max];
        }

        private int FuncaoHash(int chave)
        {
            return chave % Tam_Max;
        }

        //private int Colisao(int pos)
        //{
        //    while (!dados[pos].Vazia)
        //    {
        //        pos++;
        //        pos = pos % Tam_Max;
        //    }
        //    return pos;
        //}

        //public void Inserir(IDado novo)
        //{
        //    int auxPos = FuncaoHash(novo.Letra);
        //    auxPos = Colisao(auxPos);

        //    dados[auxPos].Inserir(novo);
        //}

        //New

        public void Inserir(IDado dado)
        {
            var posicao = (FuncaoHash(dado.Letra));

            if (dados[posicao] == null)
            {
                dados[posicao] = new Lista();
                dados[posicao].Inserir(dado);
            }
            else
            {
                dados[posicao].Inserir(dado);
            }
        }

        //public IDado Buscar(char letra)
        //{
        //    int auxPos = FuncaoHash(letra);
        //    IDado auxItem = ColisaoBusca(auxPos, letra);
        //    return auxItem;
        //}

        //New

        public IDado Buscar(char letra)
        {
            IDado aux = dados[FuncaoHash(letra)].Localizar(letra);

            if (aux == null)
                return null;
            else
                return dados[FuncaoHash(letra)].Localizar(letra);
        }

        //private IDado ColisaoBusca(int pos, char letra)
        //{
        //    while (dados[pos] != null)
        //    {
        //        if (dados[pos].Localizar(letra).Equals(letra))
        //        {
        //            if (!dados[pos].Vazia)
        //                return dados[pos];
        //            else
        //                return null;
        //        }
        //        else
        //        {
        //            pos++;
        //            pos = pos % Tam_Max;
        //        }
        //        return dados[pos];
        //    }
        //}
    }
}

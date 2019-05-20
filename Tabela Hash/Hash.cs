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

        // Calcula a posição do vetor dados na qual o 'char' será armazenado
        // baseado no resto da divisão por um número primo
        private int FuncaoHash(int chave)
        {
            return chave % Tam_Max;
        }

        // Testa se a letra a ser inserida já não foi armazenada
        private bool Colisao(IDado dado)
        {
            return Buscar(dado.Letra) != null;                            
        }

        // Quarda um caracter no vetor de dados
        public void Inserir(IDado dado)
        {
            var posicao = (FuncaoHash(dado.Letra)); // calcula a posição na qual o Hash será armazenado

            if (dados[posicao] == null) // instancia a posição do vetor dados caso necessário  
                dados[posicao] = new Lista();

            if (!Colisao(dado)) // Só armazena o caracter se ele já não estiver quardado
                dados[posicao].Inserir(dado);
        }

        // Verifica se um caracter está no vetor
        public IDado Buscar(char letra)
        {
            IDado aux = dados[FuncaoHash(letra)].Localizar(letra);

            if (aux == null)
                return null;
            else
                return dados[FuncaoHash(letra)].Localizar(letra);
        }
    }
}

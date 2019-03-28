// RA: 18203 - Danilo de Oliveira Nunes
// RA: 18207 - João Victor Javitti Alves
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizEsparsa
{
    class ListaLigadaCruzada
    {
        // atributos nescessários para a criação de uma lista ligada cruzada
        int linhas, colunas;
        Celula cabeca;

        // retorno quando a célula não está na matriz
        public const int padrao = 0;

        // propriedade que retorna valor representativo do número de linhas da matriz e
        // permite alterá-lo se for maior que zero, mas somente internamente, na classe
        public int Linhas
        {
            get => linhas;
            private set
            {
                if (value > 0)
                    this.colunas = value;
                else
                    throw new Exception("O número de linhas deve ser maior que 0.");
            }
        }

        // propriedade que retorna valor representativo do número de colunas da matriz e
        // permite alterá-lo se for maior que zero, mas somente internamente, na classe
        public int Colunas
        {
            get => colunas;
            private set
            {
                if (value > 0)
                    this.linhas = value;
                else
                    throw new Exception("O número de colunas deve ser maior que 0.");
            }
        }

        // retorna variável booleana de verdadeiro caso a matriz não esteja alocada na memória e falso para o contrário
        public bool Desalocada()
        {
            return this.cabeca == null;
        }

        // matriz construida no modelo MxN, linhas por colunas, inicializando os atributos com as propriedades e a celula principal nula
        public ListaLigadaCruzada(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;

            cabeca = new Celula(padrao, -1, -1);

            // celula que gerará outras para formar linhas e colunas da matriz
            Celula geradora = cabeca;

            // cria colunas da matriz deixando os ponteiros abaixo das celulas valendo uma celula com este ponteiro -1
            for(int i = 0; i < this.colunas; i++)
            {
                Celula novaCelulaColuna = new Celula(padrao, -1, i);

                geradora.Abaixo = geradora; //?
                geradora.Direita = novaCelulaColuna;
                geradora = geradora.Direita;
            }
            // coloca os últimos que não seriam acessados e faz com que o último aponte para o primeiro, tornando a lista circular
            geradora.Abaixo = geradora;
            geradora.Direita = cabeca; // mesmo valor da geradora no começo

            // prepara para gerar as linhas, reiniciando os atributos
            geradora = cabeca;

            for(int i = 0; i < this.linhas; i++)
            {
                Celula novaCelulaLinha = new Celula(padrao, i, -1);

                // verifica se é a cabeça para não perder a lista das colunas
                if (geradora != cabeca)
                    geradora.Direita = geradora;

                geradora.Abaixo = novaCelulaLinha;
                geradora = geradora.Abaixo; // mesmo valor da geradora no começo
            }
            // coloca os últimos que não seriam acessados e faz com que o último aponte para o primeiro, tornando a lista circular
            geradora.Direita = geradora;
            geradora.Abaixo = cabeca;
        }

        public void InserirElemento(double elemento, int linha, int coluna)
        {
            // condições que verificam a validade dos parâmetros passados
            if (linha <= 0 || linha >= this.linhas)
                throw new Exception("Linha fora dos limites da matriz."); // ArgumentOutOfRangeException

            if (coluna <= 0 || coluna >= this.colunas)
                throw new Exception("coluna fora dos limites da matriz."); 

            if (elemento == padrao)
                throw new Exception("O valor a ser guardado na matriz não pode ser 0."); // ArgumentException

            // declaração das Celulas a serem usadas para encontrar a poição requerida para a inserção
            Celula celLinha = cabeca;
            Celula celColuna = cabeca;

            // percorrem a lista das colunas e a das linhas alterando o valor das celulas para as respectivas requeridas nos parâmetro
            for (int i = 0; i <= coluna; i++)
                celColuna = celColuna.Direita;

            for (int j = 0; j <= coluna; j++)
                celLinha = celLinha.Direita;

            // criamos duas Celulas que armazenarão o atual e o anterior da linha onde percorreremos na coluna
            Celula anterior = celLinha;
            Celula atual = celLinha.Direita;

            while(atual.Coluna < coluna && atual.Coluna != -1)
            {

            }
        }
    }
}

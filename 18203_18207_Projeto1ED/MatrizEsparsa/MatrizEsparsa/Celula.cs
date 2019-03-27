// RA: 18203 - Danilo de Oliveira Nunes
// RA: 18207 - João Victor Javitti Alves
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizEsparsa
{
    class Celula
    {
        // atributos nescessários para a utilização da célula
        private double valor;
        private int linha, coluna;
        private Celula direita, abaixo;

        // construtor que requer o valor a ser guardado pela célula, sua linha e sua coluna na matriz
        public Celula(double valor, int linha, int coluna)
        {
            this.valor = valor;
            this.linha = linha;
            this.coluna = coluna;
        }

        // retorna o valorarmazenado pela célula 
        public double Valor { get => valor; set => valor = value; }
        // retorna valor da linha onde a célula se encontra na matriz
        public int Linha { get => linha; set => linha = value; }
        // retorna valor da coluna onde a célula se encontra na matriz
        public int Coluna { get => coluna; set => coluna = value; }
        //  ponteiro para a Celula a direita desta na matriz
        public Celula Direita { get => direita; set => direita = value; }
        // ponteiro para a Celula abaixo desta na matriz
        public Celula Abaixo { get => abaixo; set => abaixo = value; }

        // método toString() que retorna os valores da célula no formato (l,c,v)
        public override string ToString()
        {       
            return "(" + this.linha + ", " + this.coluna + ", " + this.valor + ")";
        }
    }
}

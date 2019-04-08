using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MatrizEsparsa
{
    public partial class FrmMatrizEsparsa : Form
    {
        ListaLigadaCruzada lista, lista2, resultado;

        public void LerArquivo()
        {

            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                StreamReader arquivo = new StreamReader(dlgAbrir.FileName);
                int linhas = int.Parse(arquivo.ReadLine()); //Lê-se as quantidade de linhas e colunas do arquivo
                int colunas = int.Parse(arquivo.ReadLine());
                ListaLigadaCruzada li = new ListaLigadaCruzada(linhas, colunas);//Cria-se uma nova para não ser necessário 
                                                                                //escrever o código duas vezes

                while (!arquivo.EndOfStream)
                {
                    string texto = arquivo.ReadLine();

                    int linha = int.Parse(texto.Substring(1, 2));//Busca de dentro da string os valores necessários para a inclusão
                    int col = int.Parse(texto.Substring(4, 2));
                    double valor = double.Parse(texto.Substring(7, 5));

                    li.InserirElemento(valor, linha, col);
                }

                if (rbLista1.Checked) //Caso foi solicitado pelo usuário que esse arquivo seja a lista1, exibi-la no primeiro DGV
                {
                    lista = li;
                    lista.ExibirDataGridview(dgvUm);
                }
                else //Caso não, exibi-lo no segundo
                {
                    lista2 = li;
                    lista2.ExibirDataGridview(dgvDois);
                }
            }
        }
        public FrmMatrizEsparsa()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (numColuna.Value == 0 || numLinha.Value == 0)
                MessageBox.Show("Não é possível criar matriz vazia");


            //Cria-se uma nova, pelo mesmo motivo anteriror
            ListaLigadaCruzada lis = new ListaLigadaCruzada(Convert.ToInt32(numLinha.Value), Convert.ToInt32(numColuna.Value));

            if (rbLista1.Checked)
            {
                lista = lis; //Caso seja solicitado a lista1
                lista.ExibirDataGridview(dgvUm);
            }
            else
            {
                lista2 = lis; //Caso seja a lista2
                lista2.ExibirDataGridview(dgvDois);
            }
        }

        private void FrmMatrizEsparsa_Load(object sender, EventArgs e)
        {

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            if (rbLista1.Checked)
            {
                if (lista == null)
                    throw new Exception("Matriz Vazia");//Nesse caso não é possível realizar com uma lista padrão, 
                                                        //então o código deve ser feito duas vezes

                //Chama-se os métodos já implementados na ListaLigadaCruzada
                lista.InserirElemento(double.Parse(txtValor.Text), Convert.ToInt32(numLinha.Value), Convert.ToInt32(numColuna.Value));
                lista.ExibirDataGridview(dgvUm);
            }
            else
            {
                if (lista2 == null)
                    throw new Exception("Matriz Vazia");
                lista2.InserirElemento(double.Parse(txtValor.Text), Convert.ToInt32(numLinha.Value), Convert.ToInt32(numColuna.Value));
                lista2.ExibirDataGridview(dgvDois);
            }

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (rbLista1.Checked)
            {
                if (lista == null)
                    throw new Exception("Matriz Vazia");
                //Chama-se os métodos já implementados na ListaLigadaCruzada
                lista.RemoverEm(Convert.ToInt32(numLinha.Value), Convert.ToInt32(numColuna.Value));
                lista.ExibirDataGridview(dgvUm);
            }
            else
            {
                if (lista2 == null)
                    throw new Exception("Matriz Vazia");
                lista2.RemoverEm(Convert.ToInt32(numLinha.Value), Convert.ToInt32(numColuna.Value));
                lista2.ExibirDataGridview(dgvDois);
            }
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            if (rbLista1.Checked)
            {
                if (lista == null)
                    throw new Exception("Matriz Vazia");
                //Chamamos o método já implementados na classe ListaLigadaCruzada e o exibimos
                txtValor.Text = lista.ValorDe(Convert.ToInt32(numLinha.Value), Convert.ToInt32(numColuna.Value)) + "";
            }
            else
            {
                if (lista2 == null)
                    throw new Exception("Matriz Vazia");
                txtValor.Text = lista2.ValorDe(Convert.ToInt32(numLinha.Value), Convert.ToInt32(numColuna.Value)) + "";
            }
        }

        private void BtnSomarK_Click(object sender, EventArgs e)
        {
            if (rbLista1.Checked)
            {
                if (lista == null)
                    throw new Exception("Matriz Vazia");
                //Chama-se os métodos já implementados na ListaLigadaCruzada
                lista.SomarNaColuna(double.Parse(txtValor.Text), Convert.ToInt32(numColuna.Value));
                lista.ExibirDataGridview(dgvUm);
            }
            else
            {
                if (lista2 == null)
                    throw new Exception("Matriz Vazia");
                lista2.SomarNaColuna(double.Parse(txtValor.Text), Convert.ToInt32(numColuna.Value));
                lista2.ExibirDataGridview(dgvDois);
            }
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            if (lista == null || lista2 == null)
                throw new Exception("Duas Matrizes Necessárias");//Caso o usuário não tenha fornecido uma das matrizes.

            //Chama-se os métodos já implementados na ListaLigadaCruzada
            resultado = lista.MultiplicarMatrizes(lista2);

            resultado.ExibirDataGridview(dgvResultado);
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            if (lista == null || lista2 == null)
                throw new Exception("Duas Matrizes Necessárias");

            //Chama-se os métodos já implementados na ListaLigadaCruzada
            resultado = lista.SomarMatrizes(lista2);

            resultado.ExibirDataGridview(dgvResultado);


        }

        private void BtnLerArquivo_Click(object sender, EventArgs e)
        {
            LerArquivo();
        }
    }
}
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

            if(dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                StreamReader arquivo = new StreamReader(dlgAbrir.FileName);
                int linhas = int.Parse(arquivo.ReadLine());
                int colunas = int.Parse(arquivo.ReadLine());
                ListaLigadaCruzada li = new ListaLigadaCruzada(linhas, colunas);

                while(!arquivo.EndOfStream)
                {
                    string texto = arquivo.ReadLine();

                    int linha = int.Parse(texto.Substring(1, 2));
                    int col = int.Parse(texto.Substring(4, 2));
                    int valor = int.Parse(texto.Substring(7, 3));

                    li.InserirElemento(valor, linha, col);
                }

                if(rbLista1.Checked)
                {
                    lista = li;
                    lista.ExibirDataGridview(dgvUm);
                }
                else
                {
                    lista2 = li;
                    lista.ExibirDataGridview(dgvDois);
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

            ListaLigadaCruzada lis = new ListaLigadaCruzada(Convert.ToInt32(numLinha.Value), Convert.ToInt32(numColuna.Value));

            if(rbLista1.Checked)
            {
                lista = lis;
                lista.ExibirDataGridview(dgvUm);
            }
            else
            {
                lista2 = lis;
                lista2.ExibirDataGridview(dgvDois);
            }
        }

        private void FrmMatrizEsparsa_Load(object sender, EventArgs e)
        {

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
          if(rbLista1.Checked)
            {
                if (lista == null)
                    throw new Exception("Matriz Vazia");
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
            if(rbLista1.Checked)
            {
                if (lista == null)
                    throw new Exception("Matriz Vazia");
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

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            if (lista == null || lista2 == null)
                throw new Exception("Duas Matrizes Necessárias");

            resultado = lista.SomarMatrizes(lista2);

            resultado.ExibirDataGridview(dgvResultado);


        }

        private void BtnLerArquivo_Click(object sender, EventArgs e)
        {
            LerArquivo();
        }
    }
}

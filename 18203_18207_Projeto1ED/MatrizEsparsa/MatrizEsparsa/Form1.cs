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

        public void LerArquivo()
        {

            if(dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                StreamReader arquivo = new StreamReader(dlgAbrir.FileName);
                int linhas = int.Parse(arquivo.ReadLine());
                int colunas = int.Parse(arquivo.ReadLine());

                ListaLigadaCruzada lista = new ListaLigadaCruzada(linhas, colunas);

                while(!arquivo.EndOfStream)
                {
                    string texto = arquivo.ReadLine();

                    int linha = int.Parse(texto.Substring(1, 2));
                    int col = int.Parse(texto.Substring(4, 2));
                    int valor = int.Parse(texto.Substring(7, 3));

                    lista.InserirElemento(valor, linha, col);
                }

                lista.ExibirDataGridview(dgvUm);
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
        }

        private void FrmMatrizEsparsa_Load(object sender, EventArgs e)
        {

        }

        private void BtnLerArquivo_Click(object sender, EventArgs e)
        {
            LerArquivo();
        }
    }
}

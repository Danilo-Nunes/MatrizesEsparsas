using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizEsparsa
{
    public partial class FrmMatrizEsparsa : Form
    {
        public FrmMatrizEsparsa()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (numColuna.Value == 0 || numLinha.Value == 0)
                MessageBox.Show("Não é possível criar matriz vazia");
        }
    }
}

namespace MatrizEsparsa
{
    partial class FrmMatrizEsparsa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panMatriz1 = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numColuna = new System.Windows.Forms.NumericUpDown();
            this.numLinha = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLerArquivo = new System.Windows.Forms.Button();
            this.dgvUm = new System.Windows.Forms.DataGridView();
            this.dgvDois = new System.Windows.Forms.DataGridView();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSomarK = new System.Windows.Forms.Button();
            this.rbLista1 = new System.Windows.Forms.RadioButton();
            this.rbLista2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panMatriz1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMatriz1
            // 
            this.panMatriz1.Controls.Add(this.label4);
            this.panMatriz1.Controls.Add(this.rbLista2);
            this.panMatriz1.Controls.Add(this.rbLista1);
            this.panMatriz1.Controls.Add(this.txtValor);
            this.panMatriz1.Controls.Add(this.btnRetornar);
            this.panMatriz1.Controls.Add(this.btnExcluir);
            this.panMatriz1.Controls.Add(this.btnSomarK);
            this.panMatriz1.Controls.Add(this.btnInserir);
            this.panMatriz1.Controls.Add(this.btnCriar);
            this.panMatriz1.Controls.Add(this.label3);
            this.panMatriz1.Controls.Add(this.label2);
            this.panMatriz1.Controls.Add(this.numColuna);
            this.panMatriz1.Controls.Add(this.numLinha);
            this.panMatriz1.Controls.Add(this.label1);
            this.panMatriz1.Controls.Add(this.btnLerArquivo);
            this.panMatriz1.Location = new System.Drawing.Point(18, 1);
            this.panMatriz1.Margin = new System.Windows.Forms.Padding(4);
            this.panMatriz1.Name = "panMatriz1";
            this.panMatriz1.Size = new System.Drawing.Size(558, 166);
            this.panMatriz1.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(337, 83);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(88, 26);
            this.txtValor.TabIndex = 10;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(458, 135);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(85, 28);
            this.btnRetornar.TabIndex = 9;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.BtnRetornar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(458, 68);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 28);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(458, 34);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(85, 28);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(458, 3);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(85, 28);
            this.btnCriar.TabIndex = 6;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Coluna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Linha";
            // 
            // numColuna
            // 
            this.numColuna.Location = new System.Drawing.Point(391, 53);
            this.numColuna.Name = "numColuna";
            this.numColuna.Size = new System.Drawing.Size(34, 26);
            this.numColuna.TabIndex = 3;
            // 
            // numLinha
            // 
            this.numLinha.Location = new System.Drawing.Point(391, 14);
            this.numLinha.Name = "numLinha";
            this.numLinha.Size = new System.Drawing.Size(34, 26);
            this.numLinha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ou";
            // 
            // btnLerArquivo
            // 
            this.btnLerArquivo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerArquivo.Location = new System.Drawing.Point(18, 27);
            this.btnLerArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLerArquivo.Name = "btnLerArquivo";
            this.btnLerArquivo.Size = new System.Drawing.Size(171, 64);
            this.btnLerArquivo.TabIndex = 0;
            this.btnLerArquivo.Text = "Ler Arquivo";
            this.btnLerArquivo.UseVisualStyleBackColor = true;
            this.btnLerArquivo.Click += new System.EventHandler(this.BtnLerArquivo_Click);
            // 
            // dgvUm
            // 
            this.dgvUm.AllowUserToAddRows = false;
            this.dgvUm.AllowUserToDeleteRows = false;
            this.dgvUm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUm.Location = new System.Drawing.Point(18, 174);
            this.dgvUm.Name = "dgvUm";
            this.dgvUm.ReadOnly = true;
            this.dgvUm.Size = new System.Drawing.Size(359, 300);
            this.dgvUm.TabIndex = 1;
            // 
            // dgvDois
            // 
            this.dgvDois.AllowUserToAddRows = false;
            this.dgvDois.AllowUserToDeleteRows = false;
            this.dgvDois.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDois.Location = new System.Drawing.Point(396, 174);
            this.dgvDois.Name = "dgvDois";
            this.dgvDois.ReadOnly = true;
            this.dgvDois.Size = new System.Drawing.Size(359, 300);
            this.dgvDois.TabIndex = 2;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(772, 174);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.Size = new System.Drawing.Size(359, 300);
            this.dgvResultado.TabIndex = 3;
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMultiplicar);
            this.panel1.Controls.Add(this.btnSomar);
            this.panel1.Location = new System.Drawing.Point(606, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 129);
            this.panel1.TabIndex = 4;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(4, 66);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(145, 34);
            this.btnMultiplicar.TabIndex = 13;
            this.btnMultiplicar.Text = "Multiplicar Matrizes";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(4, 25);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(145, 35);
            this.btnSomar.TabIndex = 12;
            this.btnSomar.Text = "Somar Matrizes";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.BtnSomar_Click);
            // 
            // btnSomarK
            // 
            this.btnSomarK.Location = new System.Drawing.Point(458, 101);
            this.btnSomarK.Name = "btnSomarK";
            this.btnSomarK.Size = new System.Drawing.Size(85, 28);
            this.btnSomarK.TabIndex = 11;
            this.btnSomarK.Text = "Somar";
            this.btnSomarK.UseVisualStyleBackColor = true;
            this.btnSomarK.Click += new System.EventHandler(this.BtnSomarK_Click);
            // 
            // rbLista1
            // 
            this.rbLista1.AutoSize = true;
            this.rbLista1.Checked = true;
            this.rbLista1.Location = new System.Drawing.Point(259, 7);
            this.rbLista1.Name = "rbLista1";
            this.rbLista1.Size = new System.Drawing.Size(68, 23);
            this.rbLista1.TabIndex = 11;
            this.rbLista1.TabStop = true;
            this.rbLista1.Text = "Lista 1";
            this.rbLista1.UseVisualStyleBackColor = true;
            this.rbLista1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rbLista2
            // 
            this.rbLista2.AutoSize = true;
            this.rbLista2.Location = new System.Drawing.Point(259, 27);
            this.rbLista2.Name = "rbLista2";
            this.rbLista2.Size = new System.Drawing.Size(68, 23);
            this.rbLista2.TabIndex = 12;
            this.rbLista2.Text = "Lista 2";
            this.rbLista2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor:";
            // 
            // FrmMatrizEsparsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.dgvDois);
            this.Controls.Add(this.dgvUm);
            this.Controls.Add(this.panMatriz1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMatrizEsparsa";
            this.Text = "Matriz";
            this.Load += new System.EventHandler(this.FrmMatrizEsparsa_Load);
            this.panMatriz1.ResumeLayout(false);
            this.panMatriz1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMatriz1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numColuna;
        private System.Windows.Forms.NumericUpDown numLinha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLerArquivo;
        private System.Windows.Forms.DataGridView dgvUm;
        private System.Windows.Forms.DataGridView dgvDois;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSomarK;
        private System.Windows.Forms.RadioButton rbLista1;
        private System.Windows.Forms.RadioButton rbLista2;
        private System.Windows.Forms.Label label4;
    }
}

